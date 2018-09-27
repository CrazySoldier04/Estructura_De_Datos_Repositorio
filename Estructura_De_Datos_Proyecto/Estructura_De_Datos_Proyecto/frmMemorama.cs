using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Estructura_De_Datos_Proyecto
{
    public partial class frmMemorama : Form
    {
        public frmMemorama()
        {
            InitializeComponent();
        }

        private int[] i = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        private bool before = false;
        private int indiceTemp = 0;
        private PictureBox picTemp = null;
        private int intentos = 0;
        private String nombre = frmDatos.nombre;
        private int nivel = 0;
        private int tiempo;
        private int contador = 0;
        int horas = 0;
        int minutos = 0;

        private void Responsive()
        {
            lblIntentos.Location = new Point(0, pnlTitulo.Height / 2 - lblIntentos.Height / 2);
            lblTitulo.Location = new Point(pnlTitulo.Width / 2 - lblTitulo.Width / 2, pnlTitulo.Height / 2 - lblTitulo.Height / 2);
            lblTimer2.Location = new Point(Convert.ToInt32(pnlTitulo.Width * 0.94), pnlTitulo.Height / 2 - lblTimer2.Height / 2);
            pictureBox0.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox0.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox0.Location = new Point(0, 0);
            pictureBox1.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox1.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox1.Location = new Point(pictureBox1.Width, 0);
            pictureBox2.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox2.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox2.Location = new Point(pictureBox1.Width * 2, 0);
            pictureBox3.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox3.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox3.Location = new Point(pictureBox1.Width * 3, 0);
            pictureBox4.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox4.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox4.Location = new Point(pictureBox1.Width * 4, 0);
            pictureBox5.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox5.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox5.Location = new Point(pictureBox1.Width * 5, 0);
            pictureBox6.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox6.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox6.Location = new Point(pictureBox1.Width * 6, 0);
            pictureBox7.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox7.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox7.Location = new Point(pictureBox1.Width * 7, 0);
            pictureBox8.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox8.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox8.Location = new Point(0, pictureBox0.Height);
            pictureBox9.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox9.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox9.Location = new Point(pictureBox1.Width, pictureBox1.Height);
            pictureBox10.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox10.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox10.Location = new Point(pictureBox1.Width * 2, pictureBox1.Height);
            pictureBox11.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox11.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox11.Location = new Point(pictureBox1.Width * 3, pictureBox1.Height);
            pictureBox12.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox12.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox12.Location = new Point(pictureBox1.Width * 4, pictureBox1.Height);
            pictureBox13.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox13.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox13.Location = new Point(pictureBox1.Width * 5, pictureBox1.Height);
            pictureBox14.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox14.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox14.Location = new Point(pictureBox1.Width * 6, pictureBox1.Height);
            pictureBox15.Width = Convert.ToInt32(pnlContenido.Width * 0.125);
            pictureBox15.Height = Convert.ToInt32(pnlContenido.Height * 0.50);
            pictureBox15.Location = new Point(pictureBox1.Width * 7, pictureBox1.Height);
        }

        private void Restart()
        {
            intentos = 0;
            tiempo = 0;
            timer1.Start();
            pictureBox0.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox1.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox2.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox3.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox4.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox5.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox6.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox7.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox8.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox9.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox10.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox11.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox12.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox13.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox14.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox15.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
            pictureBox0.Enabled = true;
            pictureBox0.Visible = true;
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Enabled = true;
            pictureBox2.Visible = true;
            pictureBox3.Enabled = true;
            pictureBox3.Visible = true;
            pictureBox4.Enabled = true;
            pictureBox4.Visible = true;
            pictureBox5.Enabled = true;
            pictureBox5.Visible = true;
            pictureBox6.Enabled = true;
            pictureBox6.Visible = true;
            pictureBox7.Enabled = true;
            pictureBox7.Visible = true;
            pictureBox8.Enabled = true;
            pictureBox8.Visible = true;
            pictureBox9.Enabled = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox10.Enabled = true;
            pictureBox11.Visible = true;
            pictureBox11.Enabled = true;
            pictureBox12.Visible = true;
            pictureBox12.Enabled = true;
            pictureBox13.Visible = true;
            pictureBox13.Enabled = true;
            pictureBox14.Visible = true;
            pictureBox14.Enabled = true;
            pictureBox15.Visible = true;
            pictureBox15.Enabled = true;
        }

        private void Flip(PictureBox carta, int num)
        {
            //MessageBox.Show(i[num].ToString());
            switch (i[num])
            {
                case 0:
                    carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources._0;
                    break;
                case 1:
                    carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources._1;
                    break;
                case 2:
                    carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources._2;
                    break;
                case 3:
                    carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources._3;
                    break;
                case 4:
                    carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources._4;
                    break;
                case 5:
                    carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources._5;
                    break;
                case 6:
                    carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources._6;
                    break;
                case 7:
                    carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources._7;
                    break;
            }
            carta.Update();
            if(!before)
            {
                before = true;
                indiceTemp = num;
                picTemp = carta;
            }
            else
            {
                if (i[num] == i[indiceTemp])
                {
                    //MessageBox.Show("Si soy ama y que wey");
                    carta.Enabled = false;
                    carta.Visible = false;
                    picTemp.Enabled = false;
                    picTemp.Visible = false;
                    contador = contador + 1;

                    if (contador == 8)
                    {
                        timer1.Stop();
                        if (intentos == 0)
                        {
                            MessageBox.Show("La perfección si existe y se llama: " + nombre + ", resolviste el memorama en el primer intento en un tiempo de " + lblTimer2.Text + ". ¡FELICIDADES!", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else if (intentos > 0 && intentos <= 10)
                        {
                            MessageBox.Show("Mi querido " + nombre + ", tus niveles de inteligencia se pueden comparar con los de un frijolito; resolviste el memorama en " + intentos + " intentos en un tiempo de " + lblTimer2.Text + ".", "COMPLETADO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show("Si Hittler viviera le gustaría mucho hacerte jabón mi querido " + nombre + ", resolviste el cronograma en " + intentos + " intentos en un tiempo de " + lblTimer2.Text + ", hazle un favor al mundo y mátate", "COMPLETADO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("Eran mentiras ama");
                    Thread.Sleep(1000);
                    carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
                    picTemp.Image = carta.Image = Estructura_De_Datos_Proyecto.Properties.Resources.reverso;
                    picTemp.Enabled = true;
                    intentos = intentos + 1;
                    lblIntentos.Text = "Número de intentos: " + intentos;
                    //MessageBox.Show(intentos.ToString());
                }
                before = false;
            }
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMemorama_Load(object sender, EventArgs e)
        {
            Responsive();
            lblTimer.Visible = true;
            i = i.OrderBy(s => Guid.NewGuid()).ToArray();
            //MessageBox.Show(String.Join(" - ", i));
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Restart();
            frmMemorama_Load(sender, e);
        }

        private void pictureBox0_Click(object sender, EventArgs e)
        {
            Flip(pictureBox0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Flip(pictureBox1, 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Flip(pictureBox2, 2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Flip(pictureBox3, 3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Flip(pictureBox4, 4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Flip(pictureBox5, 5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Flip(pictureBox6, 6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Flip(pictureBox7, 7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Flip(pictureBox8, 8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Flip(pictureBox9, 9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Flip(pictureBox10, 10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Flip(pictureBox11, 11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Flip(pictureBox12, 12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Flip(pictureBox13, 13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Flip(pictureBox14, 14);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Flip(pictureBox15, 15);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            if (tiempo.ToString() == "60")
            {
                minutos++;
                lblTimer2.Text = minutos + ":" + tiempo.ToString();
                tiempo = 0;
            }
            else
            {
                lblTimer2.Text = minutos + ":" + tiempo.ToString();
            }
        }
    }
}
