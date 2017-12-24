using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP_Session___CHIM
{
    public partial class Marque : System.Web.UI.Page
    {
        int x;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Test si ce n'est pas un PostBack
            if(!IsPostBack)
            {
                x = 0;

                //On compte le nombre de champ dans la table, pour avoir un ID qui se suit lors de l'ajout
                for (int y = 0; y < gv.PageCount; y++)
                {
                    for(int z = 0; z < gv.Rows.Count; z++)
                    {
                        x += 1;
                    }
                }
            }
        }

        //Gère l'évènement lorsque l'uager appuie sur le bouton d'ajout
        protected void bt_add_Click(object sender, EventArgs e)
        {
            //Instancie une connexion à la BD
            using (SqlConnection conx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Giroux.mdf;Integrated Security=True"))
            {
                conx.Open();    //Ouverture de la connexion

                //Création de la commande d'ajout SQL
                SqlCommand cmd = new SqlCommand("INSERT into [Marque] (ID, Marque, Brasseur, Pourcentage) VALUES (@ID, @Marque, @Brasseur, @Pourcentage)");

                cmd.Connection = conx;      //Affecte la commande à notre connexion

                //On ajoute nos paramètres à notre commande
                cmd.Parameters.AddWithValue("ID", x);
                cmd.Parameters.AddWithValue("Marque", tb_addnom.Text);
                cmd.Parameters.AddWithValue("Brasseur", tb_brasseur.Text);
                cmd.Parameters.AddWithValue("Pourcentage", tb_pour.Text);

                cmd.ExecuteNonQuery();      //Exécution de la commande
                conx.Close();               //Fermeture de la connexion
                conx.Dispose();             //Destruction de l'instance de la connexion
            }
        }
    }
}