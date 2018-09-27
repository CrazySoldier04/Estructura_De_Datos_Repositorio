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
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
            int f0 = 0;
            int f1 = 1;
            int fn = 0;
            dgvDatos.Rows.Add("0");

            if (Convert.ToInt32(txtLimite.Text) == 1)
            {
                dgvDatos.Rows.Add("1");
            }

            for (int i = 0; i < Convert.ToInt16(txtLimite.Text); i++)
            {
                //dgvDatos.Rows.Add(fn.ToString());
                if (fn == 1)
                {
                    dgvDatos.Rows.Add(fn.ToString());
                }
                else if (fn > Convert.ToInt32(txtLimite.Text))
                {
                    break;
                }
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
                if (fn <= Convert.ToInt32(txtLimite.Text))
                {
                    dgvDatos.Rows.Add(fn.ToString());
                }
            }
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
