﻿namespace Estructura_De_Datos_Proyecto
{
    partial class frmCuadradoMagico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.dgvCuadrado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEjemplo1 = new System.Windows.Forms.Button();
            this.pbxEjemplo = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjemplo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlTitulo.Controls.Add(this.pbxCerrar);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(935, 36);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cuadrado mágico";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenido.Controls.Add(this.pbxEjemplo);
            this.pnlContenido.Controls.Add(this.btnEjemplo1);
            this.pnlContenido.Controls.Add(this.label2);
            this.pnlContenido.Controls.Add(this.dgvCuadrado);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 36);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(935, 393);
            this.pnlContenido.TabIndex = 1;
            // 
            // dgvCuadrado
            // 
            this.dgvCuadrado.AllowUserToAddRows = false;
            this.dgvCuadrado.AllowUserToDeleteRows = false;
            this.dgvCuadrado.AllowUserToResizeColumns = false;
            this.dgvCuadrado.AllowUserToResizeRows = false;
            this.dgvCuadrado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCuadrado.BackgroundColor = System.Drawing.Color.White;
            this.dgvCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuadrado.GridColor = System.Drawing.Color.Black;
            this.dgvCuadrado.Location = new System.Drawing.Point(110, 15);
            this.dgvCuadrado.Name = "dgvCuadrado";
            this.dgvCuadrado.RowHeadersWidth = 50;
            this.dgvCuadrado.Size = new System.Drawing.Size(363, 283);
            this.dgvCuadrado.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btnEjemplo1
            // 
            this.btnEjemplo1.Location = new System.Drawing.Point(110, 304);
            this.btnEjemplo1.Name = "btnEjemplo1";
            this.btnEjemplo1.Size = new System.Drawing.Size(155, 58);
            this.btnEjemplo1.TabIndex = 2;
            this.btnEjemplo1.Text = "Ejemplo 1";
            this.btnEjemplo1.UseVisualStyleBackColor = true;
            this.btnEjemplo1.Click += new System.EventHandler(this.btnEjemplo1_Click);
            // 
            // pbxEjemplo
            // 
            this.pbxEjemplo.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.índice;
            this.pbxEjemplo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxEjemplo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxEjemplo.Location = new System.Drawing.Point(683, 15);
            this.pbxEjemplo.Name = "pbxEjemplo";
            this.pbxEjemplo.Size = new System.Drawing.Size(239, 223);
            this.pbxEjemplo.TabIndex = 3;
            this.pbxEjemplo.TabStop = false;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pbxCerrar.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(899, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(36, 36);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // frmCuadradoMagico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 429);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmCuadradoMagico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCuadradoMagico_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjemplo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.DataGridView dgvCuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEjemplo1;
        private System.Windows.Forms.PictureBox pbxEjemplo;
    }
}