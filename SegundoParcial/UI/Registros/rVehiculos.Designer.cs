namespace SegundoParcial.UI.Registros
{
    partial class rVehiculos
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
            System.Windows.Forms.Label mantenimientoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label vehiculosIdLabel;
            this.mantenimientoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.vehiculosIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            mantenimientoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            vehiculosIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mantenimientoLabel
            // 
            mantenimientoLabel.AutoSize = true;
            mantenimientoLabel.Location = new System.Drawing.Point(28, 114);
            mantenimientoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mantenimientoLabel.Name = "mantenimientoLabel";
            mantenimientoLabel.Size = new System.Drawing.Size(140, 17);
            mantenimientoLabel.TabIndex = 45;
            mantenimientoLabel.Text = "Total Mantenimiento:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(28, 80);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 43;
            descripcionLabel.Text = "Descripcion:";
            // 
            // vehiculosIdLabel
            // 
            vehiculosIdLabel.AutoSize = true;
            vehiculosIdLabel.Location = new System.Drawing.Point(28, 42);
            vehiculosIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vehiculosIdLabel.Name = "vehiculosIdLabel";
            vehiculosIdLabel.Size = new System.Drawing.Size(88, 17);
            vehiculosIdLabel.TabIndex = 42;
            vehiculosIdLabel.Text = "Vehiculos Id:";
            // 
            // mantenimientoTextBox
            // 
            this.mantenimientoTextBox.Location = new System.Drawing.Point(178, 114);
            this.mantenimientoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mantenimientoTextBox.Name = "mantenimientoTextBox";
            this.mantenimientoTextBox.ReadOnly = true;
            this.mantenimientoTextBox.Size = new System.Drawing.Size(159, 22);
            this.mantenimientoTextBox.TabIndex = 47;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(178, 76);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(159, 22);
            this.descripcionTextBox.TabIndex = 46;
            // 
            // vehiculosIdNumericUpDown
            // 
            this.vehiculosIdNumericUpDown.Location = new System.Drawing.Point(178, 39);
            this.vehiculosIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.vehiculosIdNumericUpDown.Name = "vehiculosIdNumericUpDown";
            this.vehiculosIdNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.vehiculosIdNumericUpDown.TabIndex = 44;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatAppearance.BorderSize = 0;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(363, 157);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(100, 68);
            this.Eliminarbutton.TabIndex = 41;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.FlatAppearance.BorderSize = 0;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(211, 157);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(100, 68);
            this.Guardarbutton.TabIndex = 40;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatAppearance.BorderSize = 0;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nuevobutton.Location = new System.Drawing.Point(59, 157);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(100, 68);
            this.Nuevobutton.TabIndex = 39;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(364, 32);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 59);
            this.Buscarbutton.TabIndex = 38;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // rVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 287);
            this.Controls.Add(mantenimientoLabel);
            this.Controls.Add(this.mantenimientoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(vehiculosIdLabel);
            this.Controls.Add(this.vehiculosIdNumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "rVehiculos";
            this.Text = "Registro de vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mantenimientoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.NumericUpDown vehiculosIdNumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}