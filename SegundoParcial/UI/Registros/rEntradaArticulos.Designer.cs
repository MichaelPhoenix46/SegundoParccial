namespace SegundoParcial.UI.Registros
{
    partial class rEntradaArticulos
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label articulosLabel;
            System.Windows.Forms.Label entradaIdLabel;
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.articulosComboBox = new System.Windows.Forms.ComboBox();
            this.entradaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.GuardarBotton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            cantidadLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            articulosLabel = new System.Windows.Forms.Label();
            entradaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(23, 171);
            cantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(68, 17);
            cantidadLabel.TabIndex = 56;
            cantidadLabel.Text = "Cantidad:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(204, 6);
            fechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(51, 17);
            fechaLabel.TabIndex = 54;
            fechaLabel.Text = "Fecha:";
            // 
            // articulosLabel
            // 
            articulosLabel.AutoSize = true;
            articulosLabel.Location = new System.Drawing.Point(23, 107);
            articulosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            articulosLabel.Name = "articulosLabel";
            articulosLabel.Size = new System.Drawing.Size(66, 17);
            articulosLabel.TabIndex = 52;
            articulosLabel.Text = "Articulos:";
            // 
            // entradaIdLabel
            // 
            entradaIdLabel.AutoSize = true;
            entradaIdLabel.Location = new System.Drawing.Point(23, 49);
            entradaIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            entradaIdLabel.Name = "entradaIdLabel";
            entradaIdLabel.Size = new System.Drawing.Size(77, 17);
            entradaIdLabel.TabIndex = 51;
            entradaIdLabel.Text = "Entrada Id:";
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(110, 169);
            this.cantidadNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.cantidadNumericUpDown.TabIndex = 58;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(263, 6);
            this.fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(128, 22);
            this.fechaDateTimePicker.TabIndex = 57;
            // 
            // articulosComboBox
            // 
            this.articulosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articulosComboBox.FormattingEnabled = true;
            this.articulosComboBox.Location = new System.Drawing.Point(110, 101);
            this.articulosComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.articulosComboBox.Name = "articulosComboBox";
            this.articulosComboBox.Size = new System.Drawing.Size(160, 24);
            this.articulosComboBox.TabIndex = 55;
            // 
            // entradaIdNumericUpDown
            // 
            this.entradaIdNumericUpDown.Location = new System.Drawing.Point(110, 47);
            this.entradaIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.entradaIdNumericUpDown.Name = "entradaIdNumericUpDown";
            this.entradaIdNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.entradaIdNumericUpDown.TabIndex = 53;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatAppearance.BorderSize = 0;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(278, 226);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(100, 68);
            this.Eliminarbutton.TabIndex = 50;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // GuardarBotton
            // 
            this.GuardarBotton.FlatAppearance.BorderSize = 0;
            this.GuardarBotton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarBotton.Location = new System.Drawing.Point(155, 226);
            this.GuardarBotton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarBotton.Name = "GuardarBotton";
            this.GuardarBotton.Size = new System.Drawing.Size(100, 68);
            this.GuardarBotton.TabIndex = 49;
            this.GuardarBotton.Text = "Guardar";
            this.GuardarBotton.UseVisualStyleBackColor = true;
            this.GuardarBotton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatAppearance.BorderSize = 0;
            this.Nuevobutton.Location = new System.Drawing.Point(18, 226);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(100, 68);
            this.Nuevobutton.TabIndex = 48;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(278, 36);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 59);
            this.Buscarbutton.TabIndex = 47;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // rEntradaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 321);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(articulosLabel);
            this.Controls.Add(this.articulosComboBox);
            this.Controls.Add(entradaIdLabel);
            this.Controls.Add(this.entradaIdNumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.GuardarBotton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "rEntradaArticulos";
            this.Text = "Entrada De Articulos";
            this.Load += new System.EventHandler(this.EntradaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox articulosComboBox;
        private System.Windows.Forms.NumericUpDown entradaIdNumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button GuardarBotton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}