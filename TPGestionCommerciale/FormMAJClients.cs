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
        private DataAccess db;
        public FormMAJClients()
        {
            InitializeComponent();
        }

        private void FormMAJClients_Load(object sender, EventArgs e)
        {
            db = new DataAccess();
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

       
    }
}
