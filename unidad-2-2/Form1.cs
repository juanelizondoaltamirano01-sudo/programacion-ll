using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Tarea_unidad2_CSsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // attach load handler to populate UI after designer initialization
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PopulateColors()
        {
            // Ensure labelColors and ListBox are added to the form if Designer was edited
            try
            {
                if (this.labelColors != null && !this.Controls.Contains(this.labelColors))
                    this.Controls.Add(this.labelColors);

                // try to find listbox created in designer using common names
                ListBox lb = FindListBox("listBoxColores", "ListBox", "listBox1");
                if (lb != null)
                {
                    if (!this.Controls.Contains(lb)) this.Controls.Add(lb);
                    lb.Visible = true;
                    lb.BackColor = SystemColors.Window;
                    lb.ForeColor = SystemColors.ControlText;
                    lb.Items.Clear();
                    lb.Items.AddRange(new object[] { "Rojo", "Verde", "Azul", "Amarillo", "Blanco", "Negro", "Naranja", "Morado" });
                    lb.SelectedIndexChanged -= ListBox_SelectedIndexChanged;
                    lb.SelectedIndexChanged += ListBox_SelectedIndexChanged;
                }
                else
                {
                    // create a ListBox at runtime
                    lb = new System.Windows.Forms.ListBox();
                    lb.Location = new System.Drawing.Point(68, 204);
                    lb.Size = new System.Drawing.Size(144, 52);
                    lb.BackColor = SystemColors.Window;
                    lb.ForeColor = SystemColors.ControlText;
                    lb.Items.AddRange(new object[] { "Rojo", "Verde", "Azul", "Amarillo", "Blanco", "Negro", "Naranja", "Morado" });
                    lb.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
                    this.Controls.Add(lb);
                }
            }
            catch
            {
                // ignore UI population errors for now
            }
        }

        private ListBox FindListBox(params string[] names)
        {
            foreach (var name in names)
            {
                if (string.IsNullOrEmpty(name)) continue;
                var matches = this.Controls.Find(name, true);
                if (matches != null && matches.Length > 0)
                {
                    var lb = matches[0] as ListBox;
                    if (lb != null) return lb;
                }
            }
            // fallback: first ListBox on the form
            var any = this.Controls.OfType<ListBox>().FirstOrDefault();
            return any;
        }

        private TextBox FindTextBox(params string[] names)
        {
            foreach (var name in names)
            {
                if (string.IsNullOrEmpty(name)) continue;
                var matches = this.Controls.Find(name, true);
                if (matches != null && matches.Length > 0)
                {
                    var tb = matches[0] as TextBox;
                    if (tb != null) return tb;
                }
            }
            // fallback: first TextBox on the form
            return this.Controls.OfType<TextBox>().FirstOrDefault();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // map Spanish names to actual Color values
            try
            {
                ListBox lb = sender as ListBox ?? FindListBox("listBoxColores", "ListBox", "listBox1");
                string sel = lb?.SelectedItem as string;
                if (string.IsNullOrEmpty(sel)) return;

                Color c = GetColorFromSpanishName(sel);
                this.BackColor = c;
            }
            catch
            {
                // ignore errors for beginners
            }
        }

        private Color GetColorFromSpanishName(string name)
        {
            switch (name?.ToLowerInvariant())
            {
                case "rojo": return Color.Red;
                case "verde": return Color.Green;
                case "azul": return Color.Blue;
                case "amarillo": return Color.Yellow;
                case "blanco": return Color.White;
                case "negro": return Color.Black;
                case "naranja": return Color.Orange;
                case "morado": return Color.Purple;
                default: return this.BackColor;
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            // validate inputs visually and show which number is greater
            var tb1 = FindTextBox("txtNumero1", "txtnumero1", "textBox1");
            var tb2 = FindTextBox("txtNumero2", "txtnumero2", "textBox2");

            if (tb1 == null || tb2 == null)
            {
                MessageBox.Show("No se encontraron los campos de entrada en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string s1 = tb1.Text ?? string.Empty;
            string s2 = tb2.Text ?? string.Empty;

            double n1, n2;
            bool ok1 = double.TryParse(s1, NumberStyles.Number, CultureInfo.CurrentCulture, out n1);
            bool ok2 = double.TryParse(s2, NumberStyles.Number, CultureInfo.CurrentCulture, out n2);

            // reset visuals
            tb1.BackColor = SystemColors.Window;
            tb2.BackColor = SystemColors.Window;

            if (!ok1 || !ok2)
            {
                // highlight invalid fields
                if (!ok1)
                {
                    tb1.BackColor = Color.MistyRose;
                    tb1.Focus();
                }
                if (!ok2)
                {
                    tb2.BackColor = Color.MistyRose;
                    if (ok1) tb2.Focus();
                }

                MessageBox.Show("Por favor ingresa números válidos en los campos resaltados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // both valid: clear highlights
            tb1.BackColor = SystemColors.Window;
            tb2.BackColor = SystemColors.Window;

            if (n1 > n2)
                MessageBox.Show($"El número mayor es {n1} (primer número).", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (n2 > n1)
                MessageBox.Show($"El número mayor es {n2} (segundo número).", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Los dos números son iguales: {n1}.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cambiarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open a ColorDialog to change the background color dynamically
            try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog1.Color;
                }
            }
            catch
            {
                // do nothing on error
            }
        }

        // Designer references labelColors.Click; provide a safe no-op handler
        private void labelColors_Click(object sender, EventArgs e)
        {
            // intentionally empty - label click not used
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
