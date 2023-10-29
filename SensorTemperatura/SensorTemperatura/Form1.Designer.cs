namespace SensorTemperatura
{
    partial class Form1
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
            this.botConectar = new System.Windows.Forms.Button();
            this.botDesconec = new System.Windows.Forms.Button();
            this.labTemperatura = new System.Windows.Forms.Label();
            this.labConexion = new System.Windows.Forms.Label();
            this.txtLimTem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botConectar
            // 
            this.botConectar.BackColor = System.Drawing.Color.Goldenrod;
            this.botConectar.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botConectar.Location = new System.Drawing.Point(104, 331);
            this.botConectar.Name = "botConectar";
            this.botConectar.Size = new System.Drawing.Size(206, 54);
            this.botConectar.TabIndex = 0;
            this.botConectar.Text = "CONECTAR";
            this.botConectar.UseVisualStyleBackColor = false;
            this.botConectar.Click += new System.EventHandler(this.botConectar_Click);
            // 
            // botDesconec
            // 
            this.botDesconec.BackColor = System.Drawing.Color.Goldenrod;
            this.botDesconec.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botDesconec.Location = new System.Drawing.Point(548, 331);
            this.botDesconec.Name = "botDesconec";
            this.botDesconec.Size = new System.Drawing.Size(209, 54);
            this.botDesconec.TabIndex = 1;
            this.botDesconec.Text = "DESCONECTAR";
            this.botDesconec.UseVisualStyleBackColor = false;
            this.botDesconec.Click += new System.EventHandler(this.botDesconec_Click);
            // 
            // labTemperatura
            // 
            this.labTemperatura.AutoSize = true;
            this.labTemperatura.Font = new System.Drawing.Font("Sitka Small", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemperatura.Location = new System.Drawing.Point(588, 193);
            this.labTemperatura.Name = "labTemperatura";
            this.labTemperatura.Size = new System.Drawing.Size(111, 48);
            this.labTemperatura.TabIndex = 2;
            this.labTemperatura.Text = "Temp";
            // 
            // labConexion
            // 
            this.labConexion.AutoSize = true;
            this.labConexion.Font = new System.Drawing.Font("Sitka Small", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConexion.Location = new System.Drawing.Point(127, 203);
            this.labConexion.Name = "labConexion";
            this.labConexion.Size = new System.Drawing.Size(152, 35);
            this.labConexion.TabIndex = 3;
            this.labConexion.Text = "CONEXION";
            // 
            // txtLimTem
            // 
            this.txtLimTem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimTem.Location = new System.Drawing.Point(133, 84);
            this.txtLimTem.Name = "txtLimTem";
            this.txtLimTem.Size = new System.Drawing.Size(100, 24);
            this.txtLimTem.TabIndex = 4;
            this.txtLimTem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "LIMITE DE TEMPERATURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "TEMPERATURA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimTem);
            this.Controls.Add(this.labConexion);
            this.Controls.Add(this.labTemperatura);
            this.Controls.Add(this.botDesconec);
            this.Controls.Add(this.botConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botConectar;
        private System.Windows.Forms.Button botDesconec;
        private System.Windows.Forms.Label labTemperatura;
        private System.Windows.Forms.Label labConexion;
        private System.Windows.Forms.TextBox txtLimTem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

