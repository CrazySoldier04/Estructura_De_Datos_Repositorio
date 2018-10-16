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
    public partial class frmMatrizCuadradoMagico : Form
    {
        public frmMatrizCuadradoMagico()
        {
            InitializeComponent();
        }

        private int matriz;

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMatriz_TextChanged(object sender, EventArgs e)
        {
            if (!RegularExpressions.NumerosEnteros(txtMatriz.Text))
            {
                txtMatriz.Clear();
                txtMatriz.Focus();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            matriz = Convert.ToInt32(txtMatriz.Text);
            frmCuadradoMagico ventana = new frmCuadradoMagico(matriz);
            Hide();
            ventana.ShowDialog();
            Show();
        }
    }
}
