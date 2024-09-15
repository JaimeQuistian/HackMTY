using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace Work
{
    public partial class frmActividad : Form
    {
        private SpeechSynthesizer synthesizer;
        public frmActividad()
        {
            InitializeComponent();
        }

        private void frmActividad_Load(object sender, EventArgs e)
        {
            mensaje("Sentadilla simple");
           
        }
        private void mensaje(string msg)
        {
            string nuevoMensaje = msg;
            synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;
            synthesizer.Rate = 0;
            synthesizer.SpeakAsync(nuevoMensaje);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ContarEjercicio();
        }

        private async Task ContarEjercicio()
        {
            //Preparacion
            mensaje("3");
            await Task.Delay(1500); 
            mensaje("2");
            await Task.Delay(1000); 
            mensaje("1");
            await Task.Delay(1000);
            mensaje("Ahora");
            await Task.Delay(1500);
            //Ejercicio
            mensaje("Diez");
            await Task.Delay(2000);
            mensaje("9");
            await Task.Delay(2000);
            mensaje("8");
            await Task.Delay(2000);
            mensaje("7");
            await Task.Delay(2000);
            mensaje("6");
            await Task.Delay(2000);
            mensaje("5");
            await Task.Delay(2000);
            mensaje("4");
            await Task.Delay(2000);
            mensaje("3");
            await Task.Delay(2000);
            mensaje("2");
            await Task.Delay(2000);
            mensaje("1");
            await Task.Delay(2000);

            mensaje("Felicidades, Ejercicio 1 terminado");
            await Task.Delay(3600);
            mensaje("Hora del siguiente ejercicio, Sentadilla bulgara");
            pbAct1.Image = Properties.Resources.jump2;
        }
    }
}