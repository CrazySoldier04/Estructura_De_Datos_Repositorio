using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TronarProgramas
{
    public partial class frmTimeBomb : Form
    {
        public frmTimeBomb()
        {
            InitializeComponent();
        }

        private void frmTimeBomb_Load(object sender, EventArgs e)
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;

                MessageBox.Show(hour + " " + minute);
            if (hour >= 15 && minute > 40)
            {
                this.Controls.Cast<Control>().ToList().ForEach(x => x.Enabled = false);
            }
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
