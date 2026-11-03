using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica_Programada5
{
    public partial class Form1 : Form
    {
        private readonly List<Empleado> empleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Nacimiento_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("Ingrese un año válido");
                return;
            }

            if (!decimal.TryParse(txtSueldo.Text, out decimal sueldo) || sueldo <= 0)
            {
                MessageBox.Show("Ingrese un sueldo mayor que cero");
                return;
            }

            Empleado nuevo = new Empleado();

            nuevo.Nombre = txtNombre.Text;
            nuevo.AnioNacimiento = anio;
            nuevo.Sueldo = sueldo;

            empleados.Add(nuevo);

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;

            txtNombre.Clear();
            txtAnio.Clear();
            txtSueldo.Clear();

            MessageBox.Show("Empleado agregado correctamente");
        }
    }
}
