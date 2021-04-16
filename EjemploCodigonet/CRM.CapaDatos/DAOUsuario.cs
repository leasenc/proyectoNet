using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CRM.Objetos;

namespace CRM.CapaDatos
{
    public class DAOUsuario
    {
        string cadenaConexion = string.Empty;

        public DAOUsuario(string cadena)
        {
            cadenaConexion = cadena;
        }

        public List<Usuario> ListarUsuarios()
        {            
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("LISTAR_USUARIOS", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();

            SqlDataReader drUsuarios = com.ExecuteReader();
            List<Usuario> listaUsuarios = new List<Usuario>();

            while (drUsuarios.Read())
            {
                listaUsuarios.Add(CargarUsuario(drUsuarios));
            }

            drUsuarios.Close();
            con.Close();
            return listaUsuarios;
        }

        private Usuario CargarUsuario(SqlDataReader drUsuarios)
        {
            Usuario obj = new Usuario();
            obj.Id = drUsuarios.GetInt32(0);
            obj.Nombre = drUsuarios.GetString(1);
            obj.Password = drUsuarios.GetString(2);
            return obj;
        }

        public bool IniciarSesion(string usuario, string password)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("INICIAR_SESION", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter userName = new SqlParameter("i_username", usuario);
            SqlParameter userPass = new SqlParameter("i_userpass", password);
            com.Parameters.Add(userName);
            com.Parameters.Add(userPass);

            con.Open();
            bool retVal = false;
            SqlDataReader dr = com.ExecuteReader();            

            if (dr != null && dr.Read())
            {
                dr.Close();
                retVal = true;
            }

            con.Close();
            return retVal;
        }
    }
}
