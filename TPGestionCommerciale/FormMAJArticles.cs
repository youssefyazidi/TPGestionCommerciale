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
    public partial class FormMAJArticles : Form
    {
        private DataAccess db;

        private BindingSource binding;
        public FormMAJArticles()
        {
            InitializeComponent();
        }

        private void FormMAJArticles_Load(object sender, EventArgs e)
        {
            db = new DataAccess();

            //Laiason de données
            binding = new BindingSource();

            initialiserBinding();

            //Les DataBindings

            textBoxCode.DataBindings.Add("Text", binding, "CodeArt");
            textBoxDesignation.DataBindings.Add("Text", binding, "Designation");
            textBoxPrixUnitaire.DataBindings.Add("Text", binding, "PU");
            textBoxStock.DataBindings.Add("Text", binding, "Qstock");

        }

        private void  initialiserBinding()
        {

           string query = "SELECT * FROM Article";

            db.Open();
            SqlDataReader reader = db.executeSELECT(query);

            DataTable table = new DataTable();
            table.Load(reader);
            db.Close();

            binding.DataSource = table;
        }
     private void buttonAjouter_Click(object sender, EventArgs e)
        {
          if (textBoxDesignation.Text.Trim() == "" ||
                textBoxPrixUnitaire.Text.Trim() == "" ||
                textBoxStock.Text.Trim()==""
                )
            {
                MessageBox.Show("Tous les champs sont oblogatoires!!!");
                return;
            }
            try
            {
     string code = "INSERT INTO Article VALUES ('" +
          textBoxDesignation.Text.Trim() + "'," + 
          textBoxPrixUnitaire.Text.Trim() + ","+
          textBoxStock.Text.Trim()+")";

                db.Open();
                db.executeDML(code);
                db.Close();

                MessageBox.Show("Les données sont enregistrées avec succes!!!");
                initialiserBinding();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur d'acces à la base : " + ex.Message);
                db.Close();
            }
        }

        private void buttonRechrcher_Click(object sender, EventArgs e)
        {
            //Lire le code
            string code = textBoxCodeRecherche.Text.Trim();
            if (code == "")
            {
                MessageBox.Show("Veuillez saisir un code!!");
                return;
            }
            //réaliser la recherche
            string query = "SELECT * FROM Article WHERE CodeArt='" + code + "'";

            db.Open();
            SqlDataReader reader = db.executeSELECT(query);
            if (!reader.Read())
            {
                MessageBox.Show("Le code recherché n'existe plus!!");
                db.Close();
                return;
            }
            //Option 1
            textBoxCode.Text = ((int)reader[0]).ToString();
            textBoxDesignation.Text = (string)reader[1];
           // MessageBox.Show("Test "+ reader[2].GetType());
            textBoxPrixUnitaire.Text = ((double)reader[2]).ToString();
            textBoxStock.Text = ((int)reader[3]).ToString();

            //Activer les boutons
            buttonModifier.Enabled = buttonSupprimer.Enabled = true;
            textBoxCode.Enabled = buttonAjouter.Enabled = false;
            reader.Close();
            //Option 2
            /*   textBoxCode.Text = reader.GetString(0);
               textBoxNom.Text = reader.GetString(1);
               textBoxVille.Text = reader.GetString(2);*/
            db.Close();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxDesignation.Text.Trim() == "" ||
              textBoxPrixUnitaire.Text.Trim() == "" || textBoxStock.Text.Trim() == "")
            {
                MessageBox.Show("Tous les champs sont oblogatoires!!!");
                return;
            }
            try
            {
                string query =
                       "UPDATE Article SET Designation='" + textBoxDesignation.Text 
                       + "',PU=" +textBoxPrixUnitaire.Text
                       + ",QStock="+textBoxStock.Text 
                       + " WHERE CODEArt='" + textBoxCode.Text + "'";

                db.Open();
                db.executeDML(query);
                db.Close();
                MessageBox.Show("Les données sont modifiées avec succes!!!");
                initialiserBinding();
                //Activer les boutons
                buttonModifier.Enabled = buttonSupprimer.Enabled = false;
                buttonAjouter.Enabled = true;
                
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
                       "DELETE Article WHERE CODEArt='" + textBoxCode.Text + "'";
                db.Open();
                db.executeDML(query);
                db.Close();
                MessageBox.Show("Les données sont supprimées avec succes!!!");
                initialiserBinding();
                
                //Activer les boutons
                buttonModifier.Enabled = buttonSupprimer.Enabled = false;
                textBoxCode.Enabled = buttonAjouter.Enabled = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur d'acces à la base : " + ex.Message);
                db.Close();
            }
        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            binding.MoveFirst();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            binding.MovePrevious();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            binding.MoveNext();
        }

        private void buttonDernier_Click(object sender, EventArgs e)
        {
            binding.MoveLast();
        }
    }
}
