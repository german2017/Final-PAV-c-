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
    public partial class frmAyuda : Form
    {
        string directorio;
        public frmAyuda()
        {
            InitializeComponent();
            directorio = System.AppDomain.CurrentDomain.BaseDirectory;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            frmAyudaFigura ayudaFigura = new frmAyudaFigura(directorio + "Recursos Imagenes\\Cuadrado.png");
            ayudaFigura.Show();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {

            frmAyudaFigura ayudaFigura = new frmAyudaFigura(directorio + "Recursos Imagenes\\Rectangulo.png");
            ayudaFigura.Show();
        }

        private void btnRombo_Click(object sender, EventArgs e)
        {

            frmAyudaFigura ayudaFigura = new frmAyudaFigura(directorio + "Recursos Imagenes\\Rombo.png");
            ayudaFigura.Show();
        }

        private void btnRomboide_Click(object sender, EventArgs e)
        {

            frmAyudaFigura ayudaFigura = new frmAyudaFigura(directorio + "Recursos Imagenes\\Romboide.png");
            ayudaFigura.Show();
        }

        private void btnTrapecio_Click(object sender, EventArgs e)
        {

            frmAyudaFigura ayudaFigura = new frmAyudaFigura(directorio + "Recursos Imagenes\\Trapecio.png");
            ayudaFigura.Show();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
