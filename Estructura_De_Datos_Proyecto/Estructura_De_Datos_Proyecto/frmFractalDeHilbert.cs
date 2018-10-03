using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Estructura_De_Datos_Proyecto
{
    public partial class frmFractalDeHilbert : Form
    {
        public frmFractalDeHilbert()
        {
            InitializeComponent();
        }

        private bool DoRefresh;
        private float LastX, LastY;
        private Bitmap HilbertImage;
        String ext;
        ImageFormat formato;
        private void btnGo_Click(object sender, EventArgs e)
        {
            int depth = int.Parse(txtDepth.Text);
            if (depth > 8)
            {
                if (MessageBox.Show("A large depth may take a long time to draw (and will be mostly black anyway). Do you want to continue?",
                    "Continue?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // See if we should refresh as we draw.
            DoRefresh = chkbxRefresh.Checked;

            // Get the parameters.
            float total_length, start_x, start_y, start_length;

            // See how big we can make the curve.
            if (pictureBox1.ClientSize.Height < pictureBox1.ClientSize.Width)
            {
                total_length = (float)(0.9 * pictureBox1.ClientSize.Height);
            }
            else
            {
                total_length = (float)(0.9 * pictureBox1.ClientSize.Width);
            }

            start_x = (pictureBox1.ClientSize.Width - total_length) / 2;
            start_y = (pictureBox1.ClientSize.Height - total_length) / 2;

            // Compute the side length for this level.
            start_length = (float)(total_length / (Math.Pow(2, depth) - 1));

            HilbertImage = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pictureBox1.Image = HilbertImage;

            using (Graphics gr = Graphics.FromImage(HilbertImage))
            {
                // Draw the curve.
                gr.Clear(pictureBox1.BackColor);
                LastX = (int)start_x;
                LastY = (int)start_y;
                Hilbert(gr, depth, start_length, 0);
            }

            // Display the result.
            pictureBox1.Refresh();
            this.Cursor = Cursors.Default;
        }

        // Draw a Hilbert curve.
        private void Hilbert(Graphics gr, int depth, float dx, float dy)
        {
            if (depth > 1) Hilbert(gr, depth - 1, dy, dx);
            DrawRelative(gr, dx, dy);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, dy, dx);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, -dx, -dy);
            if (depth > 1) Hilbert(gr, depth - 1, -dy, -dx);

            if (DoRefresh) pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpeg";
            saveFileDialog1.ShowDialog();

            if(saveFileDialog1.FileName != "")
            {
                Image imagen = pictureBox1.Image;
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".png":
                        formato = ImageFormat.Png;
                        break;

                    case ".bmp":
                        formato = ImageFormat.Bmp;
                        break;

                    case ".jpeg":
                        formato = ImageFormat.Jpeg;
                        break;
                }
                imagen.Save(fs, formato);
            }
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Draw the line (LastX, LastY)-(LastX + dx, LastY + dy) and
        // update LastX = LastX + dx, LastY = LastY + dy.
        private void DrawRelative(Graphics gr, float dx, float dy)
        {
            gr.DrawLine(Pens.Black, LastX, LastY, LastX + dx, LastY + dy);
            LastX = LastX + dx;
            LastY = LastY + dy;
        }
    }
}
