namespace EE4Test
{
    partial class frmEE4WebCam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelVideoPreview = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lstVideoDevices = new System.Windows.Forms.ListBox();
            this.lstAudioDevices = new System.Windows.Forms.ListBox();
            this.btnStartStopRecording = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCamarasSistema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInicioSesion = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInicioSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVideoPreview
            // 
            this.panelVideoPreview.Location = new System.Drawing.Point(374, 12);
            this.panelVideoPreview.Name = "panelVideoPreview";
            this.panelVideoPreview.Size = new System.Drawing.Size(354, 260);
            this.panelVideoPreview.TabIndex = 0;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(12, 342);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(173, 32);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Encender cámara";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lstVideoDevices
            // 
            this.lstVideoDevices.FormattingEnabled = true;
            this.lstVideoDevices.Location = new System.Drawing.Point(12, 80);
            this.lstVideoDevices.Name = "lstVideoDevices";
            this.lstVideoDevices.Size = new System.Drawing.Size(338, 108);
            this.lstVideoDevices.TabIndex = 3;
            // 
            // lstAudioDevices
            // 
            this.lstAudioDevices.FormattingEnabled = true;
            this.lstAudioDevices.Location = new System.Drawing.Point(12, 219);
            this.lstAudioDevices.Name = "lstAudioDevices";
            this.lstAudioDevices.Size = new System.Drawing.Size(338, 108);
            this.lstAudioDevices.TabIndex = 4;
            // 
            // btnStartStopRecording
            // 
            this.btnStartStopRecording.Enabled = false;
            this.btnStartStopRecording.Location = new System.Drawing.Point(191, 342);
            this.btnStartStopRecording.Name = "btnStartStopRecording";
            this.btnStartStopRecording.Size = new System.Drawing.Size(159, 32);
            this.btnStartStopRecording.TabIndex = 5;
            this.btnStartStopRecording.Text = "Empezar grabación";
            this.btnStartStopRecording.UseVisualStyleBackColor = true;
            this.btnStartStopRecording.Click += new System.EventHandler(this.btnStartStopRecording_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione la cámara";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbCamarasSistema
            // 
            this.cbCamarasSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamarasSistema.FormattingEnabled = true;
            this.cbCamarasSistema.Location = new System.Drawing.Point(12, 29);
            this.cbCamarasSistema.Name = "cbCamarasSistema";
            this.cbCamarasSistema.Size = new System.Drawing.Size(338, 21);
            this.cbCamarasSistema.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dispositivos de video disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dispositivos de audio disponibles";
            // 
            // panelInicioSesion
            // 
            this.panelInicioSesion.Controls.Add(this.button1);
            this.panelInicioSesion.Controls.Add(this.textBox1);
            this.panelInicioSesion.Controls.Add(this.label6);
            this.panelInicioSesion.Controls.Add(this.tbUserName);
            this.panelInicioSesion.Controls.Add(this.label5);
            this.panelInicioSesion.Controls.Add(this.label4);
            this.panelInicioSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicioSesion.Location = new System.Drawing.Point(0, 0);
            this.panelInicioSesion.Name = "panelInicioSesion";
            this.panelInicioSesion.Size = new System.Drawing.Size(1028, 532);
            this.panelInicioSesion.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contraseña";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(361, 53);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(148, 20);
            this.tbUserName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Inicio de sesión";
            // 
            // frmEE4WebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 532);
            this.Controls.Add(this.panelInicioSesion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCamarasSistema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartStopRecording);
            this.Controls.Add(this.lstAudioDevices);
            this.Controls.Add(this.lstVideoDevices);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.panelVideoPreview);
            this.Name = "frmEE4WebCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camara ciudad contra la delincuencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEE4WebCam_FormClosing);
            this.Load += new System.EventHandler(this.frmEE4WebCam_Load);
            this.panelInicioSesion.ResumeLayout(false);
            this.panelInicioSesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVideoPreview;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ListBox lstVideoDevices;
        private System.Windows.Forms.ListBox lstAudioDevices;
        private System.Windows.Forms.Button btnStartStopRecording;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCamarasSistema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInicioSesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

