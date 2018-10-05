namespace Estructura_De_Datos_Proyecto
{
    partial class frmIngresarMatriz
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
            this.lblColumnas = new System.Windows.Forms.Label();
            this.lblRenglones = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtRenglones = new System.Windows.Forms.TextBox();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.pnlContenido.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(304, 31);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(125, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(54, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Matriz";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.LightGray;
            this.pnlContenido.Controls.Add(this.btnGenerarMatriz);
            this.pnlContenido.Controls.Add(this.txtRenglones);
            this.pnlContenido.Controls.Add(this.txtColumnas);
            this.pnlContenido.Controls.Add(this.lblRenglones);
            this.pnlContenido.Controls.Add(this.lblColumnas);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 31);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(304, 198);
            this.pnlContenido.TabIndex = 1;
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.BackColor = System.Drawing.Color.Transparent;
            this.lblColumnas.Location = new System.Drawing.Point(12, 28);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(96, 21);
            this.lblColumnas.TabIndex = 0;
            this.lblColumnas.Text = "Columnas: ";
            // 
            // lblRenglones
            // 
            this.lblRenglones.AutoSize = true;
            this.lblRenglones.BackColor = System.Drawing.Color.Transparent;
            this.lblRenglones.Location = new System.Drawing.Point(12, 106);
            this.lblRenglones.Name = "lblRenglones";
            this.lblRenglones.Size = new System.Drawing.Size(98, 21);
            this.lblRenglones.TabIndex = 1;
            this.lblRenglones.Text = "Renglones: ";
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(116, 25);
            this.txtColumnas.MaxLength = 2;
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(100, 27);
            this.txtColumnas.TabIndex = 2;
            this.txtColumnas.TextChanged += new System.EventHandler(this.txtColumnas_TextChanged);
            // 
            // txtRenglones
            // 
            this.txtRenglones.Location = new System.Drawing.Point(116, 103);
            this.txtRenglones.MaxLength = 2;
            this.txtRenglones.Name = "txtRenglones";
            this.txtRenglones.Size = new System.Drawing.Size(100, 27);
            this.txtRenglones.TabIndex = 3;
            this.txtRenglones.TextChanged += new System.EventHandler(this.txtRenglones_TextChanged);
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.BackColor = System.Drawing.Color.White;
            this.btnGenerarMatriz.FlatAppearance.BorderSize = 0;
            this.btnGenerarMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarMatriz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarMatriz.Location = new System.Drawing.Point(20, 156);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(265, 30);
            this.btnGenerarMatriz.TabIndex = 4;
            this.btnGenerarMatriz.Text = "Generar Matriz";
            this.btnGenerarMatriz.UseVisualStyleBackColor = false;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(265, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(39, 31);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            // 
            // frmIngresarMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(304, 229);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmIngresarMatriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.TextBox txtRenglones;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.Label lblRenglones;
        private System.Windows.Forms.Label lblColumnas;
    }
}