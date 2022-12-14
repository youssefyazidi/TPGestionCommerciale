using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGestionCommerciale.Data;

namespace TPGestionCommerciale
{
    public partial class FormMAJClients : Form
    {
       List<Client> clients = new List<Client>();
        private DataAccess db;
        int position = 0;
        public FormMAJClients()
        {
            InitializeComponent();
        }

        private void FormMAJClients_Load(object sender, EventArgs e)
        {
            db = new DataAccess();

            //Remplir la liste des clients
            //réaliser la recherche
            string query = "SELECT * FROM CLIENT";

            db.Open();
            SqlDataReader reader = db.executeSELECT(query);
            while (reader.Read())
            {
                clients.Add(new Client()
                {
                    CodeCl= (string)reader[0],
                    Nom = (string)reader[1],
                    Ville = (string)reader[2]
                }); 
        
            }
            reader.Close();
            db.Close();


            //afficher le client position
            afficherClient();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if(textBoxCode.Text.Trim()=="" ||
                textBoxNom.Text.Trim() == "" ||
                textBoxVille.Text.Trim() == "")
            {
                MessageBox.Show("Tous les champs sont oblogatoires!!!");
                return;
            }
            try
            {
                string code = "INSERT INTO CLIENT VALUES ('" + textBoxCode.Text.Trim() + "','" +
                    textBoxNom.Text.Trim() + "','" + textBoxVille.Text.Trim() + "')";
                db.Open();
                db.executeDML(code);
                db.Close();
                MessageBox.Show("Les données sont enregistrées avec succes!!!");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erreur d'acces à la base : "+ex.Message );
                db.Close();
            }
        }

        private void buttonRechrcher_Click(object sender, EventArgs e)
        {
            //Lire le code
            string code = textBoxCodeRecherche.Text.Trim();
            if(code=="")
            {
                MessageBox.Show("Veuillez saisir un code!!");
                return;
            }
            //réaliser la recherche
            string query = "SELECT * FROM CLIENT WHERE CodeCL='"+code+"'";

            db.Open();
            SqlDataReader reader= db.executeSELECT(query);
            if(!reader.Read())
            {
                MessageBox.Show("Le code recherché n'existe plus!!");
                db.Close();
                return;
            }
            //Option 1
            textBoxCode.Text = (string)reader[0];
            textBoxNom.Text = (string)reader[1];
            textBoxVille.Text = (string)reader[2];

            //Activer les boutons
            buttonModifier.Enabled = buttonSupprimer.Enabled = true;
            textBoxCode.Enabled = buttonAjouter.Enabled =false;
            reader.Close();
            //Option 2
         /*   textBoxCode.Text = reader.GetString(0);
            textBoxNom.Text = reader.GetString(1);
            textBoxVille.Text = reader.GetString(2);*/
            db.Close();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Trim() == "" ||
                textBoxVille.Text.Trim() == "")
            {
                MessageBox.Show("Tous les champs sont oblogatoires!!!");
                return;
            }
            try
            {
             string query = 
                    "UPDATE CLIENT SET NOM='"+textBoxNom.Text+"',Ville='"+
                    textBoxVille.Text+"' WHERE CODECL='"+textBoxCode.Text+"'";
                db.Open();
                db.executeDML(query);
                db.Close();
                MessageBox.Show("Les données sont modifiées avec succes!!!");
                //Activer les boutons
                buttonModifier.Enabled = buttonSupprimer.Enabled = false;
                textBoxCode.Enabled = buttonAjouter.Enabled = true;
                textBoxCode.Text = textBoxNom.Text = textBoxVille.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur d'acces à la base : " + ex.Message);
                db.Close();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
          
            try
            {
                string query =
                       "DELETE CLIENT WHERE CODECL='" + textBoxCode.Text + "'";
                db.Open();
                db.executeDML(query);
                db.Close();
                MessageBox.Show("Les données sont supprimées avec succes!!!");
                //Activer les boutons
                buttonModifier.Enabled = buttonSupprimer.Enabled = false;
                textBoxCode.Enabled = buttonAjouter.Enabled = true;
                textBoxCode.Text = textBoxNom.Text = textBoxVille.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur d'acces à la base : " + ex.Message);
                db.Close();
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void afficherClient()
        {
            textBoxCode.Text = clients[position].CodeCl;
            textBoxNom.Text = clients[position].Nom;
            textBoxVille.Text = clients[position].Ville;
        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            position = 0;
            afficherClient();

        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if(position > 0)
            position--;
            afficherClient();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if(position < clients.Count-1)
            position++;
            afficherClient();
        }

        private void buttonDernier_Click(object sender, EventArgs e)
        {
            position = clients.Count - 1;
            afficherClient();


        }
    }
}
