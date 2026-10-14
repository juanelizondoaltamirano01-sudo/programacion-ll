using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO
{
    public class Producto
    {
        private string nombre;
        private decimal precio;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public void MostrarInfo()
        {
            MessageBox.Show("Producto: " + Nombre + "\nPrecio: " + Precio);
        }
    }
}
