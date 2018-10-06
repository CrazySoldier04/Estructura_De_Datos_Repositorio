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
    public partial class frmSumaDeMatrices : Form
    {
        public frmSumaDeMatrices()
        {
            InitializeComponent();
        }

        public frmSumaDeMatrices(int col, int ren)
        {
            InitializeComponent();
            this.col = col;
            this.ren = ren;
        }

        private int col = 0;
        private int ren = 0;

        private void GenerarRenglonesYColumnas()
        {
            try
            {
                dgvMatriz1.Columns.Clear();
                dgvMatriz2.Columns.Clear();
                for (int i = 0; i < col; i++)
                {
                    dgvMatriz1.Columns.Add("Column" + i, "Columna " + i);
                    dgvMatriz2.Columns.Add("Column" + i, "Columna " + i);
                    dgvMatrizResultado.Columns.Add("Column " + i, "Columna " + i);
                }
                for (int i = 0; i < ren; i++)
                {
                    dgvMatriz1.Rows.Add();
                    dgvMatriz2.Rows.Add();
                    dgvMatrizResultado.Rows.Add();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Random()
        {
            try
            {
                int ran = 0;
                Random random = new Random();
                if (Convert.ToInt32(txtLimiteInferior.Text) > Convert.ToInt32(txtLimiteSuperior.Text))
                {
                    MessageBox.Show("El límite inferior no puede ser mayor al límite superior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    for (int i = 0; i < ren; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            ran = random.Next(Convert.ToInt32(txtLimiteInferior.Text), Convert.ToInt32(txtLimiteSuperior.Text));
                            dgvMatriz1.Rows[i].Cells[j].Value = ran.ToString();
                        }
                    }
                    for (int i = 0; i < ren; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            ran = random.Next(Convert.ToInt32(txtLimiteInferior.Text), Convert.ToInt32(txtLimiteSuperior.Text));
                            dgvMatriz2.Rows[i].Cells[j].Value = ran.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void SumarMatrices()
        {
            //int num = 0;
            for (int i = 0; i < dgvMatriz1.ColumnCount; i++)
            {
                for (int j = 0; j < dgvMatriz1.Rows.Count; j++)
                {
                    dgvMatrizResultado.Rows[j].Cells[i].Value = (Convert.ToInt32(dgvMatriz1.Rows[j].Cells[i].Value.ToString()) + Convert.ToInt32(dgvMatriz2.Rows[j].Cells[i].Value.ToString()));
                }
            }
        }

        private void frmSumaDeMatrices_Load(object sender, EventArgs e)
        {
            GenerarRenglonesYColumnas();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random();
        }

        private void txtLimiteInferior_TextChanged(object sender, EventArgs e)
        {
            if (!RegularExpressions.NumerosReales(txtLimiteInferior.Text))
            {
                txtLimiteInferior.Clear();
                txtLimiteInferior.Focus();
            }
        }

        private void txtLimiteSuperior_TextChanged(object sender, EventArgs e)
        {
            if (!RegularExpressions.NumerosEnteros(txtLimiteSuperior.Text))
            {
                txtLimiteSuperior.Clear();
                txtLimiteSuperior.Focus();
            }
        }

        private void dgvMatriz2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!RegularExpressions.NumerosEnteros(dgvMatriz1.CurrentRow.Cells[e.RowIndex].Value.ToString()))
            {
                MessageBox.Show("Mierda");
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            SumarMatrices();
        }
    }
}
