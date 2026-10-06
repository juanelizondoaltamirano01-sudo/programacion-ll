namespace Tarea_Unidad2_Cssharp
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
            this.components = new System.ComponentModel.Container();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.MaskedTextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.listBoxColores = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amarilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(63, 40);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(101, 22);
            this.txtnumero1.TabIndex = 0;
            this.txtnumero1.TextChanged += new System.EventHandler(this.txtnumero1_TextChanged);
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(48, 99);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(124, 22);
            this.txtnumero2.TabIndex = 1;
            this.txtnumero2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtnumero2_MaskInputRejected);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(251, 70);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 2;
            this.btnEvaluar.Text = "button1";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            // 
            // listBoxColores
            // 
            this.listBoxColores.FormattingEnabled = true;
            this.listBoxColores.ItemHeight = 16;
            this.listBoxColores.Location = new System.Drawing.Point(103, 193);
            this.listBoxColores.Name = "listBoxColores";
            this.listBoxColores.Size = new System.Drawing.Size(173, 52);
            this.listBoxColores.TabIndex = 3;
            this.listBoxColores.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verdeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 28);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rojoToolStripMenuItem});
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.verdeToolStripMenuItem.Text = "verde";
            // 
            // rojoToolStripMenuItem
            // 
            this.rojoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amarilloToolStripMenuItem});
            this.rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            this.rojoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rojoToolStripMenuItem.Text = "rojo ";
            // 
            // amarilloToolStripMenuItem
            // 
            this.amarilloToolStripMenuItem.Name = "amarilloToolStripMenuItem";
            this.amarilloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.amarilloToolStripMenuItem.Text = "amarillo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxColores);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.MaskedTextBox txtnumero2;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.ListBox listBoxColores;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rojoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amarilloToolStripMenuItem;
    }
}

