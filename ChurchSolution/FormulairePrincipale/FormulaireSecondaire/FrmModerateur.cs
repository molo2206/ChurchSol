using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
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
    public partial class FrmModerateur : Form
    {
        public FrmModerateur()
        {
            InitializeComponent();
            fx.Picture_Rond(profile);
            dao.chargementGridOptimise("select * from moderatuer", Listebapteme);
            check.Checked = false;
            check1.Checked = false;
        }

        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        Culte cl = new Culte();
        private void btnsuite_Click(object sender, EventArgs e)
        {

            try
            {
                switch (btnsuite.Text)
                {
                    case "Enregistrer":

                        if (txtnom.Text.Equals("") || txtmail.Text.Equals("") || txtministere.Text.Equals("") || txtprovenance.Text.Equals("") || txtsexe.Text == "")
                        {
                            fx.Messages(2);
                        }
                        else
                        {
                            cl.Code_predicateur = code.Text.ToUpper();
                            cl.Nom_preducateur = txtnom.Text.ToUpper();
                            cl.Phone = txttelephone.Text.ToUpper();
                            cl.Mail = txtmail.Text;
                            cl.Ministere = txtministere.Text.ToUpper();
                            cl.Provenance = txtprovenance.Text.ToUpper();
                            cl.Sexe = txtsexe.Text.ToUpper();
                            string rqt = "exec [AjoutModerateur]'" + cl.Code_predicateur + "','" + cl.Nom_preducateur + "','" + cl.Mail + "','" + cl.Phone + "','" + cl.Provenance + "','" + cl.Ministere + "','" + cl.Sexe + "'";
                            dao.Executer(rqt);
                            dao.chargementGridOptimise("select * from MODERATUER", Listebapteme);
                        }
                        break;

                    case "Modifier":
                        try
                        {
                            if (txtnom.Text.Equals("") || txtmail.Text.Equals("") || txtministere.Text.Equals("") || txtprovenance.Text.Equals("") || txtsexe.Text == "")
                            {
                                fx.Messages(2);
                            }
                            else
                            {
                                if (code.Text != "")
                                {
                                    cl.Code_predicateur = code.Text.ToUpper();
                                    cl.Nom_preducateur = txtnom.Text.ToUpper();
                                    cl.Phone = txttelephone.Text.ToUpper();
                                    cl.Mail = txtmail.Text;
                                    cl.Ministere = txtministere.Text.ToUpper();
                                    cl.Provenance = txtprovenance.Text.ToUpper();
                                    cl.Sexe = txtsexe.Text.ToUpper();
                                    string rqt = "exec [AjoutModerateur]'" + cl.Code_predicateur + "','" + cl.Nom_preducateur + "','" + cl.Mail + "','" + cl.Phone + "','" + cl.Provenance + "','" + cl.Ministere + "','" + cl.Sexe + "'";
                                    dao.Executer(rqt);
                                    dao.chargementGridOptimise("select * from MODERATUER", Listebapteme);
                                }
                                else
                                {
                                    MessageBox.Show("Veillez sélectioné dans le tableau pour modifier!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }
                        catch (Exception ex)
                        {

                        }
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from MODERATUER  where nom_complet like '%" + rech.Text + "%'", Listebapteme);
        }

        private void FrmModerateur_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from MODERATUER", Listebapteme);
            check.Checked = false;
            check1.Checked = false;
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }

        private void check_OnChange(object sender, EventArgs e)
        {
            if (check.Checked == true)
            {
                check1.Checked = false;
                btnsuite.Text = "Enregistrer";
            }
            else
            {
            }
        }

        private void check1_OnChange(object sender, EventArgs e)
        {

            if (check1.Checked == true)
            {
                if (code.Text == "")
                {
                    MessageBox.Show("Veillez sélectioné dans le tableau pour modifier!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check1.Checked = false;
                }
                else
                {

                    check.Checked = false;
                    btnsuite.Text = "Modifier";
                }
            }
        }

        private void Listebapteme_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fx.Photos(profile);
        }

        private void Listebapteme_Click_1(object sender, EventArgs e)
        {
            try
            {
                code.Text = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
                txtnom.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
                txtmail.Text = Listebapteme.SelectedRows[0].Cells[2].Value.ToString();
                txttelephone.Text = Listebapteme.SelectedRows[0].Cells[3].Value.ToString();
                txtsexe.Text = Listebapteme.SelectedRows[0].Cells[7].Value.ToString();
                txtprovenance.Text = Listebapteme.SelectedRows[0].Cells[4].Value.ToString();
                txtministere.Text = Listebapteme.SelectedRows[0].Cells[5].Value.ToString();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
