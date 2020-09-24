using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
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

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    public partial class FrmConcencration : Form
    {
        public FrmConcencration()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        ClsServiteurInsertion ci = new ClsServiteurInsertion();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {
                if (code.Text=="" || txtdate.Text== "Date" || txtministere.Text=="")
                {
                    fx.Messages(2);
                }
                else
                {
                    cm.Code_Servi = code.Text;
                    string rqt = "exec AjoutConcencré '" + cm.Code_Servi + "','" + cm.Ministere + "','" + txtdate.Text + "'";
                    dao.Executer(rqt);
                    dao.chargementGridOptimise("select * from V_Concencration", Listebapteme);
                }
               
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmConcencration_Load(object sender, EventArgs e)
        {
            fx.Picture_Rond(profile);
            dao.chargerCombo("select designation from ministere", "designation", txtministere);
            dao.Autocomplete("select nom_complet from serviteur", "nom_complet", rech);
            dao.chargementGridOptimise("select * from [V_Concencration]", Listebapteme);
        }
        private void Listemembre_Click(object sender, EventArgs e)
        {
           
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            txtnom.Text = ci.NomServi(rech.Text);
            code.Text = ci.Code_Serviteur(rech.Text);
        }

        private void txtministere_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm.Ministere = dao.IdCombo("Ministere", "code", txtministere.Text, "designation");
        }

        private void Listebapteme_Click(object sender, EventArgs e)
        {
        }

        private void txtmotif_Leave(object sender, EventArgs e)
        {
            //if (txtmotif.Text=="")
            //{
            //    txtmotif.Text = "Motif";
            //}
        }

        private void txtmotif_Enter(object sender, EventArgs e)
        {
            //if (txtmotif.Text == "Motif")
            //{
            //    txtmotif.Text = "";
            //}
        }

        private void rech1_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_Concencration where Serviteur like '%" + rech1.Text + "%'", Listebapteme);
        }

        private void Listebapteme_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listebapteme_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Listemembre_Click_1(object sender, EventArgs e)
        {
            //code.Text = Listemembre.SelectedRows[0].Cells[0].Value.ToString();
            //txtnom.Text = Listemembre.SelectedRows[0].Cells[1].Value.ToString();
            //txtministere.Text = Listemembre.SelectedRows[0].Cells[2].Value.ToString();
            //dao.Photos(profile, "Serviteur", txtnom.Text);
        }

        private void Listebapteme_Click_2(object sender, EventArgs e)
        {
            try
            {
                code.Text = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
                txtnom.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
                txtministere.Text = Listebapteme.SelectedRows[0].Cells[2].Value.ToString();
                dao.Photos(profile, "Serviteur", txtnom.Text);
            }catch(Exception ex)
            {

            }
        }

        private void date_onValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = date.Value.ToString();
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            //txtdate1.Text = date.Value.ToString();
            //string dates = date.Value.ToString("yyy-MM-dd");
            //dao.chargementGridOptimise("select  * from V_Concencration where dates like '%" + dates + "%'", Listebapteme);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Frmrapportconcencration ctr = new Frmrapportconcencration();
            ctr.ShowDialog();
        }
    }
}
