namespace MonedaWF
{
    partial class Resultados
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblWinNum = new System.Windows.Forms.Label();
            this.LblLoosNum = new System.Windows.Forms.Label();
            this.LblPerdidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ganados";
            // 
            // LblWinNum
            // 
            this.LblWinNum.AutoSize = true;
            this.LblWinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWinNum.Location = new System.Drawing.Point(152, 18);
            this.LblWinNum.Name = "LblWinNum";
            this.LblWinNum.Size = new System.Drawing.Size(0, 24);
            this.LblWinNum.TabIndex = 1;
            // 
            // LblLoosNum
            // 
            this.LblLoosNum.AutoSize = true;
            this.LblLoosNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoosNum.Location = new System.Drawing.Point(152, 73);
            this.LblLoosNum.Name = "LblLoosNum";
            this.LblLoosNum.Size = new System.Drawing.Size(0, 24);
            this.LblLoosNum.TabIndex = 3;
            // 
            // LblPerdidos
            // 
            this.LblPerdidos.AutoSize = true;
            this.LblPerdidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPerdidos.Location = new System.Drawing.Point(14, 73);
            this.LblPerdidos.Name = "LblPerdidos";
            this.LblPerdidos.Size = new System.Drawing.Size(82, 24);
            this.LblPerdidos.TabIndex = 2;
            this.LblPerdidos.Text = "Jugados";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 121);
            this.Controls.Add(this.LblLoosNum);
            this.Controls.Add(this.LblPerdidos);
            this.Controls.Add(this.LblWinNum);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Resultados_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblWinNum;
        private System.Windows.Forms.Label LblLoosNum;
        private System.Windows.Forms.Label LblPerdidos;
    }
}