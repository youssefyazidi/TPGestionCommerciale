using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionCommerciale.Data
{
    public class DataAccess
    {
        private string connString = 
            @"Data Source=.\SQLEXPRESS;
                Initial Catalog=Vente;
                Integrated Security=true";

        private SqlConnection connexion; 
        private SqlCommand commande;
        
        //Constructeur par defaut
        public DataAccess()
        {
            //Initialisation
            connexion = new SqlConnection(connString);
            commande = new SqlCommand();
            commande.Connection = connexion;
        }         

        //Executer les DML
        public int executeDML(string codeSQL)
        {
            commande.CommandText = codeSQL;
            int rows= commande.ExecuteNonQuery();
            return rows;
        }

        //Executer les SELECT
        public  SqlDataReader executeSELECT(string codeSQL)
        {
            commande.CommandText = codeSQL;

            SqlDataReader reader=commande.ExecuteReader();
            //avant de fermer la connexion 
            //il faut consommer le resultat 
            return reader;
        }

        //Executer les SELECT avec une seule valeur resultat
        public object executeScalar(string codeSQL)
        {
            commande.CommandText = codeSQL;

            object value = commande.ExecuteScalar();
            //avant de fermer la connexion 
            //il faut consommer le resultat 
            return value;
        }

        //Ouvrir la connexion
        public void Open()
        {
            connexion.Open();
        }

        //Fermer la connexion
        public void Close()
        {
            connexion.Close();
        }

    }
}
