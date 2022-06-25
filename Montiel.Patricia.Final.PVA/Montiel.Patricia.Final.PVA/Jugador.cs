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
        private int intentos;

        public Jugador()
        {

        }
        public Jugador(string nombre, string division, int puntaje)
        {
            this.nombre = nombre;
            this.division = division;
            this.intentos = puntaje;
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
        public int Intentos 
        { 
            get
            {
                return intentos;

            }
            set
            {
                intentos = value;
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
    public static int OrdenarPorPuntaje(Jugador j1, Jugador j2)
    {
        int ret = 0;

        if(j1.Intentos>j2.Intentos)
        {
            ret = 1;
        }
        else
        {
            if(j1.Intentos<j2.Intentos)
            {
                ret = -1;
            }
        }


        return ret;
    }
    }

    

}
