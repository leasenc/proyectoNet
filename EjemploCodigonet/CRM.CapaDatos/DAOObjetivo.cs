using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CRM.Objetos;

namespace CRM.CapaDatos
{
    public class DAOObjetivo
    {
        string cadenaConexion = string.Empty;

        public DAOObjetivo(string cadena)
        {
            cadenaConexion = cadena;
        }

        public int CrearObjetivo(Objetivo obj)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("CREAR_OBJETIVO", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter nombre = new SqlParameter("i_nombre", obj.Nombre);
            SqlParameter valor = new SqlParameter("i_valor", obj.Valor);
            SqlParameter flag = new SqlParameter("i_flag", obj.FlagGeneral);
            SqlParameter cod = new SqlParameter("i_cod", obj.CodGeneral);
            com.Parameters.Add(nombre);
            com.Parameters.Add(valor);
            com.Parameters.Add(flag);
            com.Parameters.Add(cod);

            con.Open();
            int retVal = (int)com.ExecuteScalar();
            con.Close();
            return retVal;
        }

        /// <summary>
        /// Metodo para editar un objetivo general o especifico
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int EditarObjetivo(Objetivo obj)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("EDITAR_OBJETIVO", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter("i_id", obj.Id);
            SqlParameter nombre = new SqlParameter("i_nombre", obj.Nombre);
            SqlParameter valor = new SqlParameter("i_valor", obj.Valor);
            SqlParameter flag = new SqlParameter("i_flag", obj.FlagGeneral);
            SqlParameter cod = new SqlParameter("i_cod", obj.CodGeneral);
            com.Parameters.Add(id);
            com.Parameters.Add(nombre);
            com.Parameters.Add(valor);
            com.Parameters.Add(flag);
            com.Parameters.Add(cod);

            con.Open();
            int retVal = (int)com.ExecuteNonQuery();
            con.Close();
            return retVal;
        }

        public int EliminarObjetivo(string obj_id)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("ELIMINAR_OBJETIVO", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter("i_id", obj_id);
            com.Parameters.Add(id);

            con.Open();
            int retVal = (int)com.ExecuteNonQuery();
            con.Close();
            return retVal;
        }

        private Objetivo CargarObjetivo(SqlDataReader drObjetivos)
        {
            Objetivo obj = new Objetivo();
            obj.Id = drObjetivos.GetInt32(0);
            obj.Nombre = drObjetivos.GetString(1);
            obj.Valor = Convert.ToDouble(drObjetivos.GetDecimal(2));
            if(drObjetivos.GetInt32(3)==1)
                obj.FlagGeneral = true;
            return obj;
        }

        public List<Objetivo> ListarObjetivosGenerales()
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("LISTAR_OBJETIVOS", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();

            SqlDataReader drObjetivos = com.ExecuteReader();
            List<Objetivo> listaObjetivos = new List<Objetivo>();

            while (drObjetivos.Read())
            {
                listaObjetivos.Add(CargarObjetivo(drObjetivos));
            }

            drObjetivos.Close();
            con.Close();
            return listaObjetivos;
        }

        public List<Objetivo> ObtenerObjetivo(int objeId)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("OBTENER_OBJETIVO", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parObjeId = new SqlParameter("i_objeid", objeId);
            com.Parameters.Add(parObjeId);

            con.Open();
            SqlDataReader drObjetivos = com.ExecuteReader();
            List<Objetivo> listaObjetivos = new List<Objetivo>();

            while (drObjetivos.Read())
            {
                listaObjetivos.Add(CargarObjetivo(drObjetivos));
            }

            drObjetivos.Close();
            con.Close();
            return listaObjetivos;
        }

    }
}
