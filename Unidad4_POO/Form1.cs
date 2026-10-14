using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Nombre = "Camiseta";
        p.Precio = 19.99m;
        p.MostrarInfo();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valido = true;

            if (txtNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio");
                valido = false;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                errorProvider1.SetError(txtPrecio, "Ingresa un número mayor que 0");
                valido = false;
            }

            if (!valido) return;

            Producto p = new Producto();
            p.Nombre = txtNombre.Text;
            p.Precio = precio;
            p.MostrarInfo();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
