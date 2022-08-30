using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryTissera_SP1
{
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // Creamos el archivo, si existe lo editamos
            StreamWriter swLocalidades = new StreamWriter("./Localidades.txt", true);

            swLocalidades.WriteLine(txtID.Text + " " + cboLocalidades.Text);
            MessageBox.Show("Datos grabados exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            swLocalidades.Close();

            txtID.Text = "";
            cboLocalidades.Text = "";
            txtID.Focus();
           
            //File.WriteAllText("./Localidad.txt", txtID.Text + " " + cboLocalidades.Text);
            //MessageBox.Show("Información grabada exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
