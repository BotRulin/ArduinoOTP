using System;
using System.Drawing;
using System.IO.Ports;
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
        int counter;

        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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
            counter = 120;
            lblNum.Text = (random.Next(100000, 999999)).ToString();
            serialPort.Write(lblNum.Text.ToString());

            SetTimer();
            SerialReceive();
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
                lblNum.Text = "BOOOOMM!!";
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
                        imgRandomCode.Image = Image.FromFile("tick.png");
                        MessageBox.Show("Correct");
                    }
                    else
                    {
                        imgRandomCode.Image = Image.FromFile("error.png");
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recibir datos: " + ex.Message);
            }
        }

        private void SerialReceive()
        {
            Thread filEscolta = new Thread(ReceiveData);
            filEscolta.Start();
        }

        private void CheckCodeArduino()
        {

        }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
