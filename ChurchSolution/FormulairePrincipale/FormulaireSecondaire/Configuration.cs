using ChurchSolution.ClassConnexion;
using ChurchSolution.ClasseFonction;
using ChurchSolution.ClasseModel;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            this.ActiveControl = txtnom;
            txtnom.Focus();
        }
        ClsDAO dao = new ClsDAO();
        ClsUtilisateur cu = new ClsUtilisateur();
        ClsAgentInsertion ca = new ClsAgentInsertion();
        Clsfonctions fx = new Clsfonctions();
        private void Configuration_Load(object sender, EventArgs e)
        {
            serveur.Text=(string.Format(@"{0}", Environment.MachineName) + "");
            if (File.Exists("C:\\chemin\\Connexion.txt"))
            {
               txtchemin.Text=File.ReadAllText(ClsConstante.Table.chemin);
            }
            else
            {

            }
            txtchoix.Text = "C:\\chemin\\Connexion.txt";
        }
        private void configuration()
        {
            if (serveur.Text.Equals("Nom du serveur") || txtbd.Text.Equals("Nom de la base des données") || txtuser.Text.Equals("Nom d'utilisateur"))
            {
                fx.Messages(2);
            }
            else
            {
                if (txtconf.Text != txtpwd.Text)
                {
                    fx.Messages(3);
                }
                else
                {
                    try
                    {
                        connecter();
                        chem = "Data Source=" + ClsConfiguration.dataS + "; Initial Catalog=" + ClsConfiguration.initcat + "; User Id=" + ClsConfiguration.id + "; Password=" + ClsConfiguration.pass + ";";
                        File.WriteAllText(ClsConstante.Table.chemin, chem.ToString());
                        fx.Messages(1);
                        initialiser();

                        Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
        public void initialiser()
        {
            serveur.Text = ""; txtbd.Text = ""; txtuser.Text = ""; txtpwd.Text = "";
        }
        String chem;
        void connecter()
        {
            ClsConfiguration.dataS = serveur.Text;
            ClsConfiguration.initcat = txtbd.Text;
            ClsConfiguration.id = txtuser.Text;
            ClsConfiguration.pass = txtpwd.Text;
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            configuration();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnom.Text.Equals("Nom d'utilisateur") || txtpasse.Text.Equals("Mot passe") || txtconfirm.Text.Equals("Mot passe"))
                {
                    fx.Messages(2);
                }
                else
                {
                    if (txtconfirm.Text != txtpasse.Text)
                    {
                        fx.Messages(5);
                    }
                    else
                    {
                        if (txtnom.Text!="Admin")
                        {
                            MessageBox.Show("Vous devez écrire Admin","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            fx.Messages(2);
                        }
                        else
                        {
                            if (txtnom.Text==dao.Admin())
                            {
                                MessageBox.Show("C'est utilisateur existe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                fx.Messages(2);
                            }
                            else
                            {
                                cu.Nom_user = txtnom.Text;
                                cu.Passe = txtpasse.Text;
                                string rqt = "exec AjoutUtilisateur_Agent '" + cu.Code + "','" + cu.Nom_user + "','" + cu.Passe + "'";
                                dao.Executer(rqt);
                                
                            }
                           
                        }
                        
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Nom d'utilisateur";
            }
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text== "Nom d'utilisateur")
            {
                txtnom.Text = "";
            }
        }

        private void txtpasse_Leave(object sender, EventArgs e)
        {

            if (txtpasse.Text == "")
            {
                txtpasse.Text = "Mot passe";
            }
        }

        private void txtpasse_Enter(object sender, EventArgs e)
        {
            if (txtpasse.Text == "Mot passe")
            {
                txtpasse.Text = "";
            }
        }

        private void txtconfirm_Leave(object sender, EventArgs e)
        {

        }

        private void txtconfirm_Enter(object sender, EventArgs e)
        {
            
        }

        private void iTalk_TextBox_Small1_Leave(object sender, EventArgs e)
        {
            if (txtconfirm.Text == "")
            {
                txtconfirm.Text = "Mot passe";
            }
        }

        private void txtconfirm_Enter_1(object sender, EventArgs e)
        {
            if (txtconfirm.Text == "Mot passe")
            {
                txtconfirm.Text = "";
            }
        }

        private void serveur_Leave(object sender, EventArgs e)
        {
            if (serveur.Text=="")
            {
                serveur.Text = "Nom du serveur";
            }
        }

        private void serveur_Enter(object sender, EventArgs e)
        {
            if (serveur.Text == "Nom du serveur")
            {
                serveur.Text = "";
            }
        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text== "Nom d'utilisateur")
            {
                txtuser.Text = "";
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text=="")
            {
                txtuser.Text = "Nom d'utilisateur";
            }
        }

        private void txtbd_Leave_1(object sender, EventArgs e)
        {
            if (txtbd.Text=="")
            {
                txtbd.Text = "Nom de la base des données";
            }
        }

        private void txtbd_Enter_1(object sender, EventArgs e)
        {
            if (txtbd.Text== "Nom de la base des données")
            {
                txtbd.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdl = new OpenFileDialog();
            if (fdl.ShowDialog()==DialogResult.OK)
            {
               txtchoix.Text = fdl.FileName;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            txtchemin.Text = File.ReadAllText(ClsConstante.Table.chemin);
        }

        private void txtnom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtpasse.Focus();
            }
        }

        private void txtpasse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtconfirm.Focus();
            }
        }

        private void txtconfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnajout.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtpasse.UseSystemPasswordChar = false;
                txtconfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtpasse.UseSystemPasswordChar = true;
                txtconfirm.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                txtpwd.UseSystemPasswordChar = false;
                txtconf.UseSystemPasswordChar = false;
            }
            else
            {
                txtpwd.UseSystemPasswordChar = true;
                txtconf.UseSystemPasswordChar = true;
            }
        }

        private void txtconf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnsuite.PerformClick();
            }
        }

        private void btnajout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnajout.PerformClick();
            }
        }
    }
 }

