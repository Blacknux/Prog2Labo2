namespace MonedaWF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmbLado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbLado
            // 
            this.CmbLado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLado.FormattingEnabled = true;
            this.CmbLado.Location = new System.Drawing.Point(42, 34);
            this.CmbLado.Name = "CmbLado";
            this.CmbLado.Size = new System.Drawing.Size(121, 21);
            this.CmbLado.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tirar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // BtnResultados
            // 
            this.BtnResultados.Location = new System.Drawing.Point(173, 90);
            this.BtnResultados.Name = "BtnResultados";
            this.BtnResultados.Size = new System.Drawing.Size(75, 23);
            this.BtnResultados.TabIndex = 2;
            this.BtnResultados.Text = "Resultados";
            this.BtnResultados.UseVisualStyleBackColor = true;
            this.BtnResultados.Click += new System.EventHandler(this.BtnResultados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 125);
            this.Controls.Add(this.BtnResultados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbLado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbLado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnResultados;
    }
}

