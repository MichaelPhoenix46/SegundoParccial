namespace SegundoParcial.UI.Registros
{
    partial class rTalleres
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
            System.Windows.Forms.Label tallerIdLabel;
            System.Windows.Forms.Label nombreLabel;
            this.tallerIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            tallerIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tallerIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tallerIdLabel
            // 
            tallerIdLabel.AutoSize = true;
            tallerIdLabel.Location = new System.Drawing.Point(41, 44);
            tallerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tallerIdLabel.Name = "tallerIdLabel";
            tallerIdLabel.Size = new System.Drawing.Size(63, 17);
            tallerIdLabel.TabIndex = 48;
            tallerIdLabel.Text = "Taller Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(41, 79);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 46;
            nombreLabel.Text = "Nombre:";
            // 
            // tallerIdNumericUpDown
            // 
            this.tallerIdNumericUpDown.Location = new System.Drawing.Point(121, 44);
            this.tallerIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.tallerIdNumericUpDown.Name = "tallerIdNumericUpDown";
            this.tallerIdNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.tallerIdNumericUpDown.TabIndex = 49;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(121, 76);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(132, 22);
            this.nombreTextBox.TabIndex = 47;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatAppearance.BorderSize = 0;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(351, 124);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(100, 68);
            this.Eliminarbutton.TabIndex = 45;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.FlatAppearance.BorderSize = 0;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(199, 124);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(100, 68);
            this.Guardarbutton.TabIndex = 44;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatAppearance.BorderSize = 0;
            this.Nuevobutton.Location = new System.Drawing.Point(47, 124);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(100, 68);
            this.Nuevobutton.TabIndex = 43;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(285, 42);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 59);
            this.Buscarbutton.TabIndex = 42;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // rTalleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 249);
            this.Controls.Add(tallerIdLabel);
            this.Controls.Add(this.tallerIdNumericUpDown);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "rTalleres";
            this.Text = "rTalleres";
            ((System.ComponentModel.ISupportInitialize)(this.tallerIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tallerIdNumericUpDown;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}