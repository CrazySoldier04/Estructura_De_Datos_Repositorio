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
    public partial class frmSeleccionarDatos : Form
    {
        public frmSeleccionarDatos()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int dato = 0;
            dato = rbtnInt.Checked == true ? 1 : dato;
            dato = rbtnDouble.Checked == true ? 2 : dato;
            dato = rbtnDecimal.Checked == true ? 3 : dato;
            dato = rbtnChar.Checked == true ? 4 : dato;
            dato = rbtnString.Checked == true ? 5 : dato;
            dato = rbtnAdt1.Checked == true ? 6 : dato;
            dato = rbtnAdt2.Checked == true ? 7 : dato;
            new frmTipoDeDato(dato).ShowDialog();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
