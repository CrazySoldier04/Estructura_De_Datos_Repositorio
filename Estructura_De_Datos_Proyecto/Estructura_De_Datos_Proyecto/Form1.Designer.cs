namespace Estructura_De_Datos_Proyecto
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uNIDADIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDatosAbstractosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicaIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaDeFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fractalDeHilbertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadIIArreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadIIIListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.pnlBarra.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(611, 29);
            this.pnlTitulo.TabIndex = 0;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(579, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(32, 29);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(212, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estructura de datos";
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlBarra.Controls.Add(this.menuStrip1);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 29);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(611, 26);
            this.pnlBarra.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNIDADIToolStripMenuItem,
            this.unidadIIArreglosToolStripMenuItem,
            this.unidadIIIListasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uNIDADIToolStripMenuItem
            // 
            this.uNIDADIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeDatosAbstractosToolStripMenuItem,
            this.recursividadToolStripMenuItem});
            this.uNIDADIToolStripMenuItem.Name = "uNIDADIToolStripMenuItem";
            this.uNIDADIToolStripMenuItem.Size = new System.Drawing.Size(252, 25);
            this.uNIDADIToolStripMenuItem.Text = "UNIDAD I: Conceptos básicos";
            // 
            // tiposDeDatosAbstractosToolStripMenuItem
            // 
            this.tiposDeDatosAbstractosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practicaIToolStripMenuItem});
            this.tiposDeDatosAbstractosToolStripMenuItem.Name = "tiposDeDatosAbstractosToolStripMenuItem";
            this.tiposDeDatosAbstractosToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.tiposDeDatosAbstractosToolStripMenuItem.Text = "Tipos de datos abstractos";
            // 
            // practicaIToolStripMenuItem
            // 
            this.practicaIToolStripMenuItem.Name = "practicaIToolStripMenuItem";
            this.practicaIToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.practicaIToolStripMenuItem.Text = "Practica I";
            // 
            // recursividadToolStripMenuItem
            // 
            this.recursividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fibonacciToolStripMenuItem,
            this.mCDToolStripMenuItem,
            this.búsquedaBinariaToolStripMenuItem,
            this.pruebaDeFibonacciToolStripMenuItem,
            this.fractalDeHilbertToolStripMenuItem});
            this.recursividadToolStripMenuItem.Name = "recursividadToolStripMenuItem";
            this.recursividadToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.recursividadToolStripMenuItem.Text = "Recursividad";
            // 
            // fibonacciToolStripMenuItem
            // 
            this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.fibonacciToolStripMenuItem.Text = "Fibonacci";
            // 
            // mCDToolStripMenuItem
            // 
            this.mCDToolStripMenuItem.Name = "mCDToolStripMenuItem";
            this.mCDToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.mCDToolStripMenuItem.Text = "MCD";
            // 
            // búsquedaBinariaToolStripMenuItem
            // 
            this.búsquedaBinariaToolStripMenuItem.Name = "búsquedaBinariaToolStripMenuItem";
            this.búsquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.búsquedaBinariaToolStripMenuItem.Text = "Búsqueda binaria";
            // 
            // pruebaDeFibonacciToolStripMenuItem
            // 
            this.pruebaDeFibonacciToolStripMenuItem.Name = "pruebaDeFibonacciToolStripMenuItem";
            this.pruebaDeFibonacciToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.pruebaDeFibonacciToolStripMenuItem.Text = "Prueba de Fibonacci";
            // 
            // fractalDeHilbertToolStripMenuItem
            // 
            this.fractalDeHilbertToolStripMenuItem.Name = "fractalDeHilbertToolStripMenuItem";
            this.fractalDeHilbertToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.fractalDeHilbertToolStripMenuItem.Text = "Fractal de Hilbert";
            // 
            // unidadIIArreglosToolStripMenuItem
            // 
            this.unidadIIArreglosToolStripMenuItem.Name = "unidadIIArreglosToolStripMenuItem";
            this.unidadIIArreglosToolStripMenuItem.Size = new System.Drawing.Size(164, 25);
            this.unidadIIArreglosToolStripMenuItem.Text = "Unidad II: Arreglos";
            // 
            // unidadIIIListasToolStripMenuItem
            // 
            this.unidadIIIListasToolStripMenuItem.Name = "unidadIIIListasToolStripMenuItem";
            this.unidadIIIListasToolStripMenuItem.Size = new System.Drawing.Size(146, 25);
            this.unidadIIIListasToolStripMenuItem.Text = "Unidad III: Listas";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 55);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(611, 327);
            this.pnlContenido.TabIndex = 2;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 382);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStripMenuItem uNIDADIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDatosAbstractosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicaIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaBinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaDeFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fractalDeHilbertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadIIArreglosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadIIIListasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxCerrar;
    }
}

