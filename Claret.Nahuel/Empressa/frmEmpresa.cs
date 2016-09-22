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

namespace Empressa
{
    public partial class frmEmpresa : Form
    {
        Empresa _empresa;

        public Empresa empresa
        {
            get { return this._empresa; }
            set { this._empresa = value; }
        }
        public frmEmpresa(Empresa empresaP)
        {

            InitializeComponent();
            this.empresa = empresaP;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if () { MessageBox.Show("JDDJ"); }
            
            if (!(this.empresa ==null) && !((string.IsNullOrEmpty(this.txtRazonSocial.Text) || string.IsNullOrEmpty(this.txtDireccion.Text) || string.IsNullOrEmpty(this.mtxtGanancias.Text)))) 
            {
                this._empresa.direccion = this.txtDireccion.Text;
                this._empresa.razonSocial = this.txtRazonSocial.Text;
                this._empresa.ganancias = float.Parse(this.mtxtGanancias.Text.Replace(".", ",").Substring(1, this.mtxtGanancias.TextLength - 1));
            }
            else
            {     float auxGanancias;
            //if (float.TryParse(this.mtxtGanancias.Text.Replace('.', ',').Substring(1, this.mtxtGanancias.Text.Length - 1),out auxGanancias)) { }
                    this.empresa = new Empresa(this.txtRazonSocial.Text, this.txtDireccion.Text,float.Parse(this.mtxtGanancias.Text.Replace('.', ',').Substring(1, this.mtxtGanancias.Text.Length - 1) ));
                   
            }
            Form frmEmple = new frmEmpleados(empresa);
            this.Hide();
            frmEmple.ShowDialog();

            //frmEmple.Show();
            //this.Close();
                    
                 

            }

        
        }



    }


