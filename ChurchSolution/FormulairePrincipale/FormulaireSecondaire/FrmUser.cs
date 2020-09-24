using ChurchSolution.ClasseFonction;
using ChurchSolution.ClasseModel;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsUtilisateur cu = new ClsUtilisateur();
        ClsAgentInsertion ca = new ClsAgentInsertion();
        private void FrmUser_Load(object sender, EventArgs e)
        {
            dao.Autocomplete("select nom_utilisateur from [v_utilisateur]", "nom_utilisateur", txtutil);
            dao.Autocomplete("select nom_utilisateur from [utilisateur]", "nom_utilisateur", rech);
            dao.chargerCombo("select designation from Fonction", "designation", txtfonction);
            dao.Autocomplete("select nom_complet from agent","nom_complet",txtagent);
            dao.chargerCombo("select designation from menu", "designation", txtfonc);
            dao.chargementGridOptimise("select cod as Code,NOM_UTILISATEUR as Utilisateur,Agent,Fonction,Niveau,Menu,date_exp as Date_Expire from v_utilisateur", Listebapteme);
            fx.Picture_Rond(profile);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnom.Text.Equals("") || txtpasse.Text.Equals("") || txtconfirm.Text.Equals(""))
                {
                    fx.Messages(2);
                }
                else
                {
                    if (txtconfirm.Text!=txtpasse.Text)
                    {
                        fx.Messages(5);
                    }
                    else
                    {
                        cu.Code = label1.Text;
                        cu.Nom_user = txtnom.Text;
                        cu.Passe = txtpasse.Text;
                        string rqt = "exec AjoutUtilisateur '" + cu.Code + "','" + cu.Nom_user + "','" + cu.Passe + "'";
                        dao.Executer(rqt);
                        label1.Text = dao.CodeUtilisateur();
                    }
                   
                }            
            }
            catch(Exception ex)
            {

            }
        }
        int fonction;
        private void txtfonction_SelectedIndexChanged(object sender, EventArgs e)
        {
            cu.Fonction = dao.IdCombo_avec_Integer("Fonction","code",txtfonction.Text, "designation");
        }

        private void txtagent_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void date_onValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = date.Value.ToString("dd/MM/yyyy");
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            if (txtdate.Text=="" || txtfonction.Text=="" || txtagent.Text=="" || txtfonction.Text=="" || label1.Text=="")
            {
                fx.Messages(3);
            }
            else
            {
                try
                {
                    
                    cu.Code = label1.Text;
                    cu.Nivaeu = acces.Text;
                    string rqt = "exec ValiditeCompte '" + cu.Code_validite + "','" + int.Parse(cu.Nivaeu) + "','" + txtdate.Text + "','" + cu.Agent + "','" +cu.Fonction + "','" + cu.Code + "'";
                    dao.Executer(rqt);
                }
                catch (Exception ex)
                {

                }
            }
           
        }
        private void rech_TextChanged(object sender, EventArgs e)
        {
            label1.Text = dao.Code_user(rech.Text);
            txtnom.Text = dao.Nom_user(rech.Text);
            txtfonction.Text = dao.fonction_user(rech.Text);
            acces.Text = dao.Niveau_user(rech.Text);
            txtagent.Text = dao.Agent_user(rech.Text);
            txtdate.Text = dao.Date_user(rech.Text);
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmFonctionnalite fn = new FrmFonctionnalite();
            fn.ShowDialog();
        }

        private void txtutil_TextChanged(object sender, EventArgs e)
        {
            label5.Text = dao.Code_user(txtutil.Text);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (txtutil.Text == "" || txtfonc.Text == "")
            {
                fx.Messages(3);
            }
            else
            {
                try
                {
                    int menu =int.Parse(label4.Text);
                    cu.Code_menu = menu;
                    cu.Code = label5.Text;
                    string rqt = "exec [Ajout_Fonctionnalite] '" + cu.Code_fonctionnalite + "','" + cu.Code_menu + "','" + cu.Code + "'";
                    dao.Executer(rqt);
                    dao.chargementGridOptimise("select cod as Code,NOM_UTILISATEUR as Utilisateur,Agent,Fonction,Niveau,Menu,date_exp as Date_Expire from v_utilisateur", Listebapteme);

                }
                catch (Exception ex)
                {

                }
            }

        }

        private void txtfonc_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = dao.IdCombo("menu", "code", txtfonc.Text, "designation");
        }

        private void Listebapteme_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    label1.Text = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
            //    txtnom.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            Frmfonction ff = new Frmfonction();
            ff.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dao.Photos(profile, "agent", txtagent.Text);
            cu.Agent = dao.IdCombo("agent", "code", txtagent.Text, "nom_complet");
            codebare.Text = ca.Code_bare(txtagent.Text);
        }

        private void txtdate_Enter(object sender, EventArgs e)
        {
            if (txtdate.Text== "Date expiration")
            {
                txtdate.Text = "";
            }
        }

        private void txtdate_Leave(object sender, EventArgs e)
        {

            if (txtdate.Text == "")
            {
                txtdate.Text = "Date expiration";
            }
        }

        private void txtdate1_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtdate1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Listebapteme_Click_1(object sender, EventArgs e)
        {
            try
            {
                code_fonc =int.Parse(Listebapteme.SelectedRows[0].Cells[0].Value.ToString());
            //    label1.Text= Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
            //    label3.Text= Listebapteme.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select cod as Code,NOM_UTILISATEUR as Utilisateur,Agent,Fonction,Niveau,Menu,date_exp as Date_Expire from v_utilisateur where NOM_UTILISATEUR like '%" + textBox1.Text+"%'", Listebapteme);
        }

        int code_fonc=0;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (code_fonc.Equals(0))
                {
                    fx.Messages(3);
                }
                else
                {
                    string rqt = "exec Delete_Fonctionnalite '"+code_fonc+"'";
                    dao.Executer(rqt);
                    dao.chargementGridOptimise("select cod as Code,NOM_UTILISATEUR as Utilisateur,Agent,Fonction,Niveau,Menu,date_exp as Date_Expire from v_utilisateur", Listebapteme);
                    code_fonc = 0;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}

