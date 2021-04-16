using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using CRM.CapaDatos;
using System.Data;

namespace Crear_Campana
{
    public partial class Objetivos : System.Web.UI.Page
    {
        string cadena = WebConfigurationManager.ConnectionStrings["CRMConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Cargamos el listado de Objetivos                
                DAOObjetivo obj = new DAOObjetivo(cadena);
                grvObjetivos.DataSource = obj.ListarObjetivosGenerales();
                grvObjetivos.DataBind(); 
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DAOObjetivo obj = new DAOObjetivo(cadena);

            foreach (GridViewRow gvr in grvObjetivos.Rows)
            {
                CheckBox chbTemp = (CheckBox)gvr.FindControl("chbDelete");
                if (chbTemp.Checked)
                {
                    //Se elimina y recarga
                    obj.EliminarObjetivo(gvr.Cells[0].Text);
                }
            }

            grvObjetivos.DataSource = obj.ListarObjetivosGenerales();
            grvObjetivos.DataBind(); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Objetivo.aspx");
        }


    }
}
