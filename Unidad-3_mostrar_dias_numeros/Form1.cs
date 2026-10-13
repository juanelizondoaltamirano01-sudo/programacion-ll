using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_3_mostrar_dias_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia;

            if (!int.TryParse(txtDia.Text, out dia))
            {
                MessageBox.Show("Ingrese un número válido.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (dia)
                {
                    case 1:
                        MessageBox.Show("Lunes :( ");
                        break;

                    case 2:
                        MessageBox.Show("Martes :( ");
                        break;

                    case 3:
                        MessageBox.Show("Miércoles :( ");
                        break;

                    case 4:
                        MessageBox.Show("Jueves :( ");
                        break;

                    case 5:
                        MessageBox.Show("Viernes :( ");
                        break;

                    case 6:
                        MessageBox.Show("Sábado :) ");
                        break;

                    case 7:
                        MessageBox.Show("Domingo :)");
                        break;

                    default:
                        MessageBox.Show("Error: ingrese un número del 1 al 7.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Realmente desea salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
