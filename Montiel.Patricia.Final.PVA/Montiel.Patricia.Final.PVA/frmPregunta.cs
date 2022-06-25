using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Montiel.Patricia.Final.PVA
{
    public partial class frmPregunta : Form
    {

        private float respuestaJugador;
        private float respuestaCorrecta;
        public int puntaje;

        public frmPregunta()
        {
            InitializeComponent();
        }

        public frmPregunta(Pregunta unaPregunta)
        {
            InitializeComponent();

            this.txtPregunta.Text = unaPregunta.Descripcion;
            //MessageBox.Show(unaPregunta.Imagen);
            this.pictureBox1.Image =  Image.FromFile(unaPregunta.Imagen);
            respuestaCorrecta = unaPregunta.Respuesta;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Pregunta: " + unaPregunta.IdPregunt;
        }

        private void button1_Click(object sender, EventArgs e)//verificar
        {
            respuestaJugador = float.Parse(txtRespuesta.Text);
            if(respuestaJugador == respuestaCorrecta)
            {
                puntaje = 10;
                MessageBox.Show("Respuesta correcta", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.Yes;
                //this.Close();
            }
            else
            {
                MessageBox.Show("Intenta de nuevo","Tuviste un error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }

        }

        private void frmPregunta_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            txtRespuesta.Focus();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.Show();
        }
    }
}
