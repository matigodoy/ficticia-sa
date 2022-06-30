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
                cargarDatosModalPersona(int.Parse(hfIDSeleccionado.Value));

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
            if (validarModalPersona())
            {
                if (lblModalTitle.Text == "Modificar persona")
                {
                    PersonaBL.EditarPersona(getPersonaModal());
                    cargarDatosModalPersona(int.Parse(hfIDSeleccionado.Value));
                    MessageBox.Show("Datos moficiados con éxito", "success");
                }
                else if (lblModalTitle.Text == "Agregar persona")
                {
                    hfIDSeleccionado.Value = "0";
                    PersonaBL.CrearPersona(getPersonaModal());
                    MessageBox.Show("Persona agregada con éxito", "success", "Excelente!");
                }
                CargarGrillaPersonas();
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "abrirModal();", true);
            }
        }
        private void cargarDatosModalPersona(int id)
        {
            Persona persona = PersonaBL.ObtenerPersona(id);
            leNombre.Text = persona.Nombre;
            leIdentificacion.Text = persona.Identificacion;
            leEdad.Text = persona.Edad.ToString();
            ddlGenero.SelectedValue = ddlGenero.Items.FindByText(persona.Genero).Value;
            ddlEstado.SelectedValue = ddlEstado.Items.FindByText(persona.Estado).Value;
            if(!String.IsNullOrEmpty(persona.Maneja)) ddlManeja.SelectedValue = ddlManeja.Items.FindByText(persona.Maneja).Value;
            else ddlManeja.SelectedValue = "“-1”";

            if (persona.UsaLentes != "") ddlLentes.SelectedValue = ddlLentes.Items.FindByText(persona.UsaLentes).Value;
            else ddlLentes.SelectedValue = "“-1”";

            if (persona.Diabetico != "") ddlDiabetico.SelectedValue = ddlDiabetico.Items.FindByText(persona.Diabetico).Value;
            else ddlDiabetico.SelectedValue = "“-1”";

            txtEnfermedad.Text = persona.Enfermedad;
        }
        private void limpiarDatosModalPersona()
        {
            leNombre.Text = "";
            leIdentificacion.Text = "";
            leEdad.Text = "";
            ddlGenero.SelectedValue = "“-1”";
            ddlEstado.SelectedValue = "“-1”";
            ddlManeja.SelectedValue = "“-1”";
            ddlLentes.SelectedValue = "“-1”";
            ddlDiabetico.SelectedValue = "“-1”";
            txtEnfermedad.Text = "";
        }
        private Persona getPersonaModal()
        {
            Persona persona = new Persona();
            persona.Id = int.Parse(hfIDSeleccionado.Value);
            persona.Nombre = leNombre.Text ;
            persona.Identificacion = leIdentificacion.Text;
            persona.Edad = int.Parse(leEdad.Text);            
            persona.Genero = ddlGenero.SelectedItem.Text;
            persona.Estado = ddlEstado.SelectedItem.Text;

            if (ddlManeja.SelectedValue == "“-1”") persona.Maneja = "";
            else persona.Maneja = ddlManeja.SelectedItem.Text;

            if (ddlLentes.SelectedValue == "“-1”") persona.UsaLentes = "";
            else persona.UsaLentes = ddlLentes.SelectedItem.Text;

            if (ddlDiabetico.SelectedValue == "“-1”") persona.Diabetico = "";
            else persona.Diabetico = ddlDiabetico.SelectedItem.Text;

            persona.Enfermedad = txtEnfermedad.Text;
            return persona;
        }

        protected void btnModalPersona_Click(object sender, EventArgs e)
        {
            limpiarDatosModalPersona();
            lblModalTitle.Text = "Agregar persona";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "abrirModal();", true);
            upModal.Update();
        }
        private bool validarModalPersona()
        {
            bool resultado = true;

            if (string.IsNullOrEmpty(leNombre.Text))
            {
                leNombre.CssClass = "form-control is-invalid";
                resultado = false;
            }
            else
            {
                leNombre.CssClass = "form-control is-valid";
            }


            if (string.IsNullOrEmpty(leIdentificacion.Text))
            {
                leIdentificacion.CssClass = "form-control is-invalid";
                resultado = false;
            }
            else
            {
                leIdentificacion.CssClass = "form-control is-valid";
            }


            if (string.IsNullOrEmpty(leEdad.Text))
            {
                leEdad.CssClass = "form-control is-invalid";
                resultado = false;
            }
            else if(int.Parse(leEdad.Text) > 0)
            {
                leEdad.CssClass = "form-control is-valid";
                
            }
            else
            {
                leEdad.CssClass = "form-control is-invalid";
                resultado = false;
            }


            if (ddlGenero.SelectedValue == "“-1”")
            {
                ddlGenero.CssClass = "form-select  is-invalid";
                resultado = false;
            }
            else
            {
                ddlGenero.CssClass = "form-select  is-valid";
            }


            if (ddlEstado.SelectedValue == "“-1”")
            {
                ddlEstado.CssClass = "form-select  is-invalid";
                resultado = false;
            }
            else
            {
                ddlEstado.CssClass = "form-select  is-valid";
            }

            return resultado;
        }
    }
}