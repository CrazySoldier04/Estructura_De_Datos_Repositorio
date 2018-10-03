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

        private void Generar()
        {
            dgvDatos.Rows.Clear();
            int f0 = 0;
            int f1 = 1;
            int fn = 0;
            dgvDatos.Rows.Add("0");

            if (4200 == 1)
            {
                dgvDatos.Rows.Add("1");
            }

            for (int i = 0; i <= 4200; i++)
            {
                //dgvDatos.Rows.Add(fn.ToString());
                if (fn == 1)
                {
                    dgvDatos.Rows.Add(fn.ToString());
                }
                else if (fn > 4200)
                {
                    break;
                }
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
                if (fn <= 4200)
                {
                    dgvDatos.Rows.Add(fn.ToString());
                }
            }
            SetRowsNumber();
        }

        private void SetRowsNumber()
        {
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private long Prueba(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return Prueba(num - 1) + Prueba(num - 2);
            }
        }

        private void Buscar()
        {
            if (Convert.ToInt32(txtNumero.Text) == 1)
            {
                lblResultado.Text = "El número 1 de Fibonacci es 0";
            }
            else if (Convert.ToInt32(txtNumero.Text) == 2)
            {
                lblResultado.Text = "El número 2 de Fibonacci es 1";
            }
            else
            {
                lblResultado.Text = "El número " + txtNumero.Text + " de Fibonacci es " + Prueba(Convert.ToInt32(txtNumero.Text) - 2);
            }
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
            Generar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text == "")
            {
                error.SetError(txtNumero, "El campo está vacío");
                txtNumero.Focus();
            }
            else if(Convert.ToInt32(txtNumero.Text) > 20)
            {
                error.SetError(txtNumero, "El valor tiene que estar entre 1 y 20");
                txtNumero.Focus();
            }
            else
            {
                error.SetError(txtNumero, "");
                Buscar();
            }
        }
    }
}
