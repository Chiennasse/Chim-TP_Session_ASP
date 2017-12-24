using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Session___CHIM
{
    public partial class When : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb_date_choisie.Visible = true;  //N'est pas visible par défaut

            //Test si on n'est pas dans un postback
            if(!IsPostBack)
            {
                //Test si le cookie existe déjà
                if (Request.Cookies["Calendrier"] != null)
                {
                    //Si oui, on met la date choisie dans le calendrier
                    cal.SelectedDate = Convert.ToDateTime(Request.Cookies["Calendrier"].Value);
                    //On l'affiche aussi dans le label
                    lb_date_choisie.Text += Convert.ToString(Request.Cookies["Calendrier"].Value);

                    lb_instru_Cal.Visible = false;  //Rends le label d'information invisible
                    lb_date_choisie.Visible = true; //Et affiche celui qui contient la date de l'utilisateur
                }
            }
        }
        //Gère l'évènement lorsque l'utilisateur appuie sur le bouton pour soumettre sa date 
        protected void bt_date_Click(object sender, EventArgs e)
        {
            //Stock l'information dans notre cookie
            Response.Cookies["Calendrier"].Value = cal.SelectedDate.ToString();
            Response.Cookies["Calendrier"].Expires = DateTime.MaxValue;     //Expiration du cookie
        }
    }
}