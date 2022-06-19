﻿using System;
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
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            frmAyudaFigura ayudaFigura = new frmAyudaFigura();
            ayudaFigura.ShowDialog();
        }
    }
}