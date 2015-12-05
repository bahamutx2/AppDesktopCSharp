using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using EE4WebCam.ServiciosWeb;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using Microsoft.Expression.Encoder;
using System.IO;
using System.Net;
using System.Threading;

namespace EE4Test
{
    public partial class frmEE4WebCam : Form
    {

        private LiveJob _job; // Creates job for capture of live source
        ServiciosCamara sc = new ServiciosCamara();
        private int tiempovideo;
        private LiveDeviceSource _deviceSource;
        System.Timers.Timer timerGrabacion = null;
        private string nombrearchivo = "", nombrearvivo1 = "";

        private bool _bStartedRecording = false, inicio = false;

        public frmEE4WebCam()
        {
            InitializeComponent();
        }

        private void frmEE4WebCam_Load(object sender, EventArgs e)
        {
            // Cargar dispositivos de video y de audio
            lstVideoDevices.ClearSelected();
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                lstVideoDevices.Items.Add(edv.Name);
            }

            lstAudioDevices.ClearSelected();
            foreach (EncoderDevice eda in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                lstAudioDevices.Items.Add(eda.Name);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            EncoderDevice video = null;
            EncoderDevice audio = null;            
            GetSelectedVideoAndAudioDevices(out video, out audio);
            StopJob();

            if (video == null)
            {
                return;
            }

            _job = new LiveJob(); // Empieza captura
            
            if (video != null && audio != null)
            {
                _deviceSource = _job.AddDeviceSource(video, audio);
                _deviceSource.PickBestVideoFormat(new Size(640, 480), 15);

                SourceProperties sp = _deviceSource.SourcePropertiesSnapshot();

                panelVideoPreview.Size = new Size(sp.Size.Width, sp.Size.Height);

                _job.OutputFormat.VideoProfile.Size = new Size(sp.Size.Width, sp.Size.Height);


                _deviceSource.PreviewWindow = new PreviewWindow(new HandleRef(panelVideoPreview, panelVideoPreview.Handle));

                _job.ActivateSource(_deviceSource);

                btnStartStopRecording.Enabled = true;

            }
            else
            {
                MessageBox.Show("No se ha seleccionado dispositivo de audio o video", "Advertencia");
            }
        }

        private void btnStartStopRecording_Click(object sender, EventArgs e)
        {
            if (!inicio)
            {
                nombrecam = cbCamarasSistema.SelectedValue.ToString();
                IniciarGrabacion();
                timerGrabacion.Start();
                btnStartStopRecording.Text = "Detener grabación";
                inicio = true;
            }
            else
            {
                btnStartStopRecording.Enabled = false;
                timerGrabacion.Stop();
                DetenerGrabacion();
                inicio = false;
            }
        }

        private void GetSelectedVideoAndAudioDevices(out EncoderDevice video, out EncoderDevice audio)
        {
            video = null;
            audio = null;

            if (lstVideoDevices.SelectedIndex < 0 || lstAudioDevices.SelectedIndex < 0)
            {
                MessageBox.Show("No se ha seleccionado dispositivo de audio o video", "Advertencia");
                return;
            }

            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                if (String.Compare(edv.Name, lstVideoDevices.SelectedItem.ToString()) == 0)
                {
                    video = edv;
                    break;
                }
            }

            foreach (EncoderDevice eda in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                if (String.Compare(eda.Name, lstAudioDevices.SelectedItem.ToString()) == 0)
                {
                    audio = eda;
                    break;
                }
            }
        }

        void StopJob()
        {
            if (_job != null)
            {
                if (_bStartedRecording)
                {
                    btnStartStopRecording.PerformClick();
                }

                _job.StopEncoding();

                _job.RemoveDeviceSource(_deviceSource);

                _deviceSource.PreviewWindow = null;                
                _deviceSource = null;                
            }
        }

        private void frmEE4WebCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopJob();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string pass = textBox1.Text;
            bool respons = sc.ValidarUsuarioCSharp(username, pass);
            if (respons)
            {
                panelInicioSesion.Visible = false;
                cbCamarasSistema.DataSource = sc.ObtenerCamarasDisponibles();
                tiempovideo = sc.obtenerTiempoVideo()*60000;
                timerGrabacion = new System.Timers.Timer(tiempovideo);
                timerGrabacion.Elapsed += new System.Timers.ElapsedEventHandler(timerGrbacion);
            }
            else
            {
                MessageBox.Show("Verifique los datos ingresados", "Error al iniciar sesión");
            }
        }
        private string nombrecam;
        public void timerGrbacion(object sender, System.Timers.ElapsedEventArgs e)
        {
            DetenerGrabacion();
            IniciarGrabacion();
        }

        public void IniciarGrabacion()
        {
            try
            {
                FileArchivePublishFormat fileOut = new FileArchivePublishFormat();
                nombrearchivo = String.Format("{0}.{1:yyyy_MM_dd_hh_mm_ss}.wmv", nombrecam, DateTime.Now);
                fileOut.OutputFileName = "C:\\webcam\\" + nombrearchivo;
                nombrearvivo1 = nombrearvivo1 == "" ? nombrearchivo : nombrearvivo1;
                _job.PublishFormats.Add(fileOut);
                _job.StartEncoding();
                _bStartedRecording = true;
            }
            catch (Exception ex)
            {
            }
        }

        public void DetenerGrabacion()
        {
            try
            {
                _job.StopEncoding();
                _bStartedRecording = false;
                File.Copy("C:\\webcam\\" + nombrearvivo1, "C:\\webcam\\copy\\" + nombrearchivo);
                subirArchivo(nombrearchivo);
            }catch(Exception ex){
            }
        }

        public void subirArchivo(string nombrelocal)
        {
            string userName = "swebsoap";
            string host = "ftp://198.37.116.29/www.ciudadcontradelincuencia.somee.com".ToString();
            string remoteFile = "/archivos/" + nombrelocal;
            string localFile = "C:\\webcam\\copy\\" + nombrelocal;
            string pass = "Ingenieria123.";
            
            FtpWebResponse ftpResponse = null;
            FtpWebRequest ftpRequest = null;
            Stream stream = null;

            ftpRequest = (FtpWebRequest)WebRequest.Create(host + remoteFile);
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
            ftpRequest.Credentials = new NetworkCredential(userName, pass);

            StreamReader sourceStream = new StreamReader(localFile);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            ftpRequest.ContentLength = fileContents.Length;

            Stream requestStream = ftpRequest.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
            sc.subirVideoLogico(nombrelocal);
        }
    }
}
