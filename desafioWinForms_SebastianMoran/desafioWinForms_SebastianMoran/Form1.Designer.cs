
namespace desafioWinForms_SebastianMoran
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBermuda = new System.Windows.Forms.CheckBox();
            this.chkMangaCorta = new System.Windows.Forms.CheckBox();
            this.radPantalon = new System.Windows.Forms.RadioButton();
            this.radCamisa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radPremium = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBermuda);
            this.groupBox1.Controls.Add(this.chkMangaCorta);
            this.groupBox1.Controls.Add(this.radPantalon);
            this.groupBox1.Controls.Add(this.radCamisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prenda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkBermuda
            // 
            this.chkBermuda.AutoSize = true;
            this.chkBermuda.Location = new System.Drawing.Point(155, 54);
            this.chkBermuda.Name = "chkBermuda";
            this.chkBermuda.Size = new System.Drawing.Size(68, 17);
            this.chkBermuda.TabIndex = 3;
            this.chkBermuda.Text = "Bermuda";
            this.chkBermuda.UseVisualStyleBackColor = true;
            // 
            // chkMangaCorta
            // 
            this.chkMangaCorta.AutoSize = true;
            this.chkMangaCorta.Location = new System.Drawing.Point(155, 30);
            this.chkMangaCorta.Name = "chkMangaCorta";
            this.chkMangaCorta.Size = new System.Drawing.Size(86, 17);
            this.chkMangaCorta.TabIndex = 2;
            this.chkMangaCorta.Text = "Manga corta";
            this.chkMangaCorta.UseVisualStyleBackColor = true;
            // 
            // radPantalon
            // 
            this.radPantalon.AutoSize = true;
            this.radPantalon.Location = new System.Drawing.Point(17, 54);
            this.radPantalon.Name = "radPantalon";
            this.radPantalon.Size = new System.Drawing.Size(67, 17);
            this.radPantalon.TabIndex = 1;
            this.radPantalon.TabStop = true;
            this.radPantalon.Text = "Pantalon";
            this.radPantalon.UseVisualStyleBackColor = true;
            this.radPantalon.CheckedChanged += new System.EventHandler(this.radPantalon_CheckedChanged);
            // 
            // radCamisa
            // 
            this.radCamisa.AutoSize = true;
            this.radCamisa.Location = new System.Drawing.Point(17, 30);
            this.radCamisa.Name = "radCamisa";
            this.radCamisa.Size = new System.Drawing.Size(59, 17);
            this.radCamisa.TabIndex = 0;
            this.radCamisa.TabStop = true;
            this.radCamisa.Text = "Camisa";
            this.radCamisa.UseVisualStyleBackColor = true;
            this.radCamisa.CheckedChanged += new System.EventHandler(this.radCamisa_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENTAS AL POR MAYOR - Prad Bit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radPremium);
            this.groupBox2.Controls.Add(this.radStandard);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de prenda";
            // 
            // radPremium
            // 
            this.radPremium.AutoSize = true;
            this.radPremium.Location = new System.Drawing.Point(155, 29);
            this.radPremium.Name = "radPremium";
            this.radPremium.Size = new System.Drawing.Size(65, 17);
            this.radPremium.TabIndex = 1;
            this.radPremium.Text = "Premium";
            this.radPremium.UseVisualStyleBackColor = true;
            this.radPremium.CheckedChanged += new System.EventHandler(this.radPremium_CheckedChanged);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(17, 29);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.radStandard_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 54);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(17, 20);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Location = new System.Drawing.Point(145, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 54);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(8, 20);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(13, 308);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(262, 56);
            this.btnCalcularPrecio.TabIndex = 5;
            this.btnCalcularPrecio.Text = "Calcular precio final";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 390);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sistema de ventas v.1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBermuda;
        private System.Windows.Forms.CheckBox chkMangaCorta;
        private System.Windows.Forms.RadioButton radPantalon;
        private System.Windows.Forms.RadioButton radCamisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radPremium;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcularPrecio;
    }
}

