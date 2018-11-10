namespace Programa_2
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
            this.quick = new System.Windows.Forms.Button();
            this.bubble = new System.Windows.Forms.Button();
            this.merge = new System.Windows.Forms.Button();
            this.hearp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.TextBox();
            this.BottomText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quick
            // 
            this.quick.Location = new System.Drawing.Point(50, 121);
            this.quick.Name = "quick";
            this.quick.Size = new System.Drawing.Size(148, 23);
            this.quick.TabIndex = 0;
            this.quick.Text = "Quick Sort";
            this.quick.UseVisualStyleBackColor = true;
            this.quick.Click += new System.EventHandler(this.quick_Click);
            // 
            // bubble
            // 
            this.bubble.Location = new System.Drawing.Point(251, 121);
            this.bubble.Name = "bubble";
            this.bubble.Size = new System.Drawing.Size(148, 23);
            this.bubble.TabIndex = 1;
            this.bubble.Text = "Bubble Sort";
            this.bubble.UseVisualStyleBackColor = true;
            this.bubble.Click += new System.EventHandler(this.bubble_Click);
            // 
            // merge
            // 
            this.merge.Location = new System.Drawing.Point(50, 183);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(148, 23);
            this.merge.TabIndex = 2;
            this.merge.Text = "Merge Sort";
            this.merge.UseVisualStyleBackColor = true;
            this.merge.Click += new System.EventHandler(this.merge_Click);
            // 
            // hearp
            // 
            this.hearp.Location = new System.Drawing.Point(251, 183);
            this.hearp.Name = "hearp";
            this.hearp.Size = new System.Drawing.Size(148, 23);
            this.hearp.TabIndex = 3;
            this.hearp.Text = "Hearp Sort";
            this.hearp.UseVisualStyleBackColor = true;
            this.hearp.Click += new System.EventHandler(this.hearp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese una serie de numeros separados por comas";
            // 
            // lista
            // 
            this.lista.Location = new System.Drawing.Point(50, 67);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(349, 20);
            this.lista.TabIndex = 5;
            // 
            // BottomText
            // 
            this.BottomText.AutoSize = true;
            this.BottomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomText.Location = new System.Drawing.Point(47, 261);
            this.BottomText.Name = "BottomText";
            this.BottomText.Size = new System.Drawing.Size(265, 16);
            this.BottomText.TabIndex = 6;
            this.BottomText.Text = "Lista ordenada de los numeros: <numeros>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 376);
            this.Controls.Add(this.BottomText);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hearp);
            this.Controls.Add(this.merge);
            this.Controls.Add(this.bubble);
            this.Controls.Add(this.quick);
            this.Name = "Form1";
            this.Text = "Ordenamiento de numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quick;
        private System.Windows.Forms.Button bubble;
        private System.Windows.Forms.Button merge;
        private System.Windows.Forms.Button hearp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lista;
        private System.Windows.Forms.Label BottomText;
    }
}

