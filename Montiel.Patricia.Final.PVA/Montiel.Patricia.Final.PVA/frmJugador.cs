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
    public partial class frmJugador : Form
    {
        private Jugador unJugador;

        public Jugador JugadorFormulario
        { 
            get
            {
                return unJugador;
            }
               
        }

        public frmJugador()
        {
            InitializeComponent();
            unJugador = new Jugador(txtNombreJugador.Text, cmbCurso.SelectedText, 0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmJugador_Load(object sender, EventArgs e)
        {

        }
    }
}
