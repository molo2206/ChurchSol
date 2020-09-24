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
    class logine
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
        private void SetParametre(IDbCommand cmd, string name, DbType type, int length, object valeurname)
        {
            //Déclaration et la création de l'objet parametre sur l'objet commande
            IDbDataParameter param = cmd.CreateParameter();
            //Affectation du nom de parametre sur la variable parametre créée
            param.ParameterName = name;
            //Affectation de la longueur du parametre
            param.Size = length;
            //Affectation de type de données au parametre créé
            param.DbType = type;
            if (valeurname == null)
            {
                param.DbType = DbType.String;
                param.Value = DBNull.Value;
            }
            else
                param.Value = valeurname;
            cmd.Parameters.Add(param);
        }
        string date = DateTime.Now.Date.ToString("dd/MM/yyyy");
        public bool login(ClsLogin log)
        {
            ComboBox com = new ComboBox();
            
            bool test = false;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT * from v_utilisateur where Nom_Utilisateur='" + log.NomUser + "' and CONVERT(varchar(25),deCRYPTBYPASSPHRASE('tdi202',Mot_passe))='" + log.Pwd + "' and CONVERT(date, DATE_EXP, 103) >= CONVERT(date,'"+date+"', 103) ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {               
                        log.IdAgent = dr["Code_Agent"].ToString();
                        log.NomUser = dr["Nom_Utilisateur"].ToString();
                        log.Niveau1 = int.Parse(dr["NIVEAU"].ToString());
                        log.Fonction1 = dr["Fonction"].ToString();
                        log.Code = dr["code"].ToString();
                        log.Menu=(dr["Menu"].ToString());
                    test = true;
                }
                else
                {
                    test = false;
                }
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
            return test;
        }
    }
}
