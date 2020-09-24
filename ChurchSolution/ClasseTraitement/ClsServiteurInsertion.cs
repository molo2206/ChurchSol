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
    class ClsServiteurInsertion
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
        ClsMembre pt = new ClsMembre();
        public void InsertionUpdateDeleteServiteur(ClsMembre pt, int choix)
        {
            try
            {
                InitialiserConnexion();

                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = conn.CreateCommand();
                switch (choix)
                {
                    case 1:
                        cmd.CommandText = "insert into Serviteur values (@code,@nom,@sexe,@adresse,@etatcivil,@phone,@photo,@mail,@cellule,@ministere,@dateadd,null) ";
                        SetParametre(cmd, "@code", DbType.String, 50, pt.Code_Servi.ToUpper());
                        SetParametre(cmd, "@nom", DbType.String, 50, pt.Nom.ToUpper());
                        SetParametre(cmd, "@sexe", DbType.String, 50, pt.Sexe.ToUpper());
                        SetParametre(cmd, "@Adresse", DbType.String, 50, pt.Adresse.ToUpper());
                        SetParametre(cmd, "@etatcivil", DbType.String, 50, pt.EtaCivil.ToUpper());
                        SetParametre(cmd, "@phone", DbType.String, 50, pt.Phone.ToUpper());
                        if (pt.Photo != null)
                            SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, pt.Photo);
                        else
                            SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        SetParametre(cmd, "@mail", DbType.String, 50, pt.Mail.ToUpper());
                        SetParametre(cmd, "@cellule", DbType.String, 50, pt.Cellule.ToUpper());
                        SetParametre(cmd, "@ministere", DbType.String, 50, pt.Ministere.ToUpper());
                        SetParametre(cmd, "@dateadd", DbType.String, 50, pt.Date.ToUpper());
                        cmd.ExecuteNonQuery();
                        fx.Messages(1);
                        break;
                    case 2:
                        cmd.CommandText = "update Serviteur set nom_complet=@nom,sexe=@sexe,adresse=@adresse,etat_civil=@etatcivil,phone=@phone,photo=@photo,email=@mail,CODE_CELLULE=@cellule,code_ministere=@ministere,date_modif=@date_modif where code=@code";
                        SetParametre(cmd, "@code", DbType.String, 50, pt.Code_Servi.ToUpper());
                        SetParametre(cmd, "@nom", DbType.String, 50, pt.Nom.ToUpper());
                        SetParametre(cmd, "@sexe", DbType.String, 50, pt.Sexe.ToUpper());
                        SetParametre(cmd, "@Adresse", DbType.String, 50, pt.Adresse.ToUpper());
                        SetParametre(cmd, "@etatcivil", DbType.String, 50, pt.EtaCivil.ToUpper());
                        SetParametre(cmd, "@phone", DbType.String, 50, pt.Phone.ToUpper());
                        if (pt.Photo != null)
                            SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, pt.Photo);
                        else
                            SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        SetParametre(cmd, "@mail", DbType.String, 50, pt.Mail.ToUpper());
                        SetParametre(cmd, "@cellule", DbType.String, 50, pt.Cellule.ToUpper());
                        SetParametre(cmd, "@ministere", DbType.String, 50, pt.Ministere.ToUpper());
                        SetParametre(cmd, "@date_modif", DbType.String, 50, pt.Date.ToUpper());
                        cmd.ExecuteNonQuery();
                        fx.Messages(1);
                        break;
                    case 3:
                        cmd.CommandText = "delete from Membre where Id_Memb=@id";
                        MessageBox.Show("Suppression reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public string CodeServiteur()
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[CodeServiteur]() as Id ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Id"].ToString());
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
        public string Code_Serviteur(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select code from serviteur where nom_complet='" + rech + "'", conn);
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
        public string NomServi(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select nom_complet from serviteur where nom_complet='" + rech + "'", conn);
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
        public string SexeSer(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select sexe from serviteur where nom_complet='" + rech + "'", conn);
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
        public string AdresseServi(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select adresse from serviteur where nom_complet='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["adresse"].ToString());

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
        public string PhoneServi(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select phone from Serviteur where nom_complet='" + rech + "'", conn);
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
        public string CelluleServi(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select NOM_CELLULE from [V_Serviteur] where NOM='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["NOM_CELLULE"].ToString());

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
        public string Etat_civilServ(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select ETAT_CIVIL from serviteur where nom_complet='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["etat_civil"].ToString());

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
        public string MailServ(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select email from serviteur where nom_complet='" + rech + "'", conn);
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
        public string Ministere(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select FONCTION from [V_Serviteur] where NOM='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["FONCTION"].ToString());

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
        public string TestCodeServi(string nom)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[TestCodeServiteur]('" + nom + "') as val ", conn);
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
    }
}
