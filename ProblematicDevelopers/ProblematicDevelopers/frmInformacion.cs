using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Work
{
    public partial class frmInformacion : Form
    {
        private SpeechSynthesizer synthesizer;
        public frmInformacion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            synthesizer = new SpeechSynthesizer();

            synthesizer.Volume = 100;
            synthesizer.Rate = 0;

            //synthesizer.SelectVoice("Microsoft David Desktop");

            synthesizer.SpeakAsync("Bienvenido a Workout Assistant su asistente virtual personal, favor de seleccionar una opción");
        }

        private void btnCTC_Click(object sender, EventArgs e)
        {
            frmConoceTuCuerpo conoceTuCuerpo = new frmConoceTuCuerpo();
            this.Hide();
            DialogResult resutado = conoceTuCuerpo.ShowDialog();
            if (resutado == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                conoceTuCuerpo.Close();
                this.Show();
            }
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            frmActividad actividadFisica = new frmActividad();
            this.Hide();
            DialogResult resutado = actividadFisica.ShowDialog();
            if (resutado == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                actividadFisica.Close();
                this.Show();
            }
        }
    }
}