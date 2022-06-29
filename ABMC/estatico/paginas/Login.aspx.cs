using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BusinessLayer;

namespace ABMC.estatico.paginas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Usuario usuario = null;
                try
                {
                    usuario = UsuarioBL.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }     
            }
        }

        private bool validarCampos()
        {
            bool respuesta = false;

            if (!String.IsNullOrEmpty(txtUsername.Text))
            {
                respuesta = true;
            }
            if (!String.IsNullOrEmpty(txtPassword.Text))
            {
                respuesta = true;
            }

            return respuesta;
        }
    }
}