
namespace pryTissera_SP1
{
    partial class frmProduccion
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
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.cboLocalidades = new System.Windows.Forms.ComboBox();
            this.cboCultivos = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.txtToneladas = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(12, 23);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 0;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Location = new System.Drawing.Point(12, 58);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(42, 13);
            this.lblCultivo.TabIndex = 1;
            this.lblCultivo.Text = "Cultivo:";
            // 
            // cboLocalidades
            // 
            this.cboLocalidades.FormattingEnabled = true;
            this.cboLocalidades.Location = new System.Drawing.Point(74, 20);
            this.cboLocalidades.Name = "cboLocalidades";
            this.cboLocalidades.Size = new System.Drawing.Size(121, 21);
            this.cboLocalidades.TabIndex = 3;
            // 
            // cboCultivos
            // 
            this.cboCultivos.FormattingEnabled = true;
            this.cboCultivos.Location = new System.Drawing.Point(74, 55);
            this.cboCultivos.Name = "cboCultivos";
            this.cboCultivos.Size = new System.Drawing.Size(121, 21);
            this.cboCultivos.TabIndex = 4;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(74, 136);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Location = new System.Drawing.Point(12, 99);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(60, 13);
            this.lblToneladas.TabIndex = 6;
            this.lblToneladas.Text = "Toneladas:";
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(74, 96);
            this.txtToneladas.Mask = "99999";
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(121, 20);
            this.txtToneladas.TabIndex = 7;
            this.txtToneladas.ValidatingType = typeof(int);
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 171);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cboCultivos);
            this.Controls.Add(this.cboLocalidades);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblLocalidad);
            this.Name = "frmProduccion";
            this.Text = "Producción";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.ComboBox cboLocalidades;
        private System.Windows.Forms.ComboBox cboCultivos;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.MaskedTextBox txtToneladas;
    }
}