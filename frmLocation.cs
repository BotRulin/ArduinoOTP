using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoOTP
{
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerarCoordenades();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MostrarCoordenadesEnTabla();
        }

        Dictionary<string, int> coordenades = new Dictionary<string, int>();
        HashSet<int> valorsUtilitzats = new HashSet<int>();

        Random rand = new Random();
        char[] lletres = { 'A', 'B', 'C', 'D' };
        string coordenada;

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
                for (int i = 1; i <= 10; i++)
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
    }
}
