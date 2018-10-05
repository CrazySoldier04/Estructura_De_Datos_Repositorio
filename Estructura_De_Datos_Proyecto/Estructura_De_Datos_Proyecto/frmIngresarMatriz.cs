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
    public partial class frmIngresarMatriz : Form
    {
        public frmIngresarMatriz()
        {
            InitializeComponent();
        }

        ErrorProvider error = new ErrorProvider();
        int col = 0;
        int ren = 0;

        private void txtColumnas_TextChanged(object sender, EventArgs e)
        {
            if (!RegularExpressions.NumerosEnteros(txtColumnas.Text))
            {
                txtColumnas.Clear();
                txtColumnas.Focus();
            }
            else if (txtColumnas.Text == "")
            {

            }
            else if(Convert.ToInt32(txtColumnas.Text) < 1)
            {
                txtColumnas.Focus();
                txtColumnas.Clear();
            }
            else if (Convert.ToInt32(txtColumnas.Text) > 25)
            {
                txtColumnas.Focus();
                txtColumnas.Clear();
            }
        }

        private void txtRenglones_TextChanged(object sender, EventArgs e)
        {
            if (!RegularExpressions.NumerosEnteros(txtRenglones.Text))
            {
                txtRenglones.Clear();
                txtRenglones.Focus();
            }
            else if (txtRenglones.Text == "")
            {

            }
            else if (Convert.ToInt32(txtRenglones.Text) < 1)
            {
                txtRenglones.Focus();
                txtRenglones.Clear();
            }
            else if (Convert.ToInt32(txtRenglones.Text) > 25)
            {
                txtRenglones.Focus();
                txtRenglones.Clear();
            }
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            if (txtColumnas.Text == "" && txtRenglones.Text == "")
            {
                MessageBox.Show("Los campos están vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (txtColumnas.Text == "")
            {
                error.SetError(txtColumnas, "El campo está vacío");
                txtColumnas.Focus();
            }
            else if (txtRenglones.Text == "")
            {
                error.SetError(txtRenglones, "El campo está vacío");
                txtRenglones.Focus();
            }
            else
            {
                col = Convert.ToInt32(txtColumnas.Text);
                ren = Convert.ToInt32(txtRenglones.Text);
                frmSumaDeMatrices ventana = new frmSumaDeMatrices(col, ren);
                this.Hide();
                ventana.ShowDialog();
            }
        }
    }
}
