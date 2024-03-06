using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace ArduinoOTP
{
    public partial class frmQR : Form
    {
        public frmQR()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            imgQR.Image = code.GetGraphic(5);
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCameras.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();

            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            imgScanQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
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

        private void pnlCamera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQRCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgQR_Click(object sender, EventArgs e)
        {

        }

        private void lblQRCode_Click(object sender, EventArgs e)
        {

        }
    }
}
