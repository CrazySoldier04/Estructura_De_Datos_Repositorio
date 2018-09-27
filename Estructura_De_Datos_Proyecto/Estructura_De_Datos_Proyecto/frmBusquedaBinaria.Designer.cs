namespace Estructura_De_Datos_Proyecto
{
    partial class frmBusquedaBinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaBinaria));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlTrabajo = new System.Windows.Forms.Panel();
            this.lblElementos = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.pbxBusqueda = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBusqueda)).BeginInit();
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
            this.pnlTitulo.Size = new System.Drawing.Size(917, 31);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(385, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Búsqueda binaria";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlContenido.Controls.Add(this.pnlTrabajo);
            this.pnlContenido.Controls.Add(this.pnlInfo);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 31);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(917, 462);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlTrabajo
            // 
            this.pnlTrabajo.Controls.Add(this.btnBuscar);
            this.pnlTrabajo.Controls.Add(this.txtBuscar);
            this.pnlTrabajo.Controls.Add(this.lblBuscar);
            this.pnlTrabajo.Controls.Add(this.btnLimpiar);
            this.pnlTrabajo.Controls.Add(this.btnRandom);
            this.pnlTrabajo.Controls.Add(this.txtLimite);
            this.pnlTrabajo.Controls.Add(this.lblLimite);
            this.pnlTrabajo.Controls.Add(this.txtNumero);
            this.pnlTrabajo.Controls.Add(this.lblElementos);
            this.pnlTrabajo.Controls.Add(this.dgvBusqueda);
            this.pnlTrabajo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTrabajo.Location = new System.Drawing.Point(0, 0);
            this.pnlTrabajo.Name = "pnlTrabajo";
            this.pnlTrabajo.Size = new System.Drawing.Size(484, 462);
            this.pnlTrabajo.TabIndex = 1;
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.BackColor = System.Drawing.Color.Transparent;
            this.lblElementos.Location = new System.Drawing.Point(12, 13);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(190, 21);
            this.lblElementos.TabIndex = 1;
            this.lblElementos.Text = "Número de elementos: ";
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvBusqueda.Location = new System.Drawing.Point(12, 204);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.RowHeadersVisible = false;
            this.dgvBusqueda.Size = new System.Drawing.Size(465, 246);
            this.dgvBusqueda.TabIndex = 0;
            this.dgvBusqueda.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.txtInfo);
            this.pnlInfo.Controls.Add(this.pbxBusqueda);
            this.pnlInfo.Controls.Add(this.lblBusqueda);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(483, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(434, 462);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(152, 13);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(146, 21);
            this.lblBusqueda.TabIndex = 0;
            this.lblBusqueda.Text = "Búsqueda binaria";
            // 
            // pbxBusqueda
            // 
            this.pbxBusqueda.Image = global::Estructura_De_Datos_Proyecto.Properties.Resources.f0801;
            this.pbxBusqueda.Location = new System.Drawing.Point(10, 37);
            this.pbxBusqueda.Name = "pbxBusqueda";
            this.pbxBusqueda.Size = new System.Drawing.Size(415, 233);
            this.pbxBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBusqueda.TabIndex = 1;
            this.pbxBusqueda.TabStop = false;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(883, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(34, 31);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.White;
            this.txtInfo.Location = new System.Drawing.Point(7, 276);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(415, 174);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(208, 10);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 27);
            this.txtNumero.TabIndex = 2;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.BackColor = System.Drawing.Color.Transparent;
            this.lblLimite.Location = new System.Drawing.Point(12, 69);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(63, 21);
            this.lblLimite.TabIndex = 3;
            this.lblLimite.Text = "Límite: ";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(81, 66);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 27);
            this.txtLimite.TabIndex = 4;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(216, 66);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(92, 27);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(338, 66);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 27);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Location = new System.Drawing.Point(18, 148);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(69, 21);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(93, 145);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 27);
            this.txtBuscar.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(216, 145);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 27);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmBusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 493);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBusquedaBinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlTrabajo.ResumeLayout(false);
            this.pnlTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlTrabajo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.PictureBox pbxBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnBuscar;
    }
}