
namespace pryTissera_SP1
{
    partial class frmCultivos
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cboCultivos = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(62, 100);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Location = new System.Drawing.Point(14, 61);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(42, 13);
            this.lblCultivo.TabIndex = 8;
            this.lblCultivo.Text = "Cultivo:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(35, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID:";
            // 
            // cboCultivos
            // 
            this.cboCultivos.FormattingEnabled = true;
            this.cboCultivos.Items.AddRange(new object[] {
            "Soja",
            "Zapallo",
            "Trigo",
            "Maíz"});
            this.cboCultivos.Location = new System.Drawing.Point(62, 58);
            this.cboCultivos.Name = "cboCultivos";
            this.cboCultivos.Size = new System.Drawing.Size(121, 21);
            this.cboCultivos.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(62, 19);
            this.txtID.Mask = "99999";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 20);
            this.txtID.TabIndex = 5;
            this.txtID.ValidatingType = typeof(int);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 177);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cboCultivos);
            this.Controls.Add(this.txtID);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cboCultivos;
        private System.Windows.Forms.MaskedTextBox txtID;
    }
}