namespace Estructura_De_Datos_Proyecto
{
    partial class frmSeleccionarDatos
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.rbtnAdt2 = new System.Windows.Forms.RadioButton();
            this.rbtnAdt1 = new System.Windows.Forms.RadioButton();
            this.rbtnString = new System.Windows.Forms.RadioButton();
            this.rbtnChar = new System.Windows.Forms.RadioButton();
            this.rbtnDecimal = new System.Windows.Forms.RadioButton();
            this.rbtnDouble = new System.Windows.Forms.RadioButton();
            this.rbtnInt = new System.Windows.Forms.RadioButton();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.pnlContenido.SuspendLayout();
            this.gbxDatos.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(292, 29);
            this.pnlTitulo.TabIndex = 0;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackgroundImage = global::Estructura_De_Datos_Proyecto.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(260, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(32, 29);
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
            this.lblTitulo.Location = new System.Drawing.Point(76, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(141, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Seleccionar dato";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlContenido.Controls.Add(this.btnIniciar);
            this.pnlContenido.Controls.Add(this.gbxDatos);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 29);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(292, 361);
            this.pnlContenido.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIniciar.Location = new System.Drawing.Point(71, 317);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(150, 32);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDatos.Controls.Add(this.rbtnAdt2);
            this.gbxDatos.Controls.Add(this.rbtnAdt1);
            this.gbxDatos.Controls.Add(this.rbtnString);
            this.gbxDatos.Controls.Add(this.rbtnChar);
            this.gbxDatos.Controls.Add(this.rbtnDecimal);
            this.gbxDatos.Controls.Add(this.rbtnDouble);
            this.gbxDatos.Controls.Add(this.rbtnInt);
            this.gbxDatos.Location = new System.Drawing.Point(12, 4);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(268, 303);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            // 
            // rbtnAdt2
            // 
            this.rbtnAdt2.AutoSize = true;
            this.rbtnAdt2.Location = new System.Drawing.Point(46, 267);
            this.rbtnAdt2.Name = "rbtnAdt2";
            this.rbtnAdt2.Size = new System.Drawing.Size(74, 25);
            this.rbtnAdt2.TabIndex = 6;
            this.rbtnAdt2.TabStop = true;
            this.rbtnAdt2.Text = "ADT 2";
            this.rbtnAdt2.UseVisualStyleBackColor = true;
            // 
            // rbtnAdt1
            // 
            this.rbtnAdt1.AutoSize = true;
            this.rbtnAdt1.Location = new System.Drawing.Point(46, 227);
            this.rbtnAdt1.Name = "rbtnAdt1";
            this.rbtnAdt1.Size = new System.Drawing.Size(74, 25);
            this.rbtnAdt1.TabIndex = 5;
            this.rbtnAdt1.TabStop = true;
            this.rbtnAdt1.Text = "ADT 1";
            this.rbtnAdt1.UseVisualStyleBackColor = true;
            // 
            // rbtnString
            // 
            this.rbtnString.AutoSize = true;
            this.rbtnString.Location = new System.Drawing.Point(46, 186);
            this.rbtnString.Name = "rbtnString";
            this.rbtnString.Size = new System.Drawing.Size(72, 25);
            this.rbtnString.TabIndex = 4;
            this.rbtnString.TabStop = true;
            this.rbtnString.Text = "String";
            this.rbtnString.UseVisualStyleBackColor = true;
            // 
            // rbtnChar
            // 
            this.rbtnChar.AutoSize = true;
            this.rbtnChar.Location = new System.Drawing.Point(46, 146);
            this.rbtnChar.Name = "rbtnChar";
            this.rbtnChar.Size = new System.Drawing.Size(67, 25);
            this.rbtnChar.TabIndex = 3;
            this.rbtnChar.TabStop = true;
            this.rbtnChar.Text = "Char";
            this.rbtnChar.UseVisualStyleBackColor = true;
            // 
            // rbtnDecimal
            // 
            this.rbtnDecimal.AutoSize = true;
            this.rbtnDecimal.Location = new System.Drawing.Point(46, 106);
            this.rbtnDecimal.Name = "rbtnDecimal";
            this.rbtnDecimal.Size = new System.Drawing.Size(92, 25);
            this.rbtnDecimal.TabIndex = 2;
            this.rbtnDecimal.TabStop = true;
            this.rbtnDecimal.Text = "Decimal";
            this.rbtnDecimal.UseVisualStyleBackColor = true;
            // 
            // rbtnDouble
            // 
            this.rbtnDouble.AutoSize = true;
            this.rbtnDouble.Location = new System.Drawing.Point(46, 66);
            this.rbtnDouble.Name = "rbtnDouble";
            this.rbtnDouble.Size = new System.Drawing.Size(84, 25);
            this.rbtnDouble.TabIndex = 1;
            this.rbtnDouble.TabStop = true;
            this.rbtnDouble.Text = "Double";
            this.rbtnDouble.UseVisualStyleBackColor = true;
            // 
            // rbtnInt
            // 
            this.rbtnInt.AutoSize = true;
            this.rbtnInt.Location = new System.Drawing.Point(46, 26);
            this.rbtnInt.Name = "rbtnInt";
            this.rbtnInt.Size = new System.Drawing.Size(50, 25);
            this.rbtnInt.TabIndex = 0;
            this.rbtnInt.TabStop = true;
            this.rbtnInt.Text = "Int";
            this.rbtnInt.UseVisualStyleBackColor = true;
            // 
            // frmSeleccionarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 390);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSeleccionarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.RadioButton rbtnAdt2;
        private System.Windows.Forms.RadioButton rbtnAdt1;
        private System.Windows.Forms.RadioButton rbtnString;
        private System.Windows.Forms.RadioButton rbtnChar;
        private System.Windows.Forms.RadioButton rbtnDecimal;
        private System.Windows.Forms.RadioButton rbtnDouble;
        private System.Windows.Forms.RadioButton rbtnInt;
    }
}