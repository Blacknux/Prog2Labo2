using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agregando_numeros
{
    public partial class frmListaNumeros : Form
    {

       static double[] arrayNumeros;
        static int Cantidad = 0;
        
        public frmListaNumeros()
        {

            InitializeComponent();
            this.lblNumeros.Text = " Numeros: \n";
            this.btnAgregar.Text = "&Agregar";

        } 


        

        private static double validarNumero(string strNumero)
        {
            double retorno=-1;
            bool validacion = double.TryParse(strNumero, out retorno);
            if (validacion == false)
            {
                retorno = -1;
            }

            return retorno;
        }

        private static bool agrandaArray()
        {
            bool retorno=false;
            double[] arrayNumerosaux = new double[Cantidad + 1];
            if (!arrayNumerosaux.Equals(null))
            {
                Cantidad++;
                if(!object.Equals( arrayNumeros,null))
                {
                    arrayNumeros.CopyTo( arrayNumerosaux,0);
                }
                arrayNumeros = arrayNumerosaux;
                retorno = true;

            }
            return retorno;
        }

        public static void cargaNumero(string strNumero)
        {
            if (agrandaArray())
            {
                arrayNumeros[Cantidad-1] = validarNumero(strNumero);
            }
            else
            {
                MessageBox.Show("Error en la carga del dato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string Mostrar(double[] listaNumeros)
        {
            string retorno="Numeros: \n";

            for (int i = 0; i < Cantidad; i++)
            {
                retorno += listaNumeros[i].ToString() + "\n";
                
            }

            return retorno;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarNumero(this.txtAgregarNumero.Text) != -1)
            {
                cargaNumero(this.txtAgregarNumero.Text);
                lblNumeros.Text = Mostrar(arrayNumeros);

                this.BackColor = Color.GreenYellow;
            }
            else
            {
                this.BackColor = Color.OrangeRed;
                lblNumeros.Text = "Usted no ingreso un numero.\n Try Again....";
            }
            this.txtAgregarNumero.Text = "";
            this.txtAgregarNumero.Focus();
        }

        //private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        btnAgregar(sender,e);
        //    }
        //}

       
    }
   
}
