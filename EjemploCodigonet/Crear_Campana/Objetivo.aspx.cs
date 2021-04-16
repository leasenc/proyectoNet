using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using CRM.CapaDatos;
using CRM.Objetos;

namespace CrearObjetivos
{
    public partial class CrearObj : System.Web.UI.Page
    {
        string cadena = WebConfigurationManager.ConnectionStrings["CRMConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request["var"] != null)
                {
                    DAOObjetivo obj = new DAOObjetivo(cadena);
                    List<Objetivo> listaObjetivo = obj.ObtenerObjetivo(Convert.ToInt32(Request["var"]));
                    CargarObjetivo(listaObjetivo);
                    Session["objetivo"] = Request["var"];
                }
                else 
                {
                    Session["objetivo"] = null;
                }
            }
        }

        private void CargarTextos(TextBox txtNom, TextBox txtVal, Objetivo objetivo, int order)
        {
            string idKey = "KEY" + order.ToString();
            ViewState[idKey] = objetivo.Id;
            txtNom.Text = objetivo.Nombre.ToString();
            txtVal.Text = objetivo.Valor.ToString();
        }

        private void CargarObjetivo(List<Objetivo> listaObjetivo)
        {
            if (listaObjetivo != null)
            {                
                for (int i = 0; i < listaObjetivo.Count; i++)
                {
                    Objetivo objetivo = listaObjetivo[i];

                    if (objetivo.FlagGeneral)
                    {
                        CargarTextos(txtGeneral, txtValor, objetivo, 0);
                    }
                    else 
                    {
                        if (txtEspecifico1.Text == string.Empty)
                        {
                            CargarTextos(txtEspecifico1, txtValor1, objetivo, 1);
                            continue;
                        }

                        if (txtEspecifico2.Text == string.Empty)
                        {
                            CargarTextos(txtEspecifico2, txtValor2, objetivo, 2);
                            continue;
                        }

                        if (txtEspecifico3.Text == string.Empty)
                        {
                            CargarTextos(txtEspecifico3, txtValor3, objetivo, 3);
                            continue;
                        }
                    }
                    
                }
            }
        }

        private int CrearObjetivo(string nombre, string valor, int codGeneral, bool esGeneral, int order)
        {            
            Objetivo esp = new Objetivo();
            esp.Nombre = nombre;
            esp.Valor = Convert.ToDouble(valor);
            esp.FlagGeneral = esGeneral;
            if (!esGeneral)
            {
                esp.CodGeneral = codGeneral;
            }

            DAOObjetivo obj = new DAOObjetivo(cadena);
            if (Session["objetivo"] != null)
            {
                int idObjetivo = Convert.ToInt32(Session["objetivo"]);
                if (esGeneral)
                    esp.Id = idObjetivo;
                else
                {
                    string idKey = "KEY" + order.ToString();
                    esp.Id = Convert.ToInt32(ViewState[idKey]);
                }

                obj.EditarObjetivo(esp);
                return idObjetivo;
            }
            else
            {
                esp.Id = codGeneral;
                return obj.CrearObjetivo(esp);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Adicion del objetivo general
            int idGeneral = CrearObjetivo(txtGeneral.Text, txtValor.Text, -1, true, 0);
            
            //Especificos
            CrearObjetivo(txtEspecifico1.Text, txtValor1.Text, idGeneral, false, 1);

            if (txtEspecifico2.Text != string.Empty && txtValor2.Text != string.Empty)
            {
                CrearObjetivo(txtEspecifico2.Text, txtValor2.Text, idGeneral, false, 2);
            }

            if (txtEspecifico3.Text != string.Empty && txtValor3.Text != string.Empty)
            {
                CrearObjetivo(txtEspecifico3.Text, txtValor3.Text, idGeneral, false, 3);
            }

            Session["objetivo"] = null;
            Response.Redirect("Main.aspx");    
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Objetivos.aspx");
        }

    }
}
