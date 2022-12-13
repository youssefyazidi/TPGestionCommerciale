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
    public partial class FormCommande : Form
    {
        private DataAccess db;
        private DataTable tableClients;
        private DataTable tableArticles;
        private DataTable tableLignes;
        public FormCommande()
        {
            InitializeComponent();
        }

        private void FormCommande_Load(object sender, EventArgs e)
        {
            //Initialisation du Form
            db = new DataAccess();

            //Remplir la liste des codes client
            Remplir_Liste_Clients();
            //Remplir la liste des codes d'articles
            Remplir_Liste_Articles();

            //Obtenir le dernier num de commande
            string query = "SELECT MAX(Numcom) FROM Commande";

            try
            {
                db.Open();
                object value = db.executeScalar(query);
                textBoxNCommande.Text = ((int)value + 1).ToString();
                db.Close();
            }
            catch (Exception)
            {
                textBoxNCommande.Text = "1";
                db.Close();
            }

            //Initialisation du datatable ligne
            //Créer la structure
            tableLignes = new DataTable();

            DataColumn col1 = new DataColumn("CodeArticle");
            DataColumn col2 = new DataColumn("Designation");
            DataColumn col3 = new DataColumn("Prix Unitaire");
            DataColumn col4 = new DataColumn("Quantite");
            DataColumn col5 = new DataColumn("Montant");
            tableLignes.Columns.Add(col1);
            tableLignes.Columns.Add(col2);
            tableLignes.Columns.Add(col3);
            tableLignes.Columns.Add(col4);
            tableLignes.Columns.Add(col5);

            GrilleLignesCommande.DataSource = tableLignes;

        }


        private void Remplir_Liste_Clients()
        {
            string query = "SELECT * FROM Client";

            db.Open();
            SqlDataReader reader= db.executeSELECT(query);
            tableClients = new DataTable();
            tableClients.Load(reader);
            db.Close();

            //Liaison direct du combo avec le Datatable
            comboBoxCodeClient.DataSource = tableClients;
            comboBoxCodeClient.DisplayMember = "CodeCl";
            comboBoxCodeClient.ValueMember = "CodeCl";
        }

        private void Remplir_Liste_Articles()
        {
            string query = "SELECT * FROM Article";

            db.Open();
            SqlDataReader reader = db.executeSELECT(query);
            tableArticles = new DataTable();
            tableArticles.Load(reader);
            db.Close();

            //Liaison direct du combo avec le Datatable
            comboBoxArticle.DataSource = tableArticles;
            comboBoxArticle.DisplayMember = "CodeArt";
        }

        private void comboBoxCodeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelectionne = comboBoxCodeClient.SelectedIndex;
            // MessageBox.Show("Test "+indiceSelectionne);
            //Recuperer la ligne numero indiceSelectionnee 
            // a partir de la table
            DataRow row = tableClients.Rows[indiceSelectionne];

            textBoxNom.Text = row["Nom"].ToString();
            textBoxVille.Text = row["Ville"].ToString();

        }

        private void comboBoxArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelectionne = comboBoxArticle.SelectedIndex;
            // MessageBox.Show("Test "+indiceSelectionne);
            //Recuperer la ligne numero indiceSelectionnee 
            // a partir de la table
            DataRow row = tableArticles.Rows[indiceSelectionne];

            textBoxDesignation.Text = row["Designation"].ToString();
            textBoxPrix.Text = row["PU"].ToString();
        }

        private void buttonAjouterLigne_Click(object sender, EventArgs e)
        {
            //Créer une nouvelle ligne de type tableligne row
            DataRow newRow = tableLignes.NewRow();
            newRow["CodeArticle"] =
                tableArticles.Rows[comboBoxArticle.SelectedIndex]["CodeArt"];
            newRow["Designation"] = 
                tableArticles.Rows[comboBoxArticle.SelectedIndex]["Designation"];
            newRow["Prix Unitaire"] =
                tableArticles.Rows[comboBoxArticle.SelectedIndex]["PU"];
            newRow["Quantite"] =
               textBoxQuantite.Text;
            newRow["Montant"] = 
                Convert.ToDouble(textBoxPrix.Text) * 
                Convert.ToInt32(textBoxQuantite.Text);

            tableLignes.Rows.Add(newRow);
        }

        private void buttonEnregistrerCommande_Click(object sender, EventArgs e)
        {
            string query1="INSERT INTO COMMANDE VALUES ('"
                +dateTimePickerDateCommande.Value.ToShortDateString()+"','"
                + tableClients.Rows[comboBoxCodeClient.SelectedIndex]["CodeCl"]
                +"')";

            string query2 = "";
            foreach(DataRow row in tableLignes.Rows)
            {
                query2 += "INSERT INTO DETAIL VALUES (" +
                    textBoxNCommande.Text + "," +
                    row["CodeArticle"] + "," +
                    row["Quantite"] + ");";
            }

          /*  MessageBox.Show(query1);
            MessageBox.Show(query2);*/

            db.Open();
            db.executeDML(query1);
            db.executeDML(query2);
            MessageBox.Show(" Commande Sauvegardée");
            db.Close();
        }
    }
}
