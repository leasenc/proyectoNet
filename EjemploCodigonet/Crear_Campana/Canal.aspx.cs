using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using CRM.CapaDatos;
using CRM.Objetos;
//Crear Canal

namespace Canales_CRM
{
    public partial class CrearCanal : System.Web.UI.Page
    {
        string cadena = WebConfigurationManager.ConnectionStrings["CRMConn"].ConnectionString;        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DAOCanal can = new DAOCanal(cadena);
                DAOUsuario usuario = new DAOUsuario(cadena);
                List<Usuario> listaUsuarios = new List<Usuario>();
                
                listaUsuarios = usuario.ListarUsuarios();
                ddlResponsable.DataSource = listaUsuarios;
                ddlResponsable.DataTextField = "Nombre";
                ddlResponsable.DataValueField = "Id";
                ddlResponsable.DataBind();      
          
                ddlBackupResponsable.DataSource = listaUsuarios;
                ddlBackupResponsable.DataTextField = "Nombre";
                ddlBackupResponsable.DataValueField = "Id";
                ddlBackupResponsable.DataBind();
                //List<Canal> listaCanales = can.ListarCanales();
                //CargarCanales();
            }
        }

        private void CargarTextos(TextBox txtNom, TextBox txtVal, Canal canales)
        {
            txtNom.Text = canales.Nombre.ToString();
        }

        private void CargarCanal(List<Canal> listaCanales)
        {
            if (listaCanales != null)
            {
                for (int i = 0; i < listaCanales.Count; i++)
                {

                }

            }
        }

        protected void Cancel_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Objetivos.aspx");
        }
    }
}