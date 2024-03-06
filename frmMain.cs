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
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using QRCoder;

namespace ArduinoOTP
{
    public partial class frmMain : Form
    {
        System.Timers.Timer aTimer;

        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //frmLocation frm = new frmLocation();
            //frm.Show();
            //btnNext.Visible = true;
            btnQR.Visible = true;

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmLocation frm = new frmLocation();
            //frm.Show();

            pnlCoor.Visible = true;
        }

        #region "Panel OTP"

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
        private void btnQR_Click(object sender, EventArgs e)
        {
            //frmQR frm = new frmQR();
            //frm.Show();

            pnlQR.Visible = true;
        }

        Random random = new Random();
        SerialPort serialPort;
        ArrayList numbers = new ArrayList() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Queue<string> otpQueue = new Queue<string>();
        int counter;
        string otpNumber = "";

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
        #endregion

        #region "Panel QR"
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void btnScan_Click(object sender, EventArgs e)
        {
            pnlCamera.Visible = true;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cmbCameras.Items.Add(filterInfoCollection);
            }

            cmbCameras.SelectedIndex = 0;
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            imgQR.Image = code.GetGraphic(5);
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCameras.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();

            timer1.Start();
        }

        private void btnNextQR_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }

            pnlCoor.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imgScanQR.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)imgScanQR.Image);

                if (result != null)
                {
                    txtValueQR.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
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

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            imgScanQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        #endregion

        #region "Panel Coordenades"

        Dictionary<string, int> coordenades = new Dictionary<string, int>();
        HashSet<int> valorsUtilitzats = new HashSet<int>();
        Random rand = new Random();
        char[] lletres = { 'A', 'B', 'C', 'D' };
        string coordenada;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerarCoordenades();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MostrarCoordenadesEnTabla();
        }

        private void MostrarCoordenadesEnTabla()
        {
            int position = tlpCoord.Controls.Count - 1;

            for (int i = position; i >= 0; i--)
            {
                var control = tlpCoord.Controls[i];
                var row = tlpCoord.GetCellPosition(control).Row;
                var column = tlpCoord.GetCellPosition(control).Column;

                if (row != 0 && column != 0)
                {
                    tlpCoord.Controls.Remove(control);
                }
            }

            foreach (char lletra in lletres)
            {
                for (int i = 1; i <= 5; i++)
                {
                    coordenada = $"{lletra}{i}";

                    Label lblValor = new Label();
                    lblValor.Text = coordenades[coordenada].ToString().PadLeft(4, '0');
                    lblValor.Dock = DockStyle.Fill;

                    tlpCoord.Controls.Add(lblValor);
                }
            }

            coordenada = "D3";
            txtCoord.Text = coordenades[coordenada].ToString().PadLeft(4, '0');
        }

        private void GenerarCoordenades()
        {
            coordenades.Clear();

            foreach (char lletra in lletres)
            {
                for (int i = 1; i <= 5; i++)
                {
                    int valor;
                    do
                    {
                        valor = rand.Next(10000);
                    } while (valorsUtilitzats.Contains(valor));

                    valorsUtilitzats.Add(valor);

                    coordenada = $"{lletra}{i}";
                    coordenades.Add(coordenada, valor);
                }
            }
        }
        #endregion
    }
}
