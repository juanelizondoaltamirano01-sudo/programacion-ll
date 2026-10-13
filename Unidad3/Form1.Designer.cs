namespace TareaDias
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
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnMostrarDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(60, 71);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(211, 22);
            this.txtDia.TabIndex = 0;
            // 
            // btnMostrarDia
            // 
            this.btnMostrarDia.Location = new System.Drawing.Point(89, 122);
            this.btnMostrarDia.Name = "btnMostrarDia";
            this.btnMostrarDia.Size = new System.Drawing.Size(144, 31);
            this.btnMostrarDia.TabIndex = 1;
            this.btnMostrarDia.Text = "Mostrar dia ";
            this.btnMostrarDia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarDia);
            this.Controls.Add(this.txtDia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button btnMostrarDia;
    }
}

