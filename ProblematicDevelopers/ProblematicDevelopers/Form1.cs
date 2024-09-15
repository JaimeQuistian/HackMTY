using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmInformacion informacion = new frmInformacion();
            if (txtUsuario.Text == "admin" && txtContrasena.Text == "123456")
            {
                this.Hide();
                DialogResult resutado = informacion.ShowDialog();
                if (resutado == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    informacion.Close();
                    this.Show();
                }
                txtContrasena.Text = null;
                txtUsuario.Text = null;
            }
            else
            {
                MessageBox.Show("Error al escribir el usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContrasena.Text = null;
                txtUsuario.Text = null;
            }
        }
    }
}
