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
    public partial class frmMCD : Form
    {
        public frmMCD()
        {
            InitializeComponent();
        }

        private int MCD(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                a = a < 0 ? a * -1 : a;
                b = b < 0 ? b * -1 : b;
                return MCD(a, b);
            }
            else if (b > a)
            {
                //MessageBox.Show("Pase una vez");
                return MCD(b, a);
            }
            else if (b == 0)
            {
                //MessageBox.Show("Pase al resultado");
                return a;
            }

            else return MCD(a - b, b);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Favor de llenar los campos numéricos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                txtMaximo.Text = MCD(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtMaximo.Clear();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
