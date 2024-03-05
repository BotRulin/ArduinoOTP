using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace ArduinoOTP
{
    public partial class frmMain : Form
    {
        System.Timers.Timer aTimer;
        Random random = new Random();
        SerialPort serialPort;
        ArrayList numbers = new ArrayList() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Queue<string> otpQueue = new Queue<string>();

        int counter;
        string otpNumber = "";

        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLocation frm = new frmLocation();
            frm.Show();

            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;

            string[] ports = SerialPort.GetPortNames();

            if (ports.Length > 0)
            {
                cmbPorts.Items.AddRange(ports);
            }
            else
            {
                cmbPorts.Items.Add("No hay puertos disponibles");
                cmbPorts.Enabled = false;
                btnConnect.Enabled = false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string selectedPort = cmbPorts.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedPort))
            {
                serialPort.PortName = selectedPort;
                try
                {
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el puerto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un puerto COM válido.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            counter = 60;

            otpNumber = GenerateNumber();
            serialPort.Write(otpNumber);
            Mail();
            SetTimer();
            SerialReceive();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLocation frm = new frmLocation();
            frm.Show();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            frmQR frm = new frmQR();
            frm.Show();
            btnNext.Visible = true;
        }

        public void SetTimer()
        {
            aTimer = new System.Timers.Timer(1000);

            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            counter--;
            int minutes = counter / 60;
            int seconds = counter % 60;

            lblCountdown.Text = $"{minutes.ToString()} : {seconds.ToString()}";

            if (counter == 0)
            {
                aTimer.Stop();
                lblCountdown.Text = "BOOOOMM!!";
                btnStart.Enabled = true;
            }
        }

        private void ReceiveData()
        {
            try
            {
                string response = serialPort.ReadLine();

                if (response.Length > 0)
                {
                    string dato = response.Replace("\r", "");

                    if (dato == "1")
                    {
                        aTimer.Stop();
                        btnNext.Invoke((MethodInvoker)delegate
                        {
                            btnQR.Visible = true;
                        });
                    }
                    else
                    {
                        aTimer.Stop();
                        lblCountdown.Text = "Incorrect Pass";
                        btnStart.Enabled = true;
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recibir datos: " + ex.Message);
            }
        }

        private void Mail()
        {
            string strUser = "darkcore.g2@gmail.com";
            string strPassword = "qewqluzictxdouhq";
            string host = "smtp.gmail.com";
            int port = 587;

            SmtpClient client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(strUser, strPassword),
                EnableSsl = true
            };

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("darkcore.g2@gmail.com");
            mail.To.Add("raul.exposito@sarria.salesians.cat");
            mail.Subject = "OTP Arduino Random";
            mail.Body = otpNumber;
            client.Send(mail);
        }

        private string GenerateNumber()
        {
            for (int i = 0; i < 6; i++)
            {
                int index = random.Next(0, (numbers.Count - 1));

                otpQueue.Enqueue(numbers[index].ToString());
                numbers.RemoveAt(index);
            }

            while (otpQueue.Count > 0)
            {
                otpNumber += otpQueue.Dequeue();
            }

            otpNumber = otpNumber.PadLeft(6, '0');

            return otpNumber;
        }

        private void SerialReceive()
        {
            Thread filEscolta = new Thread(ReceiveData);
            filEscolta.Start();
        }
    }
}
