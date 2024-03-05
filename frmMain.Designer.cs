
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
            this.lblContador = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.pnlConnectionArduino = new System.Windows.Forms.Panel();
            this.pnlConnectionArduino.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Digital-7", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Red;
            this.lblContador.Location = new System.Drawing.Point(8, 177);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(213, 38);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "Remaining Time";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnStart.Location = new System.Drawing.Point(15, 104);
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
            this.btnNext.Location = new System.Drawing.Point(324, 104);
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
            this.btnQR.Enabled = false;
            this.btnQR.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnQR.Location = new System.Drawing.Point(162, 104);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(122, 33);
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
            this.pnlConnectionArduino.Size = new System.Drawing.Size(464, 332);
            this.pnlConnectionArduino.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1235, 433);
            this.Controls.Add(this.pnlConnectionArduino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlConnectionArduino.ResumeLayout(false);
            this.pnlConnectionArduino.PerformLayout();
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
    }
}

