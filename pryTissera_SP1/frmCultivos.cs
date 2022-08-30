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
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter swCultivos = new StreamWriter("./Cultivos.txt", true);

            swCultivos.WriteLine(txtID.Text + " " + cboCultivos.Text);
            swCultivos.Close();

            MessageBox.Show("Datos grabados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Text = "";
            cboCultivos.Text = "";
            txtID.Focus();
        }
    }
}
