using ChurchSolution.ClassConnexion;
using ChurchSolution.ClasseFonction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.ClasseTraitement
{
    class ClsPredicateur
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public IDataReader dr = null;
        //public SqlDataAdapter datApt;
        public DataSet daset = null;
        public SqlDataAdapter dp;
        public DataSet dst = null;
        ClsConnexion cnx = new ClsConnexion();
        Clsfonctions fx = new Clsfonctions();
        static ClsMembreInsertion dao;
        public static ClsMembreInsertion GetInstance()
        {
            if (dao == null)
                dao = new ClsMembreInsertion();
            return dao;
        }
        public void InitialiserConnexion()
        {
            try
            {
                cnx.connect();
                conn = new SqlConnection(cnx.chemin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string Nom_pre(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from preducateur where nom_complet='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["nom_complet"].ToString());

                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
        }
        public string Code_pre(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from preducateur where nom_complet='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["code"].ToString());

                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
        }
        public string Code_moder(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from MODERATUER where NOM_COMPLET='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["code"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Phone(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from MODERATUER where NOM_COMPLET='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["phone"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }

    }
}
