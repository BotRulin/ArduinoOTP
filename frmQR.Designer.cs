
namespace ArduinoOTP
{
    partial class frmQR
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
            this.components = new System.ComponentModel.Container();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.imgQR = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblScan = new System.Windows.Forms.Label();
            this.btnCamera = new System.Windows.Forms.Button();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.imgScanQR = new System.Windows.Forms.PictureBox();
            this.txtValueQR = new System.Windows.Forms.TextBox();
            this.pnlCamera = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCodeChain = new System.Windows.Forms.RichTextBox();
            this.txtUserDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScanQR)).BeginInit();
            this.pnlCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.lblQRCode.Location = new System.Drawing.Point(27, 30);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(317, 30);
            this.lblQRCode.TabIndex = 0;
            this.lblQRCode.Text = "Enter the username:";
            // 
            // imgQR
            // 
            this.imgQR.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.imgQR.Location = new System.Drawing.Point(32, 270);
            this.imgQR.Name = "imgQR";
            this.imgQR.Size = new System.Drawing.Size(447, 180);
            this.imgQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgQR.TabIndex = 2;
            this.imgQR.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtUsername.Location = new System.Drawing.Point(32, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 32);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtQRCode_Validating);
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnGenerateQR.Location = new System.Drawing.Point(362, 75);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(117, 42);
            this.btnGenerateQR.TabIndex = 6;
            this.btnGenerateQR.Text = "Generate";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnScan.Location = new System.Drawing.Point(362, 456);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(117, 42);
            this.btnScan.TabIndex = 7;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.lblScan.Location = new System.Drawing.Point(3, 0);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(413, 30);
            this.lblScan.TabIndex = 8;
            this.lblScan.Text = "Select Camera to Scan QR:";
            // 
            // btnCamera
            // 
            this.btnCamera.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnCamera.Location = new System.Drawing.Point(283, 45);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(117, 42);
            this.btnCamera.TabIndex = 9;
            this.btnCamera.Text = "Enable";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // cmbCameras
            // 
            this.cmbCameras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(8, 50);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(256, 37);
            this.cmbCameras.TabIndex = 10;
            // 
            // imgScanQR
            // 
            this.imgScanQR.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.imgScanQR.Location = new System.Drawing.Point(8, 103);
            this.imgScanQR.Name = "imgScanQR";
            this.imgScanQR.Size = new System.Drawing.Size(392, 260);
            this.imgScanQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgScanQR.TabIndex = 11;
            this.imgScanQR.TabStop = false;
            // 
            // txtValueQR
            // 
            this.txtValueQR.Location = new System.Drawing.Point(8, 378);
            this.txtValueQR.Multiline = true;
            this.txtValueQR.Name = "txtValueQR";
            this.txtValueQR.Size = new System.Drawing.Size(392, 42);
            this.txtValueQR.TabIndex = 12;
            // 
            // pnlCamera
            // 
            this.pnlCamera.Controls.Add(this.btnNext);
            this.pnlCamera.Controls.Add(this.lblScan);
            this.pnlCamera.Controls.Add(this.txtValueQR);
            this.pnlCamera.Controls.Add(this.btnCamera);
            this.pnlCamera.Controls.Add(this.imgScanQR);
            this.pnlCamera.Controls.Add(this.cmbCameras);
            this.pnlCamera.Location = new System.Drawing.Point(532, 30);
            this.pnlCamera.Name = "pnlCamera";
            this.pnlCamera.Size = new System.Drawing.Size(418, 489);
            this.pnlCamera.TabIndex = 13;
            this.pnlCamera.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnNext.Location = new System.Drawing.Point(283, 426);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 42);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtCodeChain
            // 
            this.txtCodeChain.Location = new System.Drawing.Point(32, 133);
            this.txtCodeChain.Name = "txtCodeChain";
            this.txtCodeChain.Size = new System.Drawing.Size(447, 110);
            this.txtCodeChain.TabIndex = 14;
            this.txtCodeChain.Text = "";
            // 
            // txtUserDesc
            // 
            this.txtUserDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtUserDesc.Location = new System.Drawing.Point(195, 79);
            this.txtUserDesc.Name = "txtUserDesc";
            this.txtUserDesc.ReadOnly = true;
            this.txtUserDesc.Size = new System.Drawing.Size(157, 32);
            this.txtUserDesc.TabIndex = 15;
            // 
            // frmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1515, 781);
            this.Controls.Add(this.txtUserDesc);
            this.Controls.Add(this.txtCodeChain);
            this.Controls.Add(this.pnlCamera);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnGenerateQR);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.imgQR);
            this.Controls.Add(this.lblQRCode);
            this.Name = "frmQR";
            this.Text = "frmQR";
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScanQR)).EndInit();
            this.pnlCamera.ResumeLayout(false);
            this.pnlCamera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.PictureBox imgQR;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnGenerateQR;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.PictureBox imgScanQR;
        private System.Windows.Forms.TextBox txtValueQR;
        private System.Windows.Forms.Panel pnlCamera;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtCodeChain;
        private System.Windows.Forms.TextBox txtUserDesc;
    }
}