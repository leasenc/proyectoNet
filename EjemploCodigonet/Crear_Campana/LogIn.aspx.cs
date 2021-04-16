using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRM.CapaDatos;
using System.Web.Configuration;

namespace Crear_Campana
{
    public partial class LogIn : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string cadena = WebConfigurationManager.ConnectionStrings["CRMConn"].ConnectionString;
            DAOUsuario user = new DAOUsuario(cadena);
            if (user.IniciarSesion(txtUser.Text, txtPass.Text))
            {
                Response.Redirect("Objetivos.aspx");
            }
            else 
            {
                RegisterClientScriptBlock("NombreScript", "<script>alert('Usuario o password invalido');</script>");
            }            
        }
    }
}
