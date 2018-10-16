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
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
}

        private void Ejemplo1()
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

        private void dgvCuadrado_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCuadrado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!RegularExpressions.NumerosEnteros(dgvCuadrado.CurrentRow.Cells[e.ColumnIndex].Value.ToString()))
            {
                dgvCuadrado.CurrentRow.Cells[e.ColumnIndex].Selected = true;
                dgvCuadrado.BeginEdit(true);
                dgvCuadrado.CurrentRow.Cells[e.ColumnIndex].Value = "";
                //MessageBox.Show("caca");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            SumarRenglones();
            SumarColumnas();
        }
    }
}
