
namespace ArduinoOTP
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.pnlConnectionArduino = new System.Windows.Forms.Panel();
            this.pnlCoor = new System.Windows.Forms.Panel();
            this.txtCoord = new System.Windows.Forms.TextBox();
            this.tlpCoord = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlQR = new System.Windows.Forms.Panel();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.imgQR = new System.Windows.Forms.PictureBox();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.pnlCamera = new System.Windows.Forms.Panel();
            this.btnNextQR = new System.Windows.Forms.Button();
            this.lblScan = new System.Windows.Forms.Label();
            this.txtValueQR = new System.Windows.Forms.TextBox();
            this.btnCamera = new System.Windows.Forms.Button();
            this.imgScanQR = new System.Windows.Forms.PictureBox();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlConnectionArduino.SuspendLayout();
            this.pnlCoor.SuspendLayout();
            this.tlpCoord.SuspendLayout();
            this.pnlQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).BeginInit();
            this.pnlCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgScanQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Digital-7", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Red;
            this.lblContador.Location = new System.Drawing.Point(4, 173);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(213, 38);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "Remaining Time";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnStart.Location = new System.Drawing.Point(11, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 33);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Digital-7", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(-2, 251);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 38);
            this.lblCountdown.TabIndex = 7;
            // 
            // cmbPorts
            // 
            this.cmbPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(109, 16);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(175, 37);
            this.cmbPorts.TabIndex = 8;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.lblPort.Location = new System.Drawing.Point(10, 19);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(93, 30);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnConnect.Location = new System.Drawing.Point(319, 16);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 33);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnNext.Location = new System.Drawing.Point(320, 100);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 33);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnQR
            // 
            this.btnQR.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnQR.Location = new System.Drawing.Point(158, 81);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(122, 70);
            this.btnQR.TabIndex = 12;
            this.btnQR.Text = "Generate QR";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Visible = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // pnlConnectionArduino
            // 
            this.pnlConnectionArduino.Controls.Add(this.cmbPorts);
            this.pnlConnectionArduino.Controls.Add(this.btnQR);
            this.pnlConnectionArduino.Controls.Add(this.lblContador);
            this.pnlConnectionArduino.Controls.Add(this.btnNext);
            this.pnlConnectionArduino.Controls.Add(this.btnStart);
            this.pnlConnectionArduino.Controls.Add(this.btnConnect);
            this.pnlConnectionArduino.Controls.Add(this.lblCountdown);
            this.pnlConnectionArduino.Controls.Add(this.lblPort);
            this.pnlConnectionArduino.Location = new System.Drawing.Point(12, 12);
            this.pnlConnectionArduino.Name = "pnlConnectionArduino";
            this.pnlConnectionArduino.Size = new System.Drawing.Size(436, 332);
            this.pnlConnectionArduino.TabIndex = 13;
            // 
            // pnlCoor
            // 
            this.pnlCoor.Controls.Add(this.txtCoord);
            this.pnlCoor.Controls.Add(this.tlpCoord);
            this.pnlCoor.Controls.Add(this.btnShow);
            this.pnlCoor.Controls.Add(this.btnGenerate);
            this.pnlCoor.Location = new System.Drawing.Point(12, 526);
            this.pnlCoor.Name = "pnlCoor";
            this.pnlCoor.Size = new System.Drawing.Size(659, 368);
            this.pnlCoor.TabIndex = 14;
            this.pnlCoor.Visible = false;
            // 
            // txtCoord
            // 
            this.txtCoord.Location = new System.Drawing.Point(402, 16);
            this.txtCoord.Name = "txtCoord";
            this.txtCoord.ReadOnly = true;
            this.txtCoord.Size = new System.Drawing.Size(100, 20);
            this.txtCoord.TabIndex = 8;
            // 
            // tlpCoord
            // 
            this.tlpCoord.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpCoord.ColumnCount = 6;
            this.tlpCoord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCoord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCoord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCoord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCoord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCoord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCoord.Controls.Add(this.label1, 1, 0);
            this.tlpCoord.Controls.Add(this.label2, 2, 0);
            this.tlpCoord.Controls.Add(this.label3, 3, 0);
            this.tlpCoord.Controls.Add(this.label4, 4, 0);
            this.tlpCoord.Controls.Add(this.label5, 5, 0);
            this.tlpCoord.Controls.Add(this.label6, 0, 1);
            this.tlpCoord.Controls.Add(this.label7, 0, 2);
            this.tlpCoord.Controls.Add(this.label8, 0, 3);
            this.tlpCoord.Controls.Add(this.label9, 0, 4);
            this.tlpCoord.Controls.Add(this.label10, 0, 0);
            this.tlpCoord.Location = new System.Drawing.Point(13, 64);
            this.tlpCoord.Name = "tlpCoord";
            this.tlpCoord.RowCount = 5;
            this.tlpCoord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCoord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCoord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCoord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCoord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCoord.Size = new System.Drawing.Size(634, 288);
            this.tlpCoord.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "    ";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnShow.Location = new System.Drawing.Point(158, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(109, 33);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnGenerate.Location = new System.Drawing.Point(15, 8);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 33);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlQR
            // 
            this.pnlQR.Controls.Add(this.btnScan);
            this.pnlQR.Controls.Add(this.btnGenerateQR);
            this.pnlQR.Controls.Add(this.txtQRCode);
            this.pnlQR.Controls.Add(this.imgQR);
            this.pnlQR.Controls.Add(this.lblQRCode);
            this.pnlQR.Controls.Add(this.pnlCamera);
            this.pnlQR.Location = new System.Drawing.Point(454, 12);
            this.pnlQR.Name = "pnlQR";
            this.pnlQR.Size = new System.Drawing.Size(796, 508);
            this.pnlQR.TabIndex = 15;
            this.pnlQR.Visible = false;
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnScan.Location = new System.Drawing.Point(184, 433);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(117, 42);
            this.btnScan.TabIndex = 18;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnGenerateQR.Location = new System.Drawing.Point(184, 52);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(117, 42);
            this.btnGenerateQR.TabIndex = 17;
            this.btnGenerateQR.Text = "Generate";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(8, 52);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(157, 42);
            this.txtQRCode.TabIndex = 16;
            // 
            // imgQR
            // 
            this.imgQR.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.imgQR.Location = new System.Drawing.Point(8, 110);
            this.imgQR.Name = "imgQR";
            this.imgQR.Size = new System.Drawing.Size(293, 317);
            this.imgQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgQR.TabIndex = 15;
            this.imgQR.TabStop = false;
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.lblQRCode.Location = new System.Drawing.Point(3, 7);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(317, 30);
            this.lblQRCode.TabIndex = 14;
            this.lblQRCode.Text = "Enter the username:";
            // 
            // pnlCamera
            // 
            this.pnlCamera.Controls.Add(this.btnNextQR);
            this.pnlCamera.Controls.Add(this.lblScan);
            this.pnlCamera.Controls.Add(this.txtValueQR);
            this.pnlCamera.Controls.Add(this.btnCamera);
            this.pnlCamera.Controls.Add(this.imgScanQR);
            this.pnlCamera.Controls.Add(this.cmbCameras);
            this.pnlCamera.Location = new System.Drawing.Point(366, 7);
            this.pnlCamera.Name = "pnlCamera";
            this.pnlCamera.Size = new System.Drawing.Size(418, 489);
            this.pnlCamera.TabIndex = 19;
            this.pnlCamera.Visible = false;
            // 
            // btnNextQR
            // 
            this.btnNextQR.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnNextQR.Location = new System.Drawing.Point(283, 426);
            this.btnNextQR.Name = "btnNextQR";
            this.btnNextQR.Size = new System.Drawing.Size(117, 42);
            this.btnNextQR.TabIndex = 13;
            this.btnNextQR.Text = "Next";
            this.btnNextQR.UseVisualStyleBackColor = true;
            this.btnNextQR.Click += new System.EventHandler(this.btnNextQR_Click);
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
            // txtValueQR
            // 
            this.txtValueQR.Location = new System.Drawing.Point(8, 378);
            this.txtValueQR.Multiline = true;
            this.txtValueQR.Name = "txtValueQR";
            this.txtValueQR.ReadOnly = true;
            this.txtValueQR.Size = new System.Drawing.Size(392, 42);
            this.txtValueQR.TabIndex = 12;
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
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
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
            // cmbCameras
            // 
            this.cmbCameras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(8, 50);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(256, 37);
            this.cmbCameras.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1282, 1019);
            this.Controls.Add(this.pnlConnectionArduino);
            this.Controls.Add(this.pnlQR);
            this.Controls.Add(this.pnlCoor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlConnectionArduino.ResumeLayout(false);
            this.pnlConnectionArduino.PerformLayout();
            this.pnlCoor.ResumeLayout(false);
            this.pnlCoor.PerformLayout();
            this.tlpCoord.ResumeLayout(false);
            this.tlpCoord.PerformLayout();
            this.pnlQR.ResumeLayout(false);
            this.pnlQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).EndInit();
            this.pnlCamera.ResumeLayout(false);
            this.pnlCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgScanQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Panel pnlConnectionArduino;
        private System.Windows.Forms.Panel pnlCoor;
        private System.Windows.Forms.TextBox txtCoord;
        private System.Windows.Forms.TableLayoutPanel tlpCoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlQR;
        private System.Windows.Forms.Panel pnlCamera;
        private System.Windows.Forms.Button btnNextQR;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.TextBox txtValueQR;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.PictureBox imgScanQR;
        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnGenerateQR;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.PictureBox imgQR;
        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.Timer timer1;
    }
}

