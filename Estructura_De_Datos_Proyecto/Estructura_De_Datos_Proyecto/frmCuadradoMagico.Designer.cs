namespace Estructura_De_Datos_Proyecto
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
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCuadrado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnEjemplo2 = new System.Windows.Forms.Button();
            this.pbxEjemplo = new System.Windows.Forms.PictureBox();
            this.btnEjemplo1 = new System.Windows.Forms.Button();
            this.dgvCuadrado = new System.Windows.Forms.DataGridView();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjemplo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadrado)).BeginInit();
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
            this.pnlTitulo.Size = new System.Drawing.Size(753, 36);
            this.pnlTitulo.TabIndex = 0;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pbxCerrar.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(717, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(36, 36);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
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
            this.pnlContenido.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenido.Controls.Add(this.label2);
            this.pnlContenido.Controls.Add(this.label1);
            this.pnlContenido.Controls.Add(this.lblCuadrado);
            this.pnlContenido.Controls.Add(this.btnLimpiar);
            this.pnlContenido.Controls.Add(this.btnCalcular);
            this.pnlContenido.Controls.Add(this.btnEjemplo2);
            this.pnlContenido.Controls.Add(this.pbxEjemplo);
            this.pnlContenido.Controls.Add(this.btnEjemplo1);
            this.pnlContenido.Controls.Add(this.dgvCuadrado);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContenido.Location = new System.Drawing.Point(0, 36);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(753, 376);
            this.pnlContenido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(517, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(517, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // lblCuadrado
            // 
            this.lblCuadrado.AutoSize = true;
            this.lblCuadrado.BackColor = System.Drawing.Color.Transparent;
            this.lblCuadrado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadrado.ForeColor = System.Drawing.Color.White;
            this.lblCuadrado.Location = new System.Drawing.Point(557, 225);
            this.lblCuadrado.Name = "lblCuadrado";
            this.lblCuadrado.Size = new System.Drawing.Size(146, 18);
            this.lblCuadrado.TabIndex = 7;
            this.lblCuadrado.Text = "Cuadrado mágico";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(521, 324);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 37);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(11, 324);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 37);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnEjemplo2
            // 
            this.btnEjemplo2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEjemplo2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEjemplo2.FlatAppearance.BorderSize = 0;
            this.btnEjemplo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplo2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo2.Location = new System.Drawing.Point(350, 324);
            this.btnEjemplo2.Name = "btnEjemplo2";
            this.btnEjemplo2.Size = new System.Drawing.Size(155, 37);
            this.btnEjemplo2.TabIndex = 4;
            this.btnEjemplo2.Text = "Ejemplo 2";
            this.btnEjemplo2.UseVisualStyleBackColor = false;
            // 
            // pbxEjemplo
            // 
            this.pbxEjemplo.BackColor = System.Drawing.Color.Transparent;
            this.pbxEjemplo.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.índice;
            this.pbxEjemplo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxEjemplo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxEjemplo.Location = new System.Drawing.Point(511, 4);
            this.pbxEjemplo.Name = "pbxEjemplo";
            this.pbxEjemplo.Size = new System.Drawing.Size(237, 218);
            this.pbxEjemplo.TabIndex = 3;
            this.pbxEjemplo.TabStop = false;
            // 
            // btnEjemplo1
            // 
            this.btnEjemplo1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEjemplo1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEjemplo1.FlatAppearance.BorderSize = 0;
            this.btnEjemplo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplo1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo1.Location = new System.Drawing.Point(181, 324);
            this.btnEjemplo1.Name = "btnEjemplo1";
            this.btnEjemplo1.Size = new System.Drawing.Size(155, 37);
            this.btnEjemplo1.TabIndex = 2;
            this.btnEjemplo1.Text = "Ejemplo 1";
            this.btnEjemplo1.UseVisualStyleBackColor = false;
            this.btnEjemplo1.Click += new System.EventHandler(this.btnEjemplo1_Click);
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
            this.dgvCuadrado.Location = new System.Drawing.Point(6, 5);
            this.dgvCuadrado.MultiSelect = false;
            this.dgvCuadrado.Name = "dgvCuadrado";
            this.dgvCuadrado.RowHeadersWidth = 60;
            this.dgvCuadrado.Size = new System.Drawing.Size(499, 301);
            this.dgvCuadrado.TabIndex = 0;
            this.dgvCuadrado.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuadrado_CellEndEdit);
            this.dgvCuadrado.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuadrado_CellLeave);
            // 
            // frmCuadradoMagico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 412);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCuadradoMagico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCuadradoMagico_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjemplo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.DataGridView dgvCuadrado;
        private System.Windows.Forms.Button btnEjemplo1;
        private System.Windows.Forms.PictureBox pbxEjemplo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnEjemplo2;
        private System.Windows.Forms.Label lblCuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}