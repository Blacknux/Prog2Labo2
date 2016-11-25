using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Threading; 

namespace MonedaWF
{
    public partial class Form1 : Form
    {
        Moneda moneda ;
        int _ganados=0;
        int _jugados=0; 
        public Form1()
        {
            InitializeComponent();
            moneda = new Moneda();
            moneda.Ganar += new MonedaWins(Ganamos);
            moneda.Perder += new MonedaLoose(Perdimos);
            foreach (ELado item in Enum.GetValues(typeof(ELado)))
            {
                this.CmbLado.Items.Add(item); 
            
            }
            CmbLado.SelectedIndex = 1; 
            this.Text = "Moneda Game";
            CmbLado.Focus();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            this.MinimizeBox = false; 

        }

        public void Ganamos()
        {
            MessageBox.Show("Ganaste");
            this._ganados++; 
        }

        public void Perdimos(ELado lado)
        {
            MessageBox.Show("Perdiste, salio: " + lado); 
        
         }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            moneda.Tirar((ELado)CmbLado.SelectedItem);
            this._jugados++; 
        }

        private void BtnResultados_Click(object sender, EventArgs e)
        {
            Resultados resultados = new Resultados(this._ganados, this._jugados);
            resultados.Owner = this;

            resultados.Owner.Hide(); 
            resultados.ShowDialog();
             
            resultados.Owner.Show();
            
           
        }

        
    }
}
