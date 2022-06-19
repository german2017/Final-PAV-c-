using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montiel.Patricia.Final.PVA
{
    public class Datos
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;
    
    
        public Datos()
        {
            // CREO UN OBJETO SQLCONECTION
            this._conexion = new SqlConnection();
           // _conexion.ConnectionString = sett
            // CREO UN OBJETO SQLCOMMAND
            this._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            this._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            this._comando.Connection = this._conexion;
        }
      
      
        public List<Pregunta> ObtenerListaPersonas()
        {
            bool TodoOk = false;
            List<Pregunta> lista = new List<Pregunta>();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                _comando.CommandText = "SELECT * FROM Preguntas";

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = _comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    lista.Add(new Pregunta(int.Parse(oDr["Id"].ToString()), oDr["pregunta"].ToString(), float.Parse(oDr["respuesta"].ToString()), oDr["imagen"].ToString()));
                }

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (TodoOk)
                    this._conexion.Close();
            }
            return lista;
        }

        public DataTable ObtenerTablaPersonas()
        {
            bool TodoOk = false;
            DataTable tabla = new DataTable("Personas");

            try
            {
                // INDICO EL TIPO DE COMANDO
                this._comando.CommandType = System.Data.CommandType.Text;
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = "SELECT * FROM Personas ORDER BY apellido DESC, nombre";

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = this._comando.ExecuteReader();

                // CARGO LA TABLA CON REGISTROS...
                tabla.Load(oDr);

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (TodoOk)
                    this._conexion.Close();
            }
            return tabla;
        }


    }   
    
}
