using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    public partial class frmConoceTuCuerpo : Form
    {
        public frmConoceTuCuerpo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text) ||
                string.IsNullOrWhiteSpace(txtAltura.Text) ||
                cbSexo.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool esNumeroEdad = int.TryParse(txtEdad.Text, out int edad);
                bool esNumeroPeso = double.TryParse(txtPeso.Text, out double peso);
                bool esNumeroAltura = double.TryParse(txtAltura.Text, out double altura);

                if (!esNumeroEdad || !esNumeroPeso || !esNumeroAltura)
                {
                    MessageBox.Show("Favor de ingresar valores validos en los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Datos guardados exitosamente\n¿Desea modificar algún dato?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        txtEdad.Text = null;
                        txtPeso.Text = null;
                        txtAltura.Text = null;
                        cbSexo.SelectedIndex = -1;
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    } 
                }
            }
        }
    }
}
