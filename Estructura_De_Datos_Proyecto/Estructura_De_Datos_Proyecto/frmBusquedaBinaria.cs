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
    public partial class frmBusquedaBinaria : Form
    {
        public frmBusquedaBinaria()
        {
            InitializeComponent();
        }

        int[] valores;

        private void NumerosGrid(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        public static object Busqueda(int[] num, int num2)
        {
            int minimo = 0;
            int maximo = num.Length - 1;

            while (minimo <= maximo)
            {
                int mitad = (minimo + maximo) / 2;
                if (num2 == num[mitad])
                {
                    ++mitad;
                    return "Está en la posición " + mitad;
                }
                else if (num2 < num[mitad])
                {
                    maximo = mitad - 1;
                }
                else
                {
                    minimo = mitad + 1;
                }
            }
            return "No está";
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Rows.Clear();
            Random r = new Random();
            valores = new int[Convert.ToInt32(txtNumero.Text)];

            for (int i = 0; i < Convert.ToInt32(txtNumero.Text); i++)
            {
                valores[i] = r.Next(0, Convert.ToInt32(txtNumero.Text));
                //dgvBusqueda.Rows.Add(r.Next(0, Convert.ToInt32(txtLimite.Text)).ToString());
            }
            dgvBusqueda.DataSource = valores.Select(x => new { Números = x }).ToList();
            NumerosGrid(dgvBusqueda);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtLimite.Clear();
        }
    }
}
