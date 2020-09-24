using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification;
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
    public partial class FrmAhent : Form
    {
        public FrmAhent()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        ClsAgentInsertion cla = new ClsAgentInsertion();

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals(""))
            {
                txtnom.Text = "Nom_complet";
            }
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals("Nom_complet"))
            {
                txtnom.Text = "";
            }
        }

        private void txtadresse_Leave(object sender, EventArgs e)
        {
            if (txtmail.Text.Equals(""))
            {
                txtmail.Text = "Adresse";
            }
        }

        private void txtadresse_Enter(object sender, EventArgs e)
        {
            if (txtmail.Text.Equals("Adresse"))
            {
                txtmail.Text = "";
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

        private void txtpostnom_Leave(object sender, EventArgs e)
        {
            //if (txtmail.Text.Equals(""))
            //{
            //    txtmail.Text = "Adresse mail";
            //}
        }

        private void txtmail_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtmail_Enter(object sender, EventArgs e)
        {
            //if (txtmail.Text.Equals("Adresse mail"))
            //{
            //    txtmail.Text = "";
            //}
        }

        string date;
        string date_modif;
        private void FrmAhent_Load(object sender, EventArgs e)
        {

            date = DateTime.Now.Date.ToString("yyyy/MM/dd");
            date_modif= DateTime.Now.Date.ToString("yyyy/MM/dd");
            label4.Text = cla.BarcodeAgent();
            fx.Picture_Rond(profile);
            label3.Text = cla.CodeAgent();
            label2.Text = cla.CodeAgent();
            //tel.Enabled = false;
            check2.Checked = false;
            check3.Checked = false;
            btnsuite.Enabled = false;
            fx.Picture_Rond(pictureBox6);
            dao.Autocomplete("SELECT NOM_COMPLET FROM agent", "NOM_COMPLET", rech);
            dao.chargerCombo("select designation from fonction", "designation", txtfonction);
            total.Text = dao.Countnombre("select count(code) as code from agent ", "code");
            homme.Text = dao.Countnombre("select count(code) as code from agent where SEXE='homme'", "code");
            femme.Text = dao.Countnombre("select count(code) as code from agent  where SEXE='Femme'", "code");
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtnom.Text == "Nom" || txtsexe.Text == "" || txtmail.Text == "Adresse" || txttelephone.Text == "Phone"||profile.Image == null)
                {
                    fx.Messages(2);
                }
                else
                {
                    string nom = cla.TestCodeAgent(txtnom.Text);
                    if (nom == txtnom.Text)
                    {
                        cm.Date = date_modif;
                        cm.Code_Agent = label2.Text;
                        cm.Nom = txtnom.Text;
                        cm.Sexe = txtsexe.Text;
                        cm.Phone = txttelephone.Text;
                        cm.Mail = txtmail.Text;
                        cm.Photo = fx.GetBytePhoto(profile.Image);
                        cla.InsertionUpdateDeleteAgent(cm, 2);
                        initiale();
                    }
                    else
                    {
                        switch (btnsuite.ButtonText)
                        {
                            case "Enregistrer":
                                cm.Date = date;
                                cm.Code_Agent = label3.Text;
                                cm.Nom = txtnom.Text;
                                cm.Sexe = txtsexe.Text;
                                cm.Mail = txtmail.Text;
                                int barcode = int.Parse(label4.Text);
                                cm.Barcode = barcode;
                                cm.Phone = txttelephone.Text;
                                cm.Photo = fx.GetBytePhoto(profile.Image);
                                cla.InsertionUpdateDeleteAgent(cm, 1);
                                label3.Text = cla.CodeAgent();
                                label4.Text = cla.BarcodeAgent();
                                total.Text = dao.Countnombre("select count(code) as code from agent ", "code");
                                homme.Text = dao.Countnombre("select count(code) as code from agent where SEXE='homme'", "code");
                                femme.Text = dao.Countnombre("select count(code) as code from agent  where SEXE='Femme'", "code");
                                initiale();
                                break;
                            case "Modifier":
                                cm.Date = date_modif;
                                cm.Code_Agent = label2.Text;
                                cm.Nom = txtnom.Text;
                                cm.Sexe = txtsexe.Text;
                                cm.Mail = txtmail.Text;
                                cm.Phone = txttelephone.Text;                               
                                cm.Photo = fx.GetBytePhoto(profile.Image);
                                cla.InsertionUpdateDeleteAgent(cm, 2);
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
            txtmail.Text = "Adresse";
            txttelephone.Text = "Phone";

        }

        private void txtnom_Leave_1(object sender, EventArgs e)
        {
            if (txtnom.Text=="")
            {
                txtnom.Text = "Nom";
            }
        }

        private void txtnom_Enter_1(object sender, EventArgs e)
        {
            if (txtnom.Text == "Nom")
            {
                txtnom.Text = "";
            }
        }

        private void txtmail_Leave(object sender, EventArgs e)
        {
            if (txtmail.Text=="")
            {
                txtmail.Text = "Exemple@gmail.com";
            }
        }

        private void txtmail_Enter_1(object sender, EventArgs e)
        {
            if (txtmail.Text == "Exemple@gmail.com")
            {
                txtmail.Text = "";
            }
        }

        private void txttelephone_Leave_1(object sender, EventArgs e)
        {
            if (txttelephone.Text== "")
            {
                txttelephone.Text = "Phone";
            }
        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text=="")
            {
                rech.Text = "Rechercher le nom";
            }
        }

        private void txttelephone_Enter_1(object sender, EventArgs e)
        {
            if (txttelephone.Text == "Phone")
            {
                txttelephone.Text = "";
            }
        }

        private void rech_Enter(object sender, EventArgs e)
        {
            if (rech.Text == "Rechercher le nom")
            {
                rech.Text = "";
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (check3.Checked == true)
            {
                btnsuite.ButtonText = "Enregistrer";
                btnsuite.Enabled = true;
                check2.Checked = false;
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void check2_OnChange(object sender, EventArgs e)
        {
            if (check2.Checked == true)
            {
                btnsuite.ButtonText = "Modifier";
                btnsuite.Enabled = true;
                check3.Checked = false;
            }
        }

        private void rech_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            label2.Text = cla.Code_agent(rech.Text);
            label1.Text = cla.TestCodeAgent(rech.Text);
            txtnom.Text = cla.NomAgent(rech.Text);
            txtsexe.Text = cla.SexeAgent(rech.Text);
            txtmail.Text = cla.MailAgent(rech.Text);
            txttelephone.Text = cla.PhoneAgent(rech.Text);
            label4.Text = dao.BarcodeAgent(rech.Text);
            txtfonction.Text = cla.fonction(rech.Text);
            dao.Photos(profile,"agent",rech.Text);
        }
        public void Photo()
        {
            try
            {
                //dao.Photo("Agent", label2.Text, profile);

            }
            catch
            {

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fx.Photos(profile);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            dao.Photo("Agent", label2.Text, profile);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ListeAgent li = new ListeAgent();
            li.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FrmCarte fc = new FrmCarte();
            fc.ShowDialog();
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            Frmfonction ff = new Frmfonction();
            ff.ShowDialog();
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            dao.chargerCombo("select designation from fonction", "designation", txtfonction);
        }

        private void txtfonction_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm.Code_fonction = dao.IdCombo("fonction","code",txtfonction.Text,"designation");
        }
    }
}
