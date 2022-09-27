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
            bool bandera = false;
            if (File.Exists("./Localidades.txt") == true)
            {

                StreamReader srLocalidades = new StreamReader("./Localidades.txt");
                while (!srLocalidades.EndOfStream)
                {
                    string[] vecLocalidades = srLocalidades.ReadLine().Split(',');
                    if (vecLocalidades[0] == txtID.Text)
                    {
                        bandera = true;
                    }
                }
                srLocalidades.Close();
            }

            // Creamos el archivo, si existe lo editamos
            if (bandera != true)
            {
                StreamWriter swLocalidades = new StreamWriter("./Localidades.txt", true);

                swLocalidades.WriteLine(txtID.Text + "," + cboLocalidades.Text);
                MessageBox.Show("Datos grabados exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                swLocalidades.Close();

                txtID.Text = "";
                cboLocalidades.Text = "";
                txtID.Focus();
            }
            else
            {
                MessageBox.Show("El ID ya está cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            //File.WriteAllText("./Localidad.txt", txtID.Text + " " + cboLocalidades.Text);
            //MessageBox.Show("Información grabada exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
