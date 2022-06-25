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
    public partial class frmAyudaFigura : Form
    {
        public frmAyudaFigura(String imagen)
        {
            InitializeComponent();
            this.pictureBox1.Image = Image.FromFile(imagen);
        }

        private void frmAyudaFigura_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
