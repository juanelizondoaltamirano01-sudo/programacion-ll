namespace Unidad_3_mostrar_dias_numeros
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDia1 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnMostrarDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDia1
            // 
            this.lblDia1.AutoSize = true;
            this.lblDia1.Location = new System.Drawing.Point(134, 105);
            this.lblDia1.Name = "lblDia1";
            this.lblDia1.Size = new System.Drawing.Size(188, 20);
            this.lblDia1.TabIndex = 0;
            this.lblDia1.Text = "Ingrese un dia del 1 al 7:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(125, 128);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(180, 22);
            this.txtDia.TabIndex = 1;
            // 
            // btnMostrarDia
            // 
            this.btnMostrarDia.Location = new System.Drawing.Point(150, 165);
            this.btnMostrarDia.Name = "btnMostrarDia";
            this.btnMostrarDia.Size = new System.Drawing.Size(122, 23);
            this.btnMostrarDia.TabIndex = 2;
            this.btnMostrarDia.Text = "Mostrar Dia";
            this.btnMostrarDia.UseVisualStyleBackColor = true;
            this.btnMostrarDia.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarDia);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblDia1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia1;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button btnMostrarDia;
    }
}

