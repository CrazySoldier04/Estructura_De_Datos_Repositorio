using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_De_Datos_Proyecto
{
    public partial class frmPruebaDeFibonacci : Form
    {
        public frmPruebaDeFibonacci()
        {
            InitializeComponent();
        }

        ErrorProvider error = new ErrorProvider();

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if(!RegularExpressions.NumerosEnteros(txtNumero.Text))
            {
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPruebaDeFibonacci_Load(object sender, EventArgs e)
        {
            txtNumero.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text == "")
            {
                error.SetError(txtNumero, "El campo está vacío");
                txtNumero.Focus();
            }
            else
            {
                error.SetError(txtNumero, "");
            }
        }
    }
}
