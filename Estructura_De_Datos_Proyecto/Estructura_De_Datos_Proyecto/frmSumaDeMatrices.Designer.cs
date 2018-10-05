namespace Estructura_De_Datos_Proyecto
{
    partial class frmSumaDeMatrices
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
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.dgvMatriz1 = new System.Windows.Forms.DataGridView();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.dgvMatriz2 = new System.Windows.Forms.DataGridView();
            this.dgvMatrizResultado = new System.Windows.Forms.DataGridView();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizResultado)).BeginInit();
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
            this.pnlTitulo.Size = new System.Drawing.Size(852, 36);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(338, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Suma de matrices";
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(816, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(36, 36);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.Silver;
            this.pnlContenido.Controls.Add(this.dgvMatrizResultado);
            this.pnlContenido.Controls.Add(this.dgvMatriz2);
            this.pnlContenido.Controls.Add(this.btnSuma);
            this.pnlContenido.Controls.Add(this.btnRandom);
            this.pnlContenido.Controls.Add(this.dgvMatriz1);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 36);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(852, 426);
            this.pnlContenido.TabIndex = 1;
            // 
            // dgvMatriz1
            // 
            this.dgvMatriz1.AllowUserToAddRows = false;
            this.dgvMatriz1.AllowUserToDeleteRows = false;
            this.dgvMatriz1.AllowUserToResizeColumns = false;
            this.dgvMatriz1.AllowUserToResizeRows = false;
            this.dgvMatriz1.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMatriz1.Location = new System.Drawing.Point(0, 0);
            this.dgvMatriz1.Name = "dgvMatriz1";
            this.dgvMatriz1.RowHeadersVisible = false;
            this.dgvMatriz1.Size = new System.Drawing.Size(240, 426);
            this.dgvMatriz1.TabIndex = 0;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(104, 18);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(96, 34);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.Silver;
            this.btnSuma.FlatAppearance.BorderSize = 0;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(559, 196);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(50, 34);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "=";
            this.btnSuma.UseVisualStyleBackColor = false;
            // 
            // dgvMatriz2
            // 
            this.dgvMatriz2.AllowUserToAddRows = false;
            this.dgvMatriz2.AllowUserToDeleteRows = false;
            this.dgvMatriz2.AllowUserToResizeColumns = false;
            this.dgvMatriz2.AllowUserToResizeRows = false;
            this.dgvMatriz2.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz2.Location = new System.Drawing.Point(300, 0);
            this.dgvMatriz2.Name = "dgvMatriz2";
            this.dgvMatriz2.RowHeadersVisible = false;
            this.dgvMatriz2.Size = new System.Drawing.Size(258, 426);
            this.dgvMatriz2.TabIndex = 3;
            // 
            // dgvMatrizResultado
            // 
            this.dgvMatrizResultado.AllowUserToAddRows = false;
            this.dgvMatrizResultado.AllowUserToDeleteRows = false;
            this.dgvMatrizResultado.AllowUserToResizeColumns = false;
            this.dgvMatrizResultado.AllowUserToResizeRows = false;
            this.dgvMatrizResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatrizResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizResultado.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvMatrizResultado.Location = new System.Drawing.Point(612, 0);
            this.dgvMatrizResultado.Name = "dgvMatrizResultado";
            this.dgvMatrizResultado.ReadOnly = true;
            this.dgvMatrizResultado.RowHeadersVisible = false;
            this.dgvMatrizResultado.Size = new System.Drawing.Size(240, 426);
            this.dgvMatrizResultado.TabIndex = 4;
            // 
            // frmSumaDeMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 462);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmSumaDeMatrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSumaDeMatrices_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.DataGridView dgvMatriz1;
        private System.Windows.Forms.DataGridView dgvMatrizResultado;
        private System.Windows.Forms.DataGridView dgvMatriz2;
    }
}