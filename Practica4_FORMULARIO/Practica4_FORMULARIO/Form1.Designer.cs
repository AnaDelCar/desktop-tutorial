namespace Practica4_FORMULARIO
{
    partial class FORM_Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Label_Apellido = new System.Windows.Forms.Label();
            this.Label_Telefono = new System.Windows.Forms.Label();
            this.Label_Estatura = new System.Windows.Forms.Label();
            this.Label_Edad = new System.Windows.Forms.Label();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.TXT_Apellido = new System.Windows.Forms.TextBox();
            this.TXT_Telefono = new System.Windows.Forms.TextBox();
            this.TXT_Estatura = new System.Windows.Forms.TextBox();
            this.TXT_Edad = new System.Windows.Forms.TextBox();
            this.RadButton_Hombre = new System.Windows.Forms.RadioButton();
            this.RadButton_Mujer = new System.Windows.Forms.RadioButton();
            this.Label_Genero = new System.Windows.Forms.Label();
            this.Boton_Guardar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(73, 27);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(50, 13);
            this.Label_Nombre.TabIndex = 0;
            this.Label_Nombre.Text = "Nombre: ";
            // 
            // Label_Apellido
            // 
            this.Label_Apellido.AutoSize = true;
            this.Label_Apellido.Location = new System.Drawing.Point(76, 67);
            this.Label_Apellido.Name = "Label_Apellido";
            this.Label_Apellido.Size = new System.Drawing.Size(47, 13);
            this.Label_Apellido.TabIndex = 1;
            this.Label_Apellido.Text = "Apellido:";
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.AutoSize = true;
            this.Label_Telefono.Location = new System.Drawing.Point(76, 109);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.Size = new System.Drawing.Size(52, 13);
            this.Label_Telefono.TabIndex = 2;
            this.Label_Telefono.Text = "Telefono:";
            // 
            // Label_Estatura
            // 
            this.Label_Estatura.AutoSize = true;
            this.Label_Estatura.Location = new System.Drawing.Point(79, 148);
            this.Label_Estatura.Name = "Label_Estatura";
            this.Label_Estatura.Size = new System.Drawing.Size(52, 13);
            this.Label_Estatura.TabIndex = 3;
            this.Label_Estatura.Text = "Estatura: ";
            // 
            // Label_Edad
            // 
            this.Label_Edad.AutoSize = true;
            this.Label_Edad.Location = new System.Drawing.Point(82, 182);
            this.Label_Edad.Name = "Label_Edad";
            this.Label_Edad.Size = new System.Drawing.Size(35, 13);
            this.Label_Edad.TabIndex = 4;
            this.Label_Edad.Text = "Edad:";
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(221, 24);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TXT_Nombre.TabIndex = 5;
            // 
            // TXT_Apellido
            // 
            this.TXT_Apellido.Location = new System.Drawing.Point(221, 60);
            this.TXT_Apellido.Name = "TXT_Apellido";
            this.TXT_Apellido.Size = new System.Drawing.Size(100, 20);
            this.TXT_Apellido.TabIndex = 6;
            // 
            // TXT_Telefono
            // 
            this.TXT_Telefono.Location = new System.Drawing.Point(221, 102);
            this.TXT_Telefono.Name = "TXT_Telefono";
            this.TXT_Telefono.Size = new System.Drawing.Size(100, 20);
            this.TXT_Telefono.TabIndex = 7;
            // 
            // TXT_Estatura
            // 
            this.TXT_Estatura.Location = new System.Drawing.Point(221, 141);
            this.TXT_Estatura.Name = "TXT_Estatura";
            this.TXT_Estatura.Size = new System.Drawing.Size(100, 20);
            this.TXT_Estatura.TabIndex = 8;
            // 
            // TXT_Edad
            // 
            this.TXT_Edad.Location = new System.Drawing.Point(221, 179);
            this.TXT_Edad.Name = "TXT_Edad";
            this.TXT_Edad.Size = new System.Drawing.Size(100, 20);
            this.TXT_Edad.TabIndex = 9;
            // 
            // RadButton_Hombre
            // 
            this.RadButton_Hombre.AutoSize = true;
            this.RadButton_Hombre.Location = new System.Drawing.Point(458, 60);
            this.RadButton_Hombre.Name = "RadButton_Hombre";
            this.RadButton_Hombre.Size = new System.Drawing.Size(62, 17);
            this.RadButton_Hombre.TabIndex = 10;
            this.RadButton_Hombre.TabStop = true;
            this.RadButton_Hombre.Text = "Hombre";
            this.RadButton_Hombre.UseVisualStyleBackColor = true;
            // 
            // RadButton_Mujer
            // 
            this.RadButton_Mujer.AutoSize = true;
            this.RadButton_Mujer.Location = new System.Drawing.Point(573, 60);
            this.RadButton_Mujer.Name = "RadButton_Mujer";
            this.RadButton_Mujer.Size = new System.Drawing.Size(51, 17);
            this.RadButton_Mujer.TabIndex = 11;
            this.RadButton_Mujer.TabStop = true;
            this.RadButton_Mujer.Text = "Mujer";
            this.RadButton_Mujer.UseVisualStyleBackColor = true;
            // 
            // Label_Genero
            // 
            this.Label_Genero.AutoSize = true;
            this.Label_Genero.Location = new System.Drawing.Point(455, 31);
            this.Label_Genero.Name = "Label_Genero";
            this.Label_Genero.Size = new System.Drawing.Size(42, 13);
            this.Label_Genero.TabIndex = 12;
            this.Label_Genero.Text = "Genero";
            // 
            // Boton_Guardar
            // 
            this.Boton_Guardar.Location = new System.Drawing.Point(527, 120);
            this.Boton_Guardar.Name = "Boton_Guardar";
            this.Boton_Guardar.Size = new System.Drawing.Size(141, 54);
            this.Boton_Guardar.TabIndex = 13;
            this.Boton_Guardar.Text = "Guardar";
            this.Boton_Guardar.UseVisualStyleBackColor = true;
            this.Boton_Guardar.Click += new System.EventHandler(this.Boton_Guardar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(527, 206);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(141, 54);
            this.Boton_Cancelar.TabIndex = 14;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // FORM_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Guardar);
            this.Controls.Add(this.Label_Genero);
            this.Controls.Add(this.RadButton_Mujer);
            this.Controls.Add(this.RadButton_Hombre);
            this.Controls.Add(this.TXT_Edad);
            this.Controls.Add(this.TXT_Estatura);
            this.Controls.Add(this.TXT_Telefono);
            this.Controls.Add(this.TXT_Apellido);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.Label_Edad);
            this.Controls.Add(this.Label_Estatura);
            this.Controls.Add(this.Label_Telefono);
            this.Controls.Add(this.Label_Apellido);
            this.Controls.Add(this.Label_Nombre);
            this.Name = "FORM_Formulario";
            this.Text = "FORMULARIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label Label_Apellido;
        private System.Windows.Forms.Label Label_Telefono;
        private System.Windows.Forms.Label Label_Estatura;
        private System.Windows.Forms.Label Label_Edad;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.TextBox TXT_Apellido;
        private System.Windows.Forms.TextBox TXT_Telefono;
        private System.Windows.Forms.TextBox TXT_Estatura;
        private System.Windows.Forms.TextBox TXT_Edad;
        private System.Windows.Forms.RadioButton RadButton_Hombre;
        private System.Windows.Forms.RadioButton RadButton_Mujer;
        private System.Windows.Forms.Label Label_Genero;
        private System.Windows.Forms.Button Boton_Guardar;
        private System.Windows.Forms.Button Boton_Cancelar;
    }
}

