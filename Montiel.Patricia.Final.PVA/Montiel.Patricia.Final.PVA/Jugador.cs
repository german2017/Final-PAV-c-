using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montiel.Patricia.Final.PVA
{
    public class Jugador
    {
        private string nombre;
        private string division;
        private int puntaje;

        public Jugador(string nombre, string division, int puntaje)
        {
            this.nombre = nombre;
            this.division = division;
            this.puntaje = puntaje;
        }

        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Puntaje 
        { 
            get
            {
                return puntaje;

            }
            set
            {
                puntaje = value;
            }
        }
        public string Division 
        { 
            get
            {
                return division;
            }
            set
            {
                division = value;
            }
        }

    }
}
