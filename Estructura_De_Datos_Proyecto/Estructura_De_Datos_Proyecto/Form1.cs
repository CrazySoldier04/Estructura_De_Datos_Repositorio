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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void fractalDeHilbertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFractalDeHilbert ventana = new frmFractalDeHilbert();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void pruebaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPruebaDeFibonacci ventana = new frmPruebaDeFibonacci();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void búsquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBinaria ventana = new frmBusquedaBinaria();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void mCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMCD ventana = new frmMCD();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFibonacci ventana = new frmFibonacci();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void practicaIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeleccionarDatos ventana = new frmSeleccionarDatos();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void cuadradoMágicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatrizCuadradoMagico ventana = new frmMatrizCuadradoMagico();
            Hide();
            ventana.ShowDialog();
            Show();
        }
    }
}
