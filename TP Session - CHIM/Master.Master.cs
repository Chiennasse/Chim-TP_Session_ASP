using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Session___CHIM
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Gère l'évènement lorsque l'utilisateur appuie sur le logo
        protected void logo_Click(object sender, ImageClickEventArgs e)
        {
            //Ramène à la page de Login, qui redirige vers la page d'acceuil
            Response.Redirect("Login.aspx");
        }

        //Gère l'évènement lorsque l'utilisateur appuie sur le logo du Cégep
        protected void logoCeg_Click(object sender, ImageClickEventArgs e)
        {
            //Lien vers l'extérieur
            Response.Redirect("http://www.cegepsi.ca/");
        }

        //Gère l'évènement lorsque l'utilisateur appuie sur le lien hypertext
        protected void lbDepartement_Click(object sender, EventArgs e)
        {
            //Lien vers l'extérieur
            Response.Redirect("http://programmes.cegep-sept-iles.qc.ca/techniques/informatique");
        }


        //Gère l'évènement lorsque l'utilisateur appuie sur le bouton Histoire
        protected void bt_histoire_Click(object sender, ImageClickEventArgs e)
        {
            //Lien vers l'extérieur
            Response.Redirect("Histoire.aspx");
        }

        //Gère l'évènement lorsque l'utilisateur appuie sur le bouton Marque
        protected void bt_marque_Click(object sender, ImageClickEventArgs e)
        {
            //Lien vers l'extérieur
            Response.Redirect("Marque.aspx");
        }

        //Gère l'évènement lorsque l'utilisateur appuie sur le bouton Quand
        protected void bt_quand_Click(object sender, ImageClickEventArgs e)
        {
            //Lien vers l'extérieur
            Response.Redirect("When.aspx");
        }

        //Gère l'évènement lorsque l'utilisateur appuie sur le bouton Matériel d'ivresse
        protected void bt_brosse_Click(object sender, ImageClickEventArgs e)
        {
            //Lien vers l'extérieur
            Response.Redirect("Ivresse.aspx");
        }
    }
}