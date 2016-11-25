using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonedaWF
{
    public partial class Resultados : Form
    {
        public Resultados(int ganados, int Jugados)
        {
            InitializeComponent();
            this.LblLoosNum.Text = Jugados.ToString();
            this.LblWinNum.Text = ganados.ToString();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; 
            

        }

        private void Resultados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            
        }


    }
}
