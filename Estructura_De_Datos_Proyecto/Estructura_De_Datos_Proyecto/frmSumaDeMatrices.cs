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

        private void GenerarRenglonesYColumnas()
        {
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

        private int col = 0;
        private int ren = 0;

        private void frmSumaDeMatrices_Load(object sender, EventArgs e)
        {
            GenerarRenglonesYColumnas();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
