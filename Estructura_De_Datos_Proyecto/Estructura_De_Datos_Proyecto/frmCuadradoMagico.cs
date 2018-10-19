using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Estructura_De_Datos_Proyecto
{
    public partial class frmCuadradoMagico : Form
    {
        public frmCuadradoMagico()
        {
            InitializeComponent();
        }

        public frmCuadradoMagico(int matriz)
        {
            InitializeComponent();
            this.matriz = matriz;
        }

        private int matriz;
        private int col;
        private int ren;

        private void Limpiar()
        {
            for (int i = 0; i < dgvCuadrado.Rows.Count; i++)
            {
                for (int j = 0; j < dgvCuadrado.ColumnCount; j++)
                {
                    dgvCuadrado.Rows[i].Cells[j].Value = "";
                }
            }
        }

        private void Matriz()
        {
            try
            {
                col = matriz;
                ren = matriz;
                dgvCuadrado.Columns.Clear();
                for (int i = 0; i < col; i++)
                {
                    dgvCuadrado.Columns.Add("Column" + i, "Columna " + i);
                }
                for (int i = 0; i < ren; i++)
                {
                    dgvCuadrado.Rows.Add();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void SumarRenglones()
        {
            try
            {
                int suma = 0;
                for (int i = 0; i < ren; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        suma = suma + Convert.ToInt32(dgvCuadrado.Rows[i].Cells[j].Value.ToString());
                    }
                    dgvCuadrado.Rows[i].HeaderCell.Value = suma.ToString();
                    suma = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al sumar los renglones: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void SumarColumnas()
        {
            try
            {
                int suma = 0;
                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < ren; j++)
                    {
                        suma = suma + Convert.ToInt32(dgvCuadrado.Rows[j].Cells[i].Value.ToString());
                    }
                    dgvCuadrado.Columns[i].HeaderText = suma.ToString();
                    suma = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al sumar las columnas: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
}

        private void SumarDiagonales()
        {
            int sumaD1 = 0;
            int sumaD2 = 0;
            try
            {
                for (int i = 0, j=dgvCuadrado.RowCount - 1; i < dgvCuadrado.Rows.Count; i++, j--)
                {
                    sumaD1 = sumaD1 + Convert.ToInt32(dgvCuadrado.Rows[i].Cells[i].Value.ToString());
                    sumaD2 = sumaD2 + Convert.ToInt32(dgvCuadrado.Rows[i].Cells[j].Value.ToString());
                }
                label1.Text = "Diagonal 1: " + sumaD1.ToString();
                label2.Text = "Diagonal 2: " + sumaD2.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al sumar las diagonales: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Validar()
        {

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCuadradoMagico_Load(object sender, EventArgs e)
        {
            Matriz();   
        }

        private void btnEjemplo1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCuadrado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!RegularExpressions.NumerosEnteros(dgvCuadrado.CurrentRow.Cells[e.ColumnIndex].Value.ToString()))
                {
                    dgvCuadrado.CurrentRow.Cells[e.ColumnIndex].Value = "";
                    //dgvCuadrado.BeginEdit(true);
                    dgvCuadrado.CurrentCell = dgvCuadrado.Rows[0].Cells[0];
                    dgvCuadrado.CurrentRow.Cells[e.ColumnIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            SumarRenglones();
            SumarColumnas();
            SumarDiagonales();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvCuadrado_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!RegularExpressions.NumerosEnteros(dgvCuadrado.CurrentRow.Cells[e.ColumnIndex].Value.ToString()))
                {
                    dgvCuadrado.CurrentRow.Cells[e.ColumnIndex].Value = "";
                    //dgvCuadrado.BeginEdit(true);
                    dgvCuadrado.CurrentCell = dgvCuadrado.Rows[0].Cells[0];
                    dgvCuadrado.CurrentRow.Cells[e.ColumnIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
