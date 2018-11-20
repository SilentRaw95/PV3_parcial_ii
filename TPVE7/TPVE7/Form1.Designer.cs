namespace TPVE7
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
            this.label1 = new System.Windows.Forms.Label();
            this.campo_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.campo_fecha = new System.Windows.Forms.DateTimePicker();
            this.campo_entrada = new System.Windows.Forms.DateTimePicker();
            this.campo_salida = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // campo_nombre
            // 
            this.campo_nombre.AccessibleName = "campo_nombre";
            this.campo_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo_nombre.Location = new System.Drawing.Point(17, 41);
            this.campo_nombre.Name = "campo_nombre";
            this.campo_nombre.Size = new System.Drawing.Size(314, 29);
            this.campo_nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salida";
            // 
            // guardar
            // 
            this.guardar.AccessibleName = "guardar";
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(12, 270);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(316, 42);
            this.guardar.TabIndex = 8;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "(Completar formulario)";
            // 
            // buscar
            // 
            this.buscar.AccessibleName = "buscar";
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(12, 372);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(316, 42);
            this.buscar.TabIndex = 10;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "(Solo nombre)";
            // 
            // campo_fecha
            // 
            this.campo_fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campo_fecha.Location = new System.Drawing.Point(17, 111);
            this.campo_fecha.Name = "campo_fecha";
            this.campo_fecha.Size = new System.Drawing.Size(314, 20);
            this.campo_fecha.TabIndex = 12;
            // 
            // campo_entrada
            // 
            this.campo_entrada.CustomFormat = "HH:mm";
            this.campo_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campo_entrada.Location = new System.Drawing.Point(17, 190);
            this.campo_entrada.Name = "campo_entrada";
            this.campo_entrada.Size = new System.Drawing.Size(155, 20);
            this.campo_entrada.TabIndex = 13;
            // 
            // campo_salida
            // 
            this.campo_salida.CustomFormat = "HH:mm";
            this.campo_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campo_salida.Location = new System.Drawing.Point(178, 190);
            this.campo_salida.Name = "campo_salida";
            this.campo_salida.Size = new System.Drawing.Size(153, 20);
            this.campo_salida.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.campo_salida);
            this.Controls.Add(this.campo_entrada);
            this.Controls.Add(this.campo_fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campo_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campo_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker campo_fecha;
        private System.Windows.Forms.DateTimePicker campo_entrada;
        private System.Windows.Forms.DateTimePicker campo_salida;
    }
}

