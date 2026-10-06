using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Unidad2_Cssharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.btnEvaluar.Click += btnEvaluar_Click;
        }
        private void txtnumero2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // populate listBoxColores if empty
            try
            {
                if (this.listBoxColores.Items.Count == 0)
                {
                    this.listBoxColores.Items.AddRange(new object[] { "Rojo", "Verde", "Amarillo" });
                }

                // wire context menu items
                if (this.verdeToolStripMenuItem != null)
                    this.verdeToolStripMenuItem.Click += (s, ev) => this.BackColor = Color.Green;
                if (this.rojoToolStripMenuItem != null)
                    this.rojoToolStripMenuItem.Click += (s, ev) => this.BackColor = Color.Red;
                if (this.amarilloToolStripMenuItem != null)
                    this.amarilloToolStripMenuItem.Click += (s, ev) => this.BackColor = Color.Yellow;

                // ensure listbox selection event is wired
                this.listBoxColores.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
                this.listBoxColores.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            }
            catch
            {
                // ignore initialization errors
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var lb = sender as ListBox ?? this.listBoxColores;
                string sel = lb?.SelectedItem as string;
                if (string.IsNullOrEmpty(sel)) return;

                switch (sel.ToLowerInvariant())
                {
                    case "rojo": this.BackColor = Color.Red; break;
                    case "verde": this.BackColor = Color.Green; break;
                    case "amarillo": this.BackColor = Color.Yellow; break;
                    default: break;
                }
            }
            catch
            {
            }
        }

        private void txtnumero1_TextChanged(object sender, EventArgs e)
        {
            // no-op
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            // validate and compare values from txtnumero1 and txtnumero2 (masked)
            try
            {
                double n1, n2;
                bool ok1 = double.TryParse(this.txtnumero1.Text, out n1);
                bool ok2 = double.TryParse(this.txtnumero2.Text, out n2);

                // reset visuals
                this.txtnumero1.BackColor = SystemColors.Window;
                this.txtnumero2.BackColor = SystemColors.Window;

                if (!ok1 || !ok2)
                {
                    if (!ok1) this.txtnumero1.BackColor = Color.MistyRose;
                    if (!ok2) this.txtnumero2.BackColor = Color.MistyRose;
                    MessageBox.Show("Por favor ingresa números válidos en los campos resaltados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (n1 > n2)
                    MessageBox.Show($"El número mayor es {n1}.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (n2 > n1)
                    MessageBox.Show($"El número mayor es {n2}.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"Los dos números son iguales: {n1}.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }
    }
}
