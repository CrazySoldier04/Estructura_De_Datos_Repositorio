namespace Estructura_De_Datos_Proyecto
{
    partial class frmMCD
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
            this.pnlMCD = new System.Windows.Forms.Panel();
            this.pbxMCD = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblMCD = new System.Windows.Forms.Label();
            this.txtMCD = new System.Windows.Forms.TextBox();
            this.pnlTrabajo = new System.Windows.Forms.Panel();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlMCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.pnlTrabajo.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(909, 30);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(371, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Máximo Común Divisor";
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.pnlTrabajo);
            this.pnlContenido.Controls.Add(this.pnlMCD);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 30);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(909, 369);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlMCD
            // 
            this.pnlMCD.BackColor = System.Drawing.Color.White;
            this.pnlMCD.Controls.Add(this.txtMCD);
            this.pnlMCD.Controls.Add(this.lblMCD);
            this.pnlMCD.Controls.Add(this.pbxMCD);
            this.pnlMCD.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMCD.Location = new System.Drawing.Point(437, 0);
            this.pnlMCD.Name = "pnlMCD";
            this.pnlMCD.Size = new System.Drawing.Size(472, 369);
            this.pnlMCD.TabIndex = 0;
            // 
            // pbxMCD
            // 
            this.pbxMCD.Image = global::Estructura_De_Datos_Proyecto.Properties.Resources.E19_1;
            this.pbxMCD.Location = new System.Drawing.Point(36, 49);
            this.pbxMCD.Name = "pbxMCD";
            this.pbxMCD.Size = new System.Drawing.Size(400, 192);
            this.pbxMCD.TabIndex = 0;
            this.pbxMCD.TabStop = false;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(876, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(33, 30);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // lblMCD
            // 
            this.lblMCD.AutoSize = true;
            this.lblMCD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCD.Location = new System.Drawing.Point(113, 17);
            this.lblMCD.Name = "lblMCD";
            this.lblMCD.Size = new System.Drawing.Size(247, 19);
            this.lblMCD.TabIndex = 1;
            this.lblMCD.Text = "Máximo Común Denominador";
            // 
            // txtMCD
            // 
            this.txtMCD.Location = new System.Drawing.Point(36, 257);
            this.txtMCD.Multiline = true;
            this.txtMCD.Name = "txtMCD";
            this.txtMCD.Size = new System.Drawing.Size(400, 100);
            this.txtMCD.TabIndex = 2;
            this.txtMCD.TabStop = false;
            this.txtMCD.Text = "En matemáticas, se define el máximo común divisor (MCD) de dos o más números ente" +
    "ros al mayor número entero que los divide sin dejar residuo.";
            // 
            // pnlTrabajo
            // 
            this.pnlTrabajo.Controls.Add(this.btnLimpiar);
            this.pnlTrabajo.Controls.Add(this.lblMaximo);
            this.pnlTrabajo.Controls.Add(this.txtMaximo);
            this.pnlTrabajo.Controls.Add(this.btnCalcular);
            this.pnlTrabajo.Controls.Add(this.txtNum2);
            this.pnlTrabajo.Controls.Add(this.txtNum1);
            this.pnlTrabajo.Controls.Add(this.lblNumero2);
            this.pnlTrabajo.Controls.Add(this.lblNumero1);
            this.pnlTrabajo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTrabajo.Location = new System.Drawing.Point(0, 0);
            this.pnlTrabajo.Name = "pnlTrabajo";
            this.pnlTrabajo.Size = new System.Drawing.Size(437, 369);
            this.pnlTrabajo.TabIndex = 1;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(29, 17);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(93, 21);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número 1: ";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(29, 75);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(93, 21);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Número 2: ";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(128, 14);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 27);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(128, 72);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 27);
            this.txtNum2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(24, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(195, 31);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMaximo
            // 
            this.txtMaximo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximo.Location = new System.Drawing.Point(101, 195);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.ReadOnly = true;
            this.txtMaximo.Size = new System.Drawing.Size(127, 27);
            this.txtMaximo.TabIndex = 5;
            this.txtMaximo.TabStop = false;
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(29, 198);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(62, 19);
            this.lblMaximo.TabIndex = 6;
            this.lblMaximo.Text = "M.C.D: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(225, 128);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(195, 31);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmMCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(909, 399);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlMCD.ResumeLayout(false);
            this.pnlMCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.pnlTrabajo.ResumeLayout(false);
            this.pnlTrabajo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlMCD;
        private System.Windows.Forms.PictureBox pbxMCD;
        private System.Windows.Forms.TextBox txtMCD;
        private System.Windows.Forms.Label lblMCD;
        private System.Windows.Forms.Panel pnlTrabajo;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}