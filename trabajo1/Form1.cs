using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace trabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // This is a simple sum for whole numbers.
        // I tried to keep it easy to read, like a beginner would do.
        private void button1_Click(object sender, EventArgs e)
        {
            // read text from textBox1 and textBox2
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;

            int a, b;
            bool ok1 = int.TryParse(t1, out a);
            bool ok2 = int.TryParse(t2, out b);

            if (!ok1 || !ok2)
            {
                MessageBox.Show("Por favor ingresa números enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int suma = a + b; // suma de enteros

            // show result in a message box and update label so it is visible
            MessageBox.Show("La suma es: " + suma.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label5.Text = "Resultado: " + suma.ToString();
        }

        // This sums decimal numbers (like 1.5 or 2,3 depending on culture).
        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = textBox3.Text;
            string s2 = textBox4.Text;

            // try to parse using current culture so the user can use comma or dot
            decimal d1, d2;
            bool ok1 = decimal.TryParse(s1, NumberStyles.Number, CultureInfo.CurrentCulture, out d1);
            bool ok2 = decimal.TryParse(s2, NumberStyles.Number, CultureInfo.CurrentCulture, out d2);

            if (!ok1 || !ok2)
            {
                MessageBox.Show("Por favor ingresa números decimales válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal suma = d1 + d2;

            // show result and set label so it looks like a simple student work
            MessageBox.Show("La suma decimal es: " + suma.ToString(CultureInfo.CurrentCulture), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label6.Text = "Resultado: " + suma.ToString(CultureInfo.CurrentCulture);
        }
    }
}
