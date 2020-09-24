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
    public partial class FrmVisiteur : Form
    {
        public FrmVisiteur()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        Culte cl = new Culte();
        private void txtdate_onValueChanged(object sender, EventArgs e)
        {
            dd.Text = txtdate.Value.ToString();
        }

        string date;
        private void btnsuite_Click(object sender, EventArgs e)
        {
            date = txtdate.Value.ToString("dd/MM/yyyy");
            try
            {
                switch (btnsuite.Text)
                {
                    case "Enregistrer":

                        if (txtnom.Text.Equals("") || dd.Text.Equals("") || txtprovenance.Text.Equals("") || txtsexe.Text == "")
                        {
                            fx.Messages(2);
                        }
                        else
                        {
                            cl.Code_visiteur = code.Text;
                            cl.Nom_visiteur = txtnom.Text;
                            cl.Provenance = txtprovenance.Text;
                            cl.Sexe = txtsexe.Text;
                            string rqt = "exec [AJOUT_VISITEUR]'" + cl.Code_visiteur + "','" + cl.Nom_visiteur + "','" + cl.Provenance + "','"+ dd.Text + "','" + cl.Sexe + "'";
                            dao.Executer(rqt);
                            dao.chargementGridOptimise("select * from visiteur", Listebapteme);
                        }
                        break;

                    case "Modifier":
                        try
                        {
                            date = txtdate.Value.ToString("dd/MM/yyyy");
                            if (txtnom.Text.Equals("") || dd.Text.Equals("") || txtprovenance.Text.Equals("") || txtsexe.Text == "")
                            {
                                fx.Messages(2);
                            }
                            else
                            {
                                if (code.Text != "")
                                {
                                    cl.Code_visiteur = code.Text;
                                    cl.Nom_visiteur = txtnom.Text;
                                    cl.Provenance = txtprovenance.Text;
                                    string rqt = "exec [AJOUT_VISITEUR]'" + cl.Code_visiteur + "','" + cl.Nom_visiteur + "','" + cl.Provenance + "','" + dd.Text + "','" + cl.Sexe + "'";
                                    dao.Executer(rqt);
                                    dao.chargementGridOptimise("select * from visiteur", Listebapteme);
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
            dao.chargementGridOptimise("select * from visiteur  where nom like '%" + rech.Text + "%'", Listebapteme);
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

        private void FrmVisiteur_Load(object sender, EventArgs e)
        {

            dao.chargementGridOptimise("select * from visiteur", Listebapteme);
            check.Checked = false;
            check1.Checked = false;
        }

        private void Listebapteme_Click(object sender, EventArgs e)
        {
            
        }

        private void Listebapteme_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listebapteme_Click_1(object sender, EventArgs e)
        {
            try
            {
                code.Text = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
                txtnom.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
                txtprovenance.Text = Listebapteme.SelectedRows[0].Cells[2].Value.ToString();
                dd.Text = Listebapteme.SelectedRows[0].Cells[3].Value.ToString();
                txtsexe.Text = Listebapteme.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
