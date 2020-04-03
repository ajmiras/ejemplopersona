namespace EjemploPersona
{
    partial class FPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cbPersona = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPersona = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(171, 55);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(171, 92);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(131, 58);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(131, 95);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(171, 137);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cbPersona
            // 
            this.cbPersona.FormattingEnabled = true;
            this.cbPersona.Items.AddRange(new object[] {
            "Javier",
            "Jose",
            "Luís"});
            this.cbPersona.Location = new System.Drawing.Point(384, 54);
            this.cbPersona.Name = "cbPersona";
            this.cbPersona.Size = new System.Drawing.Size(121, 21);
            this.cbPersona.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(332, 58);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(46, 13);
            this.lblPersona.TabIndex = 6;
            this.lblPersona.Text = "Persona";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 319);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.cbPersona);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Name = "FPrincipal";
            this.Text = "Ejemplo de clases";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cbPersona;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

