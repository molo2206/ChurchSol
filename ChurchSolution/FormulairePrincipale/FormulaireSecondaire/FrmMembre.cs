using ChurchSolution.AutresRapport;
using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire;
using ChurchSolution.Rapport_Etat_de_sortie_;
using DevExpress.XtraReports.UI;
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
    public partial class FrmMembre : Form
    {
        public FrmMembre()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        ClsRapports clr = new ClsRapports();
        ClsMembreInsertion ins = new ClsMembreInsertion();
        string date;
        string date_modf;
        private void FrmMembre_Load(object sender, EventArgs e)
        {
            date = DateTime.Now.Date.ToString("yyyy/MM/dd");
            date_modf = DateTime.Now.Date.ToString("yyyy/MM/dd");
            fx.Picture_Rond(profile);
            //tel.Enabled = false;
            check.Checked = false;
            check1.Checked = false;
            btnsuite.Enabled = false;
            fx.Picture_Rond(pictureBox6);
            dao.Autocomplete("SELECT NOM_CELLULE FROM CELLULE", "NOM_CELLULE", txtcellule);
            dao.Autocomplete("SELECT NOM_COMPLET FROM Membre", "NOM_COMPLET", rech);
            total.Text = dao.Countnombre("select count(code) as code from membre ","code");
            homme.Text = dao.Countnombre("select count(code) as code from membre where SEXE='homme'", "code");
            femme.Text = dao.Countnombre("select count(code) as code from membre  where SEXE='Femme'", "code");
            dao.chargerCombo("SELECT NOM_CELLULE FROM CELLULE", "NOM_CELLULE", cellule_select);
            code_modifier.Text = ins.CodeMembre();
            code_insert.Text = ins.CodeMembre();
        }
        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals(""))
            {
                txtnom.Text = "Nom";
            }
        }

        private void FrmMembre_Leave(object sender, EventArgs e)
        {

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

        private void txtcellule_Leave(object sender, EventArgs e)
        {
            if (txtcellule.Text.Equals(""))
            {
                txtcellule.Text = "Cellule";
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
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
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }
        void initiale()
        {
            txtnom.Text = "Nom";
            txtsexe.Text = "";
            txtadresse.Text = "Adresse";
            txtetat.Text = "";
            txtcellule.Text = "Cellule";
            txttelephone.Text = "Phone";
            
        }
        private void txtcellule_Leave_2(object sender, EventArgs e)
        {
            if (txtcellule.Text.Equals(""))
            {
                txtcellule.Text = "Cellule";
            }
        }

        private void txtcellule_Enter_2(object sender, EventArgs e)
        {
            if (txtcellule.Text.Equals("Cellule"))
            {
                txtcellule.Text = "";
            }
        }

        private void txtcellule_TextChanged(object sender, EventArgs e)
        {
            cm.Cellule= dao.IdCombo("CELLULE","code",txtcellule.Text, "NOM_CELLULE");
        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fx.Photos(profile);
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }

        private void txtsexe_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Character(e);
        }

        private void txtetat_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Character(e);
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            code_modifier.Text = ins.Code_Membre(rech.Text);           
            nom_compare.Text = ins.TestCode(rech.Text);
            txtnom.Text = ins.Nom(rech.Text);
            txtsexe.Text = ins.Sexe(rech.Text);
            txtadresse.Text = ins.Adresse(rech.Text);
            txttelephone.Text = ins.Phone(rech.Text);
            txtetat.Text = ins.Etat_civil(rech.Text);
            txtcellule.Text = ins.Cellule(rech.Text);
            dao.Photos(profile,"Membre",rech.Text);          
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (btnsuite.ButtonText.Equals("Enregistrer"))
            {
                btnsuite.ButtonText = "Modifier";
            }
            else
                btnsuite.ButtonText = "Enregistrer";
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (check.Checked==true)
            {
                btnsuite.ButtonText = "Enregistrer";
                btnsuite.Enabled=true;
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
                    string nom = ins.TestCode(txtnom.Text);
                    if (nom == txtnom.Text)
                    {
                        cm.Date = date_modf;
                        cm.Code = code_modifier.Text;
                        cm.Nom = txtnom.Text;
                        cm.Sexe = txtsexe.Text;
                        cm.Adresse = txtadresse.Text;
                        cm.Phone = txttelephone.Text;
                        cm.EtaCivil = txtetat.Text;
                        cm.Photo = fx.GetBytePhoto(profile.Image);
                        ins.InsertionUpdateDeleteEntreprise_avec_photo(cm, 2);
                        initiale();
                    }
                    else
                    {
                        switch (btnsuite.ButtonText)
                        {
                            case "Enregistrer":
                                cm.Date = date;
                                cm.Code = code_insert.Text;
                                cm.Nom = txtnom.Text;
                                cm.Sexe = txtsexe.Text;
                                cm.Adresse = txtadresse.Text;
                                cm.Phone = txttelephone.Text;
                                cm.EtaCivil = txtetat.Text;
                                cm.Photo = fx.GetBytePhoto(profile.Image);
                                ins.InsertionUpdateDeleteEntreprise_avec_photo(cm, 1);
                                code_insert.Text = ins.CodeMembre();
                                total.Text = dao.Countnombre("select count(code) as code from membre ", "code");
                                homme.Text = dao.Countnombre("select count(code) as code from membre where SEXE='homme'", "code");
                                femme.Text = dao.Countnombre("select count(code) as code from membre  where SEXE='Femme'", "code");                                
                                initiale();
                                break;
                            case "Modifier":
                                cm.Date = date_modf;
                                cm.Code = code_modifier.Text;
                                cm.Nom = txtnom.Text;
                                cm.Sexe = txtsexe.Text;
                                cm.Adresse = txtadresse.Text;
                                cm.Phone = txttelephone.Text;
                                cm.EtaCivil = txtetat.Text;
                                cm.Photo = fx.GetBytePhoto(profile.Image);
                                ins.InsertionUpdateDeleteEntreprise_avec_photo(cm, 2);
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ListMembre lm = new ListMembre();
            lm.ShowDialog();
        }
        private void barcode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            Frmcellule fc = new Frmcellule();
            fc.ShowDialog();
        }

        private void txtsexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (cellule_select.Text=="")
            {
                MessageBox.Show("sélectionner d'abord avant d'emprimer", "Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                XtraReport1 xtp = new XtraReport1();
                xtp.DataSource = clr.GetInstance().listeup("v_membre", "NOM_CELLULE", cellule_select.Text);
                ReportPrintTool printTool = new ReportPrintTool(xtp);
                printTool.ShowRibbonPreview();

            }

        }

    }
}
