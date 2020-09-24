using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire;
using ChurchSolution.Rapport_Etat_de_sortie_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.FormulaireSecondaire
{
    public partial class FrmServiteur : Form
    {
        public FrmServiteur()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        ClsServiteurInsertion cls = new ClsServiteurInsertion();
        ClsMembre cm = new ClsMembre();
        ClsDAO dao = new ClsDAO();
        private void txtmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals(""))
            {
                txtnom.Text = "Nom";
            }
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals("Nom"))
            {
                txtnom.Text = "";
            }
        }

        private void txtadresse_Leave(object sender, EventArgs e)
        {
            if (txtadresse.Text.Equals(""))
            {
                txtadresse.Text = "Adresse";
            }
        }

        private void txtadresse_Enter(object sender, EventArgs e)
        {
            if (txtadresse.Text.Equals("Adresse"))
            {
                txtadresse.Text = "";
            }
        }

        private void txttelephone_Leave(object sender, EventArgs e)
        {
            if (txttelephone.Text.Equals(""))
            {
                txttelephone.Text = "Phone";
            }
        }

        private void txttelephone_Enter(object sender, EventArgs e)
        {
            if (txttelephone.Text.Equals("Phone"))
            {
                txttelephone.Text = "";
            }
        }

        private void txtmail_Leave(object sender, EventArgs e)
        {
            if (txtmail.Text.Equals(""))
            {
                txtmail.Text = "Exemple@gmail.com";
            }
        }

        private void txtmail_Enter(object sender, EventArgs e)
        {
            if (txtmail.Text.Equals("Exemple@gmail.com"))
            {
                txtmail.Text = "";
            }
        }

        private void txtcellule_Leave(object sender, EventArgs e)
        {
            if (txtcellule.Text.Equals(""))
            {
                txtcellule.Text = "Cellule";
            }
        }

        private void txtcellule_Enter(object sender, EventArgs e)
        {
            if (txtcellule.Text.Equals("Cellule"))
            {
                txtcellule.Text = "";
            }
        }

        private void txtministere_Leave(object sender, EventArgs e)
        {
            if (txtministere.Text.Equals(""))
            {
                txtministere.Text = "Ministère";
            }
        }

        private void txtministere_Enter(object sender, EventArgs e)
        {
            if (txtministere.Text.Equals("Ministère"))
            {
                txtministere.Text = "";
            }
        }
        private void rech_TextChanged(object sender, EventArgs e)
        {
            label2.Text = cls.Code_Serviteur(rech.Text);
            label1.Text = cls.TestCodeServi(rech.Text);
            txtnom.Text = cls.NomServi(rech.Text);
            txtsexe.Text = cls.SexeSer(rech.Text);
            txtadresse.Text = cls.AdresseServi(rech.Text);
            txttelephone.Text = cls.PhoneServi(rech.Text);
            txtmail.Text = cls.MailServ(rech.Text);
            txtetat.Text = cls.Etat_civilServ(rech.Text);
            txtcellule.Text = cls.CelluleServi(rech.Text);
            txtministere.Text = cls.Ministere(rech.Text);
            dao.Photos(profile,"serviteur",rech.Text);
        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text.Equals(""))
            {
                rech.Text = "Rechercher le nom";
            }
        }

        private void rech_Enter(object sender, EventArgs e)
        {
            if (rech.Text.Equals("Rechercher le nom"))
            {
                rech.Text = "";
            }
        }
        string date;
        string date_modf;
        private void FrmServiteur_Load(object sender, EventArgs e)
        {
            date = DateTime.Now.Date.ToString("yyyy/MM/dd");
            date_modf = DateTime.Now.Date.ToString("yyyy/MM/dd");
            fx.Picture_Rond(profile);
            //tel.Enabled = false;
            check.Checked = false;
            check1.Checked = false;
            btnsuite.Enabled = false;
            fx.Picture_Rond(pictureBox6);
            dao.Autocomplete("SELECT designation FROM ministere", "designation", txtministere);
            dao.Autocomplete("SELECT NOM_CELLULE FROM CELLULE", "NOM_CELLULE", txtcellule);
            dao.Autocomplete("SELECT NOM_COMPLET FROM serviteur", "NOM_COMPLET", rech);
            total.Text = dao.Countnombre("select count(code) as code from serviteur ", "code");
            homme.Text = dao.Countnombre("select count(code) as code from serviteur where SEXE='homme'", "code");
            femme.Text = dao.Countnombre("select count(code) as code from serviteur  where SEXE='Femme'", "code");
            label2.Text = cls.CodeServiteur();
            label3.Text = cls.CodeServiteur();
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtnom.Text == "Nom" || txtsexe.Text == "" || txtadresse.Text == "Adresse" || txttelephone.Text == "Phone" || txtcellule.Text == "Cellule" || txtetat.Text == "" || profile.Image == null)
                {
                    fx.Messages(2);
                }
                else
                {
                    string nom = cls.TestCodeServi(txtnom.Text);
                    if (nom == txtnom.Text)
                    {
                        cm.Date = date_modf;
                        cm.Code_Servi = label2.Text;
                        cm.Nom = txtnom.Text;
                        cm.Sexe = txtsexe.Text;
                        cm.Adresse = txtadresse.Text;
                        cm.Phone = txttelephone.Text;
                        cm.EtaCivil = txtetat.Text;
                        cm.Mail = txtmail.Text;
                        cm.Photo = fx.GetBytePhoto(profile.Image);
                        cls.InsertionUpdateDeleteServiteur(cm, 2);
                        initiale();
                    }
                    else
                    {
                        switch (btnsuite.ButtonText)
                        {
                            case "Enregistrer":
                                cm.Date = date;
                                cm.Code_Servi = label3.Text;
                                cm.Nom = txtnom.Text;
                                cm.Sexe = txtsexe.Text;
                                cm.Adresse = txtadresse.Text;
                                cm.Phone = txttelephone.Text;
                                cm.Mail = txtmail.Text;
                                cm.EtaCivil = txtetat.Text;
                                cm.Photo = fx.GetBytePhoto(profile.Image);
                                cls.InsertionUpdateDeleteServiteur(cm, 1);
                                label3.Text = cls.CodeServiteur();
                                total.Text = dao.Countnombre("select count(code) as code from serviteur ", "code");
                                homme.Text = dao.Countnombre("select count(code) as code from serviteur where SEXE='homme'", "code");
                                femme.Text = dao.Countnombre("select count(code) as code from serviteur  where SEXE='Femme'", "code");
                                initiale();
                                break;
                            case "Modifier":
                                cm.Date = date_modf;
                                cm.Code_Servi = label2.Text;
                                cm.Nom = txtnom.Text;
                                cm.Sexe = txtsexe.Text;
                                cm.Adresse = txtadresse.Text;
                                cm.Phone = txttelephone.Text;
                                cm.EtaCivil = txtetat.Text;
                                cm.Mail = txtmail.Text;
                                cm.Photo = fx.GetBytePhoto(profile.Image);
                                cls.InsertionUpdateDeleteServiteur(cm, 2);
                                initiale();
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        void initiale()
        {
            txtnom.Text = "Nom";
            txtsexe.Text = "";
            txtadresse.Text = "Adresse";
            txtetat.Text = "";
            txtcellule.Text = "Cellule";
            txttelephone.Text = "Phone";
            txtmail.Text = "Exemple@gmail.com";
            txtministere.Text = "Ministère";

        }

        private void txtcellule_TextChanged(object sender, EventArgs e)
        {
            cm.Cellule = dao.IdCombo("cellule","code",txtcellule.Text, "NOM_CELLULE");
        }

        private void txtministere_TextChanged(object sender, EventArgs e)
        {
            cm.Ministere = dao.IdCombo("ministere", "code", txtministere.Text, "designation");
        }

        private void check_OnChange(object sender, EventArgs e)
        {
            if (check.Checked == true)
            {
                btnsuite.ButtonText = "Enregistrer";
                btnsuite.Enabled = true;
                check1.Checked = false;
            }
        }

        private void check1_OnChange(object sender, EventArgs e)
        {
            if (check1.Checked == true)
            {
                btnsuite.ButtonText = "Modifier";
                btnsuite.Enabled = true;
                check.Checked = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ListServiteur fs = new ListServiteur();
            fs.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fx.Photos(profile);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FrmCarteServit fr = new FrmCarteServit();
            fr.ShowDialog();
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            FrmMinistere fm = new FrmMinistere();
            fm.ShowDialog();
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            Frmcellule fc = new Frmcellule();
            fc.ShowDialog();
        }
    }
}
