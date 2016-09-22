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
      //  Empresa Emp1;
        
        
        public frmEmpleados(Empresa E1)
        {
            Empresa empresa = E1;
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

        
    }
}
