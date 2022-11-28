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
    public partial class FormClientsParVille : Form
    {
        private bool charger = false;
        private DataAccess db;
        public FormClientsParVille()
        {
            InitializeComponent();
        }

        private void FormClientsParVille_Load(object sender, EventArgs e)
        {
            //Initialisation
            db = new DataAccess();

            string codeSql = "SELECT DISTINCT Ville FROM CLIENT";
            db.Open();
           SqlDataReader reader= db.executeSELECT(codeSql);

            DataTable table = new DataTable();
            table.Load(reader);

            db.Close();

            comboBoxVilles.DataSource = table;
            comboBoxVilles.DisplayMember = "Ville";

            //le chargement de la fenetre est terminé
            charger = true;

          }

        private void comboBoxVilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charger)
            {
                string nomVille = comboBoxVilles.Text;
                string codeSql = 
                    "SELECT CodeCl,Nom,Ville FROM CLIENT WHERE Ville='"+
                            nomVille+"'";
                db.Open();
                SqlDataReader reader = 
                    db.executeSELECT(codeSql);

                DataTable table = new DataTable();
                table.Load(reader);
                db.Close();

                dataGridViewClients.DataSource = table;
            }
        }
    }
}
