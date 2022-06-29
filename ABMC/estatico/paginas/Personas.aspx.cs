using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BusinessLayer;
using System.Data;

namespace ABMC.estatico.paginas
{
    public partial class Personas : System.Web.UI.Page
    {
        public Usuario user = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usrLoggedIn"] != null) user = (Usuario)Session["usrLoggedIn"];
            else Response.Redirect("Login");

            CargarGrillaPersonas();
        }
        private void CargarGrillaPersonas()
        {
            List<Persona> personas = PersonaBL.ListarPersonas(); 
            grvPersonas.DataSource = personas;
            grvPersonas.DataBind();
        }
        protected void grvPersonas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        protected void grvPersonas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Modificar"))
            {
                
            }
        }

        protected void grvPersonas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}