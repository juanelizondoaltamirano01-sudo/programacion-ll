using System;
using System.Windows.Forms;

namespace TareaDias
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form
    {
        TextBox txtDia;
        Button btnMostrarDia;

        public Form1()
        {
            Text = "Tarea Programada 3";
            StartPosition = FormStartPosition.CenterScreen;
            Width = 420;
            Height = 160;

            txtDia = new TextBox { Location = new System.Drawing.Point(20, 20), Width = 100, Name = "txtDia" };
            btnMostrarDia = new Button { Location = new System.Drawing.Point(140, 18), Text = "Mostrar Día", Name = "btnMostrarDia" };

            Controls.Add(txtDia);
            Controls.Add(btnMostrarDia);

            txtDia.KeyPress += txtDia_KeyPress;
            btnMostrarDia.Click += btnMostrarDia_Click;
            FormClosing += Form1_FormClosing;
        }

        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace) and digits only
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDia.Text.Trim(), out int dia))
            {
                MessageBox.Show("Ingrese un número válido (1-7).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = dia switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => null
            };

            if (nombre == null)
            {
                MessageBox.Show("Número fuera de rango. Debe ser entre 1 y 7.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Día {dia}: {nombre}", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("¿Realmente desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
        }
    }
}using System;
using System.Windows.Forms;

namespace TareaDias
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}using System;
using System.Windows.Forms;

namespace TareaDias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // wire up handlers (you can also wire via Designer)
            txtDia.KeyPress += txtDia_KeyPress;
            btnMostrarDia.Click += btnMostrarDia_Click;
            this.FormClosing += Form1_FormClosing;
        }

        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace) and digits only
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDia.Text.Trim(), out int dia))
            {
                MessageBox.Show("Ingrese un número válido (1-7).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = dia switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => null
            };

            if (nombre == null)
            {
                MessageBox.Show("Número fuera de rango. Debe ser entre 1 y 7.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Día {dia}: {nombre}", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("¿Realmente desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
        }
    }
}using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
