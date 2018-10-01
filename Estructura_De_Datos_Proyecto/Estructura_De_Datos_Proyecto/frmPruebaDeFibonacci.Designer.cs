namespace Estructura_De_Datos_Proyecto
{
    partial class frmPruebaDeFibonacci
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
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblPruebaFibonacci = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.pnlContenido.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlTitulo.Controls.Add(this.pbxCerrar);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(708, 35);
            this.pnlTitulo.TabIndex = 0;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(671, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(37, 35);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(268, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Prueba de Fibonacci";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlContenido.Controls.Add(this.pnlInfo);
            this.pnlContenido.Controls.Add(this.lblResultado);
            this.pnlContenido.Controls.Add(this.txtNumero);
            this.pnlContenido.Controls.Add(this.dgvDatos);
            this.pnlContenido.Controls.Add(this.btnBuscar);
            this.pnlContenido.Controls.Add(this.lblPosicion);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 35);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(708, 377);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.lblPruebaFibonacci);
            this.pnlInfo.Controls.Add(this.pbxFoto);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(295, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(413, 377);
            this.pnlInfo.TabIndex = 5;
            // 
            // pbxFoto
            // 
            this.pbxFoto.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.secuencia_de_fibonacci_2;
            this.pbxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxFoto.Location = new System.Drawing.Point(7, 50);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(398, 314);
            this.pbxFoto.TabIndex = 0;
            this.pbxFoto.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Location = new System.Drawing.Point(12, 252);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(57, 21);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "label1";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(55, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 27);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 66);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(277, 150);
            this.dgvDatos.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(177, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 27);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BackColor = System.Drawing.Color.Transparent;
            this.lblPosicion.Location = new System.Drawing.Point(12, 24);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(37, 21);
            this.lblPosicion.TabIndex = 0;
            this.lblPosicion.Text = "K = ";
            // 
            // lblPruebaFibonacci
            // 
            this.lblPruebaFibonacci.AutoSize = true;
            this.lblPruebaFibonacci.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPruebaFibonacci.Location = new System.Drawing.Point(120, 21);
            this.lblPruebaFibonacci.Name = "lblPruebaFibonacci";
            this.lblPruebaFibonacci.Size = new System.Drawing.Size(172, 19);
            this.lblPruebaFibonacci.TabIndex = 1;
            this.lblPruebaFibonacci.Text = "Prueba de Fibonacci";
            // 
            // frmPruebaDeFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 412);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPruebaDeFibonacci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPruebaDeFibonacci_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Label lblPruebaFibonacci;
    }
}