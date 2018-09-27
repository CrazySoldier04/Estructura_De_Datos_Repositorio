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
    public partial class frmTipoDeDato : Form
    {
        private int tipo = 0;
        private int col = 0;
        private int ren = 0;

        public frmTipoDeDato()
        {
            InitializeComponent();
        }

        public frmTipoDeDato(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }
    }
}
