using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_1_suma_Decimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // wire button events
            this.btnMostrar.Click += btnMostrar_Click;
            this.btnLimpiar.Click += btnLimpiar_Click;
            this.btnSalir.Click += btnSalir_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // validate inputs and show summary
            try
            {
                bool ok = true;

                // reset visuals
                txtNombre.BackColor = SystemColors.Window;
                txtApellido.BackColor = SystemColors.Window;
                txtEmail.BackColor = SystemColors.Window;
                maskedTextBox1.BackColor = SystemColors.Window;

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    txtNombre.BackColor = Color.MistyRose;
                    txtNombre.Focus();
                    ok = false;
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    txtApellido.BackColor = Color.MistyRose;
                    if (ok) txtApellido.Focus();
                    ok = false;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
                {
                    txtEmail.BackColor = Color.MistyRose;
                    if (ok) txtEmail.Focus();
                    ok = false;
                }

                if (!int.TryParse(maskedTextBox1.Text, out int edad) || edad < 0)
                {
                    maskedTextBox1.BackColor = Color.MistyRose;
                    if (ok) maskedTextBox1.Focus();
                    ok = false;
                }

                if (!ok)
                {
                    MessageBox.Show("Por favor corrige los campos resaltados.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string resumen = $"Nombre: {txtNombre.Text}\nApellido: {txtApellido.Text}\nEmail: {txtEmail.Text}\nEdad: {edad}";
                MessageBox.Show(resumen, "Datos de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // clear fields
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            maskedTextBox1.Clear();

            txtNombre.BackColor = SystemColors.Window;
            txtApellido.BackColor = SystemColors.Window;
            txtEmail.BackColor = SystemColors.Window;
            maskedTextBox1.BackColor = SystemColors.Window;

            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
