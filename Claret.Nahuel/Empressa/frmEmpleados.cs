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
    public partial class frmEmpleados : Form
    {
       Empresa _empresaEmpleados;
        
        
        public frmEmpleados()
        {
            
            InitializeComponent();
            this.cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.mtxtLegajo.Text = "";
            this.mtxtSalario.Text = "";
            this.cmbPuesto.SelectedIndex=-1;

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa formEmpres = new frmEmpresa(this._empresaEmpleados);
            formEmpres.ShowDialog();
            if( formEmpres.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._empresaEmpleados=formEmpres.empresa;
            }
            this.Close();
        }

        
    }
}
