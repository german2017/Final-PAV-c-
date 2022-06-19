using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montiel.Patricia.Final.PVA
{
    public class Pregunta
    {
        private int idPregunta;
        private string descripcion;
        private float respuesta;
        private string imagen;

        public Pregunta(int idPregunta, string descripcion, float respuesta, string imagen)
        {
            this.idPregunta = idPregunta;
            this.descripcion = descripcion;
            this.respuesta = respuesta;
            this.imagen = imagen;
        }

        public Pregunta(int idPregunta, string descripcion, float respuesta)
        {
            this.idPregunta = idPregunta;
            this.descripcion = descripcion;
            this.respuesta = respuesta;
           
        }

        public int IdPregunt 
        {
            get
            {
                return idPregunta;
            } 
            set
            {
                idPregunta = value;
            }
        }

        public string Descripcion
        { 
            get
            {
                return descripcion;
            }
            set
            {
                descripcion=value;
            }
        }

        public float Respuesta
        { 
            get
            {
                return respuesta;
            }
            set
            {
                respuesta=value;
            }
        }

        public string Imagen
        { 
            get
            {
                return imagen;
            }
            set
            {
                imagen = value;
            }
        }

    }
}
