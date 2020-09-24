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
    class ClsAgentInsertion
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
        public string TestCodeAgent(string nom)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[TestCodeAgent]('" + nom + "') as val ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["val"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;
        }

        public string CodeAgent()
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[CodeAgent]() as code ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["code"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;

        }
        public string BarcodeAgent()
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[BarcodeAgent]() as Barcode ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Barcode"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;

        }
        public string Code_agent(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select code from agent where nom_complet='" + rech + "'", conn);
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
        public string Code_bare(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from agent where nom_complet='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["barcode"].ToString());

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
        public string NomAgent(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select nom_complet from agent where nom_complet='" + rech + "'", conn);
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
        public string SexeAgent(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select sexe from agent where nom_complet='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["sexe"].ToString());

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
        public string MailAgent(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select email from Agent where nom_complet='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["email"].ToString());

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
        public string PhoneAgent(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select phone from agent where nom_complet='" + rech + "'", conn);
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
        }
        public string fonction(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from [V_Agent] where NOM_COMPLET='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["Fonction"].ToString());
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
        ClsMembre pt = new ClsMembre();
        public void InsertionUpdateDeleteAgent(ClsMembre pt, int choix)
        {
            try
            {
                InitialiserConnexion();

                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = conn.CreateCommand();
                switch (choix)
                {
                    case 1:
                        cmd.CommandText = "insert into Agent values (@code,@nom,@mail,@phone,@photo,@barcode,@sexe,@dateAdd,null,@Code_Fonction) ";
                        SetParametre(cmd, "@code", DbType.String, 50, pt.Code_Agent.ToUpper());
                        SetParametre(cmd, "@nom", DbType.String, 50, pt.Nom.ToUpper());
                        SetParametre(cmd, "@mail", DbType.String, 50, pt.Mail.ToUpper());
                        SetParametre(cmd, "@phone", DbType.String, 50, pt.Phone.ToUpper());
                        if (pt.Photo != null)
                            SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, pt.Photo);
                        else
                            SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        SetParametre(cmd, "@barcode", DbType.Int32, 50, pt.Barcode);
                        SetParametre(cmd, "@sexe", DbType.String, 50, pt.Sexe.ToUpper());
                        SetParametre(cmd, "@dateAdd", DbType.String, 50, pt.Date);
                        SetParametre(cmd, "@Code_Fonction", DbType.String, 50, pt.Code_fonction);
                        cmd.ExecuteNonQuery();
                        fx.Messages(1);
                        break;
                    case 2:
                        cmd.CommandText = "update Agent set nom_complet=@nom,phone=@phone,photo=@photo,email=@mail,sexe=@sexe,date_modif=@date_modif,Code_Fonction=@Code_Fonction where code=@code";
                        SetParametre(cmd, "@code", DbType.String, 50, pt.Code_Agent.ToUpper());
                        SetParametre(cmd, "@nom", DbType.String, 50, pt.Nom.ToUpper());
                        SetParametre(cmd, "@mail", DbType.String, 50, pt.Mail.ToUpper());
                        SetParametre(cmd, "@phone", DbType.String, 50, pt.Phone.ToUpper());
                        if (pt.Photo != null)
                            SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, pt.Photo);
                        else
                            SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        SetParametre(cmd, "@barcode", DbType.Int32, 50, pt.Barcode);
                        SetParametre(cmd, "@sexe", DbType.String, 50, pt.Sexe.ToUpper());
                        SetParametre(cmd, "@date_modif", DbType.String, 50, pt.Date.ToUpper());
                        SetParametre(cmd, "@Code_Fonction", DbType.String, 50, pt.Code_fonction);
                        cmd.ExecuteNonQuery();
                        fx.Messages(1);
                        break;
                    case 3:
                        cmd.CommandText = "delete from Membre where Id_Memb=@id";
                        MessageBox.Show("Suppression reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd.ExecuteNonQuery();
                        fx.Messages(1);
                        break;
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

    }
}
