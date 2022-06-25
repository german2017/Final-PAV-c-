namespace Montiel.Patricia.Final.PVA
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empezarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaPosicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picRespuesta = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRespuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1615, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarJugadorToolStripMenuItem,
            this.empezarJuegoToolStripMenuItem,
            this.tablaPosicionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cargarJugadorToolStripMenuItem
            // 
            this.cargarJugadorToolStripMenuItem.Name = "cargarJugadorToolStripMenuItem";
            this.cargarJugadorToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cargarJugadorToolStripMenuItem.Text = "Cargar Jugador";
            this.cargarJugadorToolStripMenuItem.Click += new System.EventHandler(this.cargarJugadorToolStripMenuItem_Click);
            // 
            // empezarJuegoToolStripMenuItem
            // 
            this.empezarJuegoToolStripMenuItem.Name = "empezarJuegoToolStripMenuItem";
            this.empezarJuegoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.empezarJuegoToolStripMenuItem.Text = "Empezar Juego";
            this.empezarJuegoToolStripMenuItem.Click += new System.EventHandler(this.empezarJuegoToolStripMenuItem_Click);
            // 
            // tablaPosicionesToolStripMenuItem
            // 
            this.tablaPosicionesToolStripMenuItem.Name = "tablaPosicionesToolStripMenuItem";
            this.tablaPosicionesToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.tablaPosicionesToolStripMenuItem.Text = "Tabla Posiciones";
            this.tablaPosicionesToolStripMenuItem.Click += new System.EventHandler(this.tablaPosicionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1190, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Empezar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Montiel.Patricia.Final.PVA.Properties.Resources.Casa;
            this.pictureBox1.Location = new System.Drawing.Point(89, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 683);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIntentos.Location = new System.Drawing.Point(1190, 337);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(142, 38);
            this.lblIntentos.TabIndex = 3;
            this.lblIntentos.Text = "Intentos: ";
            this.lblIntentos.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1304, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "HAS SIDO CONTRATADO PARA REALIZAR ALGUNAS REFACCIONES EN ESTA CASA, A TRABAJAR..." +
    "";
            // 
            // picRespuesta
            // 
            this.picRespuesta.Location = new System.Drawing.Point(1143, 414);
            this.picRespuesta.Name = "picRespuesta";
            this.picRespuesta.Size = new System.Drawing.Size(495, 344);
            this.picRespuesta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRespuesta.TabIndex = 6;
            this.picRespuesta.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 786);
            this.Controls.Add(this.picRespuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRespuesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem cargarJugadorToolStripMenuItem;
        private ToolStripMenuItem empezarJuegoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private Button button1;
        private PictureBox pictureBox1;
        private Label lblIntentos;
        private Label label1;
        private ToolStripMenuItem tablaPosicionesToolStripMenuItem;
        private PictureBox picRespuesta;
    }
}