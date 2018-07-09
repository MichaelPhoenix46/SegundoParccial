namespace SegundoParcial
{
    partial class MainForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeTalleresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.entradaDeArticulosToolStripMenuItem,
            this.registroDeTalleresToolStripMenuItem,
            this.registroDeVehiculosToolStripMenuItem,
            this.registroDeMantenimientoToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.articuloToolStripMenuItem.Text = "Registro de Articulos";
            this.articuloToolStripMenuItem.Click += new System.EventHandler(this.articuloToolStripMenuItem_Click);
            // 
            // entradaDeArticulosToolStripMenuItem
            // 
            this.entradaDeArticulosToolStripMenuItem.Name = "entradaDeArticulosToolStripMenuItem";
            this.entradaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.entradaDeArticulosToolStripMenuItem.Text = "Registro Entrada de Articulos";
            this.entradaDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeArticulosToolStripMenuItem_Click);
            // 
            // registroDeTalleresToolStripMenuItem
            // 
            this.registroDeTalleresToolStripMenuItem.Name = "registroDeTalleresToolStripMenuItem";
            this.registroDeTalleresToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.registroDeTalleresToolStripMenuItem.Text = "Registro de Talleres";
            this.registroDeTalleresToolStripMenuItem.Click += new System.EventHandler(this.registroDeTalleresToolStripMenuItem_Click);
            // 
            // registroDeVehiculosToolStripMenuItem
            // 
            this.registroDeVehiculosToolStripMenuItem.Name = "registroDeVehiculosToolStripMenuItem";
            this.registroDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.registroDeVehiculosToolStripMenuItem.Text = "Registro de Vehiculos";
            this.registroDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.registroDeVehiculosToolStripMenuItem_Click);
            // 
            // registroDeMantenimientoToolStripMenuItem
            // 
            this.registroDeMantenimientoToolStripMenuItem.Name = "registroDeMantenimientoToolStripMenuItem";
            this.registroDeMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.registroDeMantenimientoToolStripMenuItem.Text = "Registro de Mantenimiento";
            this.registroDeMantenimientoToolStripMenuItem.Click += new System.EventHandler(this.registroDeMantenimientoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeTalleresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeMantenimientoToolStripMenuItem;
    }
}

