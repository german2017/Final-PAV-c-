namespace Montiel.Patricia.Final.PVA
{
    partial class frmAyuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnRombo = new System.Windows.Forms.Button();
            this.btnRomboide = new System.Windows.Forms.Button();
            this.btnTrapecio = new System.Windows.Forms.Button();
            this.lblQueFigura = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(12, 48);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(253, 58);
            this.btnCuadrado.TabIndex = 0;
            this.btnCuadrado.Text = "Area Cuadrado";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(12, 112);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(253, 58);
            this.btnRectangulo.TabIndex = 1;
            this.btnRectangulo.Text = "Area Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnRombo
            // 
            this.btnRombo.Location = new System.Drawing.Point(12, 176);
            this.btnRombo.Name = "btnRombo";
            this.btnRombo.Size = new System.Drawing.Size(253, 58);
            this.btnRombo.TabIndex = 2;
            this.btnRombo.Text = "Area Rombo";
            this.btnRombo.UseVisualStyleBackColor = true;
            this.btnRombo.Click += new System.EventHandler(this.btnRombo_Click);
            // 
            // btnRomboide
            // 
            this.btnRomboide.Location = new System.Drawing.Point(12, 240);
            this.btnRomboide.Name = "btnRomboide";
            this.btnRomboide.Size = new System.Drawing.Size(253, 58);
            this.btnRomboide.TabIndex = 3;
            this.btnRomboide.Text = "Area Romboide";
            this.btnRomboide.UseVisualStyleBackColor = true;
            this.btnRomboide.Click += new System.EventHandler(this.btnRomboide_Click);
            // 
            // btnTrapecio
            // 
            this.btnTrapecio.Location = new System.Drawing.Point(12, 304);
            this.btnTrapecio.Name = "btnTrapecio";
            this.btnTrapecio.Size = new System.Drawing.Size(253, 58);
            this.btnTrapecio.TabIndex = 4;
            this.btnTrapecio.Text = "Area Trapecio Rectangular";
            this.btnTrapecio.UseVisualStyleBackColor = true;
            this.btnTrapecio.Click += new System.EventHandler(this.btnTrapecio_Click);
            // 
            // lblQueFigura
            // 
            this.lblQueFigura.AutoSize = true;
            this.lblQueFigura.Location = new System.Drawing.Point(43, 9);
            this.lblQueFigura.Name = "lblQueFigura";
            this.lblQueFigura.Size = new System.Drawing.Size(198, 20);
            this.lblQueFigura.TabIndex = 5;
            this.lblQueFigura.Text = "¿Que figura estás buscando?";
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(89, 385);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(94, 29);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 440);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.lblQueFigura);
            this.Controls.Add(this.btnTrapecio);
            this.Controls.Add(this.btnRomboide);
            this.Controls.Add(this.btnRombo);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnCuadrado);
            this.Name = "frmAyuda";
            this.Text = "frmAyuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCuadrado;
        private Button btnRectangulo;
        private Button btnRombo;
        private Button btnRomboide;
        private Button btnTrapecio;
        private Label lblQueFigura;
        private Button Cerrar;
    }
}