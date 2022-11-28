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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Construction de l'objet DataAccess
            DataAccess dataaccess = new DataAccess();

            string codeSQL = "SELECT Nom,Ville FROM CLIENT";

            dataaccess.Open();
            SqlDataReader reader= dataaccess.executeSELECT(codeSQL);
            //Utiliser le type DataTable
            // Un Objet DataTable  = represente une Table SQL
            DataTable table = new DataTable();

            //Structure le Datatable selon le resultat de la requete
            table.Load(reader);
        
            //On peut associer un DataTable à un controle (List)
            //Liaison de données 
            listBoxNomsClients.DataSource = table;
            listBoxNomsClients.DisplayMember = "Nom";

        }
    }
}
