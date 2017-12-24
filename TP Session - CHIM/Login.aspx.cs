using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Session___CHIM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //On vérifie si le cookie existe chez l'utilisateur
            if (Request.Cookies["Login"] != null)
            {
                //S'il existe - L'utilisateur est "logué" - On redirige vers la page d'acceuil.
                Response.Redirect("Acceuil.aspx");
            }
        }


        //Gère l'évènement lorsque l'usager appuie sur le bouton de connexion
        protected void bt_login_Click(object sender, EventArgs e)
        {
            //Enregistre les informations du client dans un cookie
            Response.Cookies["Login"]["Nom"] = tb_nom.Text;
            Response.Cookies["Login"]["Mail"] = tb_mail.Text;

            //Assigne une date d'expiration pour le cookie
            Response.Cookies["Login"].Expires = DateTime.MaxValue; //Techniquement, il n'expireras jamais.
            Response.Redirect("Acceuil.aspx"); //Redirige ensuite l'utilisateur à la page d'acceuil
        }
    }
}