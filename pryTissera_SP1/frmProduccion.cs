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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader srLocalidades = new StreamReader("./Localidades.txt");

            while (!srLocalidades.EndOfStream)
            {
                string[] vecLocalidades = srLocalidades.ReadLine().Split(',');
                cboLocalidades.Items.Add(vecLocalidades[1]);
            }
            srLocalidades.Close();

            
            StreamReader srCultivos = new StreamReader("./Cultivos.txt");

            while (!srCultivos.EndOfStream)
            {
                string[] vecCultivos = srCultivos.ReadLine().Split(',');
                cboCultivos.Items.Add(vecCultivos[1]);
            }
            srCultivos.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter swProduccion = new StreamWriter("./Produccion.txt", true);

            swProduccion.WriteLine(cboLocalidades.Text + "," + cboCultivos.Text + "," + txtToneladas.Text);
            swProduccion.Close();

            MessageBox.Show("Datos grabados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cboLocalidades.Text = "";
            cboCultivos.Text = "";
            txtToneladas.Text = "";
        }
    }
}
