using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CRM.Objetos;
//Crear la conexion y ejecuta los SqlParameter para traer y manipular datos desde SQL 

namespace CRM.CapaDatos
{
    public class DAOCanal
    {
        string cadenaConexion = string.Empty;

        public DAOCanal(string cadena)
        {
            cadenaConexion = cadena;
        }

        public int CrearCanal(Canal can)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("CREAR_CANAL", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter nombre = new SqlParameter("i_nombre", can.Nombre);
            SqlParameter medio = new SqlParameter("i_medio", can.Medio);
            SqlParameter usu = new SqlParameter("i_usu", can.Usu);
            SqlParameter bkp = new SqlParameter("i_bkp", can.Bkp);
            com.Parameters.Add(nombre);
            com.Parameters.Add(medio);
            com.Parameters.Add(usu);
            com.Parameters.Add(bkp);

            con.Open();
            int retVal = (int)com.ExecuteScalar();
            con.Close();
            return retVal;
        }

        private Canal CargarCanales(SqlDataReader drCanales)
        {
            Canal can = new Canal();
            can.Id = drCanales.GetInt32(0);
            can.Nombre = drCanales.GetString(1);
            can.Medio = drCanales.GetString(2);
            can.usu = drCanales.GetString(3);
            can.Bkp = drCanales.GetString(4);

            //if (drCanales.GetInt32(3) == 1)
            //    can.FlagGeneral = true;
            return can;
        }

        public List<Canal> ListarCanales()
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("LISTAR_CANALES", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();

            SqlDataReader drCanales = com.ExecuteReader();
            List<Canal> listaCanales = new List<Canal>();

            while (drCanales.Read())
            {
                listaCanales.Add(CargarCanales(drCanales));
            }

            drCanales.Close();
            con.Close();
            return listaCanales;
        }



    }
}
