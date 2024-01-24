
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
            this.txtArduino = new System.Windows.Forms.TextBox();
            this.lblOTPCode = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRandomText = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.imgRandomCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgRandomCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Digital-7", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Red;
            this.lblContador.Location = new System.Drawing.Point(127, 317);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(213, 38);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "Remaining Time";
            // 
            // txtArduino
            // 
            this.txtArduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArduino.Location = new System.Drawing.Point(49, 265);
            this.txtArduino.Name = "txtArduino";
            this.txtArduino.Size = new System.Drawing.Size(269, 35);
            this.txtArduino.TabIndex = 1;
            // 
            // lblOTPCode
            // 
            this.lblOTPCode.AutoSize = true;
            this.lblOTPCode.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTPCode.Location = new System.Drawing.Point(44, 232);
            this.lblOTPCode.Name = "lblOTPCode";
            this.lblOTPCode.Size = new System.Drawing.Size(141, 30);
            this.lblOTPCode.TabIndex = 2;
            this.lblOTPCode.Text = "OTP Code";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Courier New", 20F);
            this.lblNum.Location = new System.Drawing.Point(248, 133);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 30);
            this.lblNum.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnStart.Location = new System.Drawing.Point(49, 177);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 33);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRandomText
            // 
            this.lblRandomText.AutoSize = true;
            this.lblRandomText.Font = new System.Drawing.Font("Courier New", 20F);
            this.lblRandomText.Location = new System.Drawing.Point(44, 133);
            this.lblRandomText.Name = "lblRandomText";
            this.lblRandomText.Size = new System.Drawing.Size(205, 30);
            this.lblRandomText.TabIndex = 6;
            this.lblRandomText.Text = "Random Code:";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Digital-7", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(207, 369);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 38);
            this.lblCountdown.TabIndex = 7;
            // 
            // cmbPorts
            // 
            this.cmbPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(143, 53);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(175, 37);
            this.cmbPorts.TabIndex = 8;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.lblPort.Location = new System.Drawing.Point(44, 56);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(93, 30);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnConnect.Location = new System.Drawing.Point(344, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 33);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Courier New", 15F);
            this.btnCheck.Location = new System.Drawing.Point(344, 265);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(114, 33);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // imgRandomCode
            // 
            this.imgRandomCode.BackColor = System.Drawing.Color.Transparent;
            this.imgRandomCode.Location = new System.Drawing.Point(375, 133);
            this.imgRandomCode.Name = "imgRandomCode";
            this.imgRandomCode.Size = new System.Drawing.Size(114, 77);
            this.imgRandomCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRandomCode.TabIndex = 12;
            this.imgRandomCode.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(534, 420);
            this.Controls.Add(this.imgRandomCode);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cmbPorts);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblRandomText);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblOTPCode);
            this.Controls.Add(this.txtArduino);
            this.Controls.Add(this.lblContador);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRandomCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtArduino;
        private System.Windows.Forms.Label lblOTPCode;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRandomText;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox imgRandomCode;
    }
}

