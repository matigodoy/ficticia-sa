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
                lblModalTitle.Text = "Modificar persona";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "abrirModal();", true);
                upModal.Update();
                hfIDSeleccionado.Value = e.CommandArgument.ToString();
            }
            if (e.CommandName.Equals("Eliminar"))
            {
                PersonaBL.EliminarPersona(int.Parse(e.CommandArgument.ToString()));
                CargarGrillaPersonas();
            }
        }

        protected void grvPersonas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void pbAltaPersona_Click(object sender, EventArgs e)
        {

        }

        protected void btnModificarPersona_Click(object sender, EventArgs e)
        {
            
        }
    }
}