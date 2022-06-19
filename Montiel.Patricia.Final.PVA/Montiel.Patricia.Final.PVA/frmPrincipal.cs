namespace Montiel.Patricia.Final.PVA
{
    public partial class frmPrincipal : Form
    {

        private List<Pregunta> preguntas;
        private int indice;
        private bool primero;
        private int puntajeAcumulado;
        private Jugador elJugador;
        private Datos data;
      
        public frmPrincipal()
        {
            InitializeComponent();
          
            button1.ForeColor = Color.Green;
            indice = 0;
            primero = true;
            puntajeAcumulado = 1;
            data = new Datos();
            preguntas = data.ObtenerListaPersonas();
            string directorio;
            directorio = System.AppDomain.CurrentDomain.BaseDirectory;
            preguntas.Add(new Pregunta(1,"Debes alfombrar el piso de este dormitorio, tomaste las medidas y todos los lados miden 4 metros. ¿Cuántos metros de alfombra necesitas?", 16, directorio + "Recursos Imagenes\\imagen Pregunta 1.jpg"));
            preguntas.Add(new Pregunta(2, "Se quiere colocar madera en el piso de este dormitorio. Tu ayudante toma las medidas y dice: 4 metros y 3 metros. ¿Cuántos metros cuadrados de madera necesitas?", 12, directorio + "Recursos Imagenes\\imagen Pregunta 4.jpg"));
            preguntas.Add(new Pregunta(3, "Hay que empapelar la pared de fondo. Tu ayudante te dice las medidas que pude tomar son: 4 m, 2 m y 3 m. ¿Cuántos metros cuadrados de papel necesitas?", 9, directorio + "Recursos Imagenes\\imagen Pregunta 2.jpg"));
            preguntas.Add(new Pregunta(4, "El techo del garage tiene un diseño novedoso pero requiere reparación porque filtra agua por las tejas. Tu ayudante tomó las medidas y te dice lo siguiente: medí sobre la medianera el largo y tiene 5 m, mientras que el ancho lo medí desde abajo guiándome por el ancho del auto y le calculé 3 m. ¿Podemos saber cuántos metros cuadrados de tejas necesitamos?", 15, directorio + "Recursos Imagenes\\imagen Pregunta 3.jpg"));
            preguntas.Add(new Pregunta(5, "Aquí solo queda decorar con un tipo de cerámica diferente la figura central de este garage. Tu ayudante tomó las medidas entre los extremos opuestos y te dijo: 6 m y 3 m. ¿Podemos saber qué cantidad de cerámica se necesita para esa parte?", 9, directorio + "Recursos Imagenes\\imagen Pregunta 5.jpg"));

            this.Text = "MATEDEC";
        }

        private void cargarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJugador nuevoJugador = new frmJugador();
            //nuevoJugador.MdiParent = this;


            if(nuevoJugador.ShowDialog()== DialogResult.OK)
            {
                elJugador = nuevoJugador.JugadorFormulario;


            }

        }

        private void empezarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda miAyuda = new frmAyuda();

            miAyuda.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(primero == true)
            {
                MessageBox.Show("Vamos a jugar!!!");
                primero = false;
                button1.Text = "Pregunta " + (indice+1).ToString();
              //  button1.ForeColor = Color.Green;
            }
            else
            {
                if(indice < preguntas.Count)
                {
                    frmPregunta unaPregunta = new frmPregunta(preguntas[indice]);
                 
                    if( unaPregunta.ShowDialog()==DialogResult.Yes)
                    {
                        indice++;
                        if (indice != preguntas.Count)
                        {
                            button1.Text = "Pregunta " + (indice + 1).ToString();

                            Console.WriteLine(puntajeAcumulado);
                        }
                        else
                        {
                            MessageBox.Show(puntajeAcumulado.ToString());
                            button1.Text = "Llegaste al final del juego";
                            button1.ForeColor = Color.Red;
                        }
                    }

                    puntajeAcumulado = puntajeAcumulado + 1; 
                    lblIntentos.Text = puntajeAcumulado.ToString();
                    
                    
                }
                else
                {
                    MessageBox.Show("Ya contestaste todas las preguntas");
                }
             
            }


           
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}