using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaOriginal = txtPalabra.Text;
            string clave = "miclave"; // Reemplaza "miclave" por la clave que desees utilizar

            if (cadenaOriginal.Length >= clave.Length)
            {
                string subcadena = cadenaOriginal.Substring(0, clave.Length);
                string cadenaEncriptada = "";

                for (int i = 0; i < clave.Length; i++)
                {
                    int asciiCadena = (int)subcadena[i];
                    int asciiClave = (int)clave[i];
                    int asciiResultado = asciiCadena ^ asciiClave;
                    cadenaEncriptada += BitConverter.ToString(new byte[] { (byte)asciiResultado });

                }
                txtResultado.Text = cadenaEncriptada;
            }
            else
            {
                MessageBox.Show("La longitud de la palabra debe ser mayor o igual que la longitud de la clave.", "Error de encriptación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
