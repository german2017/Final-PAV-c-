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
    public partial class frmTabla : Form
    {
        private List<Jugador> listaJugadores;
        public frmTabla(List<Jugador> lista)
        {
            InitializeComponent();
            this.Text = "Tabla de posiciones";
            this.listaJugadores = lista;
        }

        private void frmTabla_Load(object sender, EventArgs e)
        {
            listaJugadores.Sort(Jugador.OrdenarPorPuntaje);
            this.dgvPosiciones.DataSource = listaJugadores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
