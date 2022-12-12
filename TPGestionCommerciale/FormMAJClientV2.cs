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
    public partial class FormMAJClientV2 : Form
    {
        private DataAccess db;

        //Liaison de données
        BindingSource binding = new BindingSource();

        public FormMAJClientV2()
        {
            InitializeComponent();
        }

        private void FormMAJClientV2_Load(object sender, EventArgs e)
        {
            db = new DataAccess();

            //Remplir la liste des clients
            //réaliser la recherche
            string query = "SELECT * FROM CLIENT";

            db.Open();
            SqlDataReader reader = db.executeSELECT(query);

            DataTable table = new DataTable();
            table.Load(reader);
            db.Close();

            //Initialiser la liaison de données
            //les données
            binding.DataSource = table;

            //les champs (interface)
            textBoxCode.DataBindings.Add("Text", binding, "CodeCL");

            textBoxNom.DataBindings.Add("Text", binding, "Nom");

            textBoxVille.DataBindings.Add("Text", binding, "Ville");

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
