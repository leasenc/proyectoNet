using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using CRM.CapaDatos;

namespace Crear_Campana
{
    public partial class _Default : System.Web.UI.Page
    {
        string cadena = WebConfigurationManager.ConnectionStrings["CRMConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {                
                DAOObjetivo obj = new DAOObjetivo(cadena);
                ddlObjetivos.DataSource = obj.ListarObjetivosGenerales();
                ddlObjetivos.DataTextField = "Nombre";
                ddlObjetivos.DataValueField = "Id";
                ddlObjetivos.DataBind();

                DAOCanal can = new DAOCanal(cadena);
                ddlCanales.DataSource = can.ListarCanales();
                ddlCanales.DataTextField = "Nombre";
                ddlCanales.DataValueField = "Id";
                ddlCanales.DataBind();
            }
        }

        protected void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar
        }
    }
}
