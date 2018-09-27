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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        public static String nombre = "";

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Favor de ingresar su nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                nombre = txtNombre.Text;
                frmMemorama ventana = new frmMemorama();
                //this.Close();
                ventana.ShowDialog();
            }
        }
    }
}