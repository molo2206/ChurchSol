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
    public partial class FrmBapteme : Form
    {
        public FrmBapteme()
        {
            InitializeComponent();
        }

        classMenu clm = new classMenu();
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        ClsMembreInsertion cl = new ClsMembreInsertion();
        private void FrmBapteme_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select code, Baptisé, Serviteur, DATE_BAPTE as Date_Bapteme, NOM_CELLULE as Cellule from V_bapteme", Listebapteme);
            dao.chargerCombo("select nom_complet from serviteur", "nom_complet", txtserviteur);
            dao.Autocomplete("select nom_complet from membre","nom_complet",rech);
            fx.Picture_Rond(profile);
        }

        private void rech_Leave(object sender, EventArgs e)
        {
           
        }

        private void rech_Enter(object sender, EventArgs e)
        {
          
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text=="")
            {
                txtnom.Text = "Nom du membre";
            }
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text == "Nom du membre")
            {
                txtnom.Text = "";
            }
        }

        private void txtserviteur_Leave(object sender, EventArgs e)
        {
            if (txtserviteur.Text=="")
            {
                txtserviteur.Text = "Nom du serviteur";
            }
        }

        private void txtserviteur_Enter(object sender, EventArgs e)
        {

            if (txtserviteur.Text == "Nom du serviteur")
            {
                txtserviteur.Text = "";
            }
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

        private void Listemembre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //code.Text = Listemembre.SelectedRows[0].Cells[0].Value.ToString();
                //txtnom.Text = Listemembre.SelectedRows[0].Cells[1].Value.ToString();
                //dao.Photos(profile, "Membre", txtnom.Text);
            }
            catch(Exception ex)
            {

            }
        }

        private void code_Click(object sender, EventArgs e)
        {
            if (code.Text!="")
            {
            }
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            txtnom.Text=cl.Nom(rech.Text);
            code.Text = cl.Code_Membre(rech.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {
                if (code.Text=="" || txtdate.Text== "Date" ||  txtserviteur.Text=="")
                {

                    fx.Messages(2);
                }
                else
                {
                    cm.Code = code.Text;
                    string rqt = "exec AjoutBapteme '" + cm.Code_Servi + "','" + cm.Code + "','"+txtdate.Text+"'";
                    dao.Executer(rqt);
                    dao.chargementGridOptimise("select * from V_bapteme", Listebapteme);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtserviteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm.Code_Servi = dao.IdCombo("Serviteur","code",txtserviteur.Text,"nom_complet");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_bapteme where Baptisé like '%" + rech1.Text + "%'", Listebapteme);

        }

        private void Listebapteme_Click(object sender, EventArgs e)
        {
           
        }

        private void Listebapteme_Click_1(object sender, EventArgs e)
        {
            try
            {
                code.Text = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
                txtnom.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
                txtserviteur.Text = Listebapteme.SelectedRows[0].Cells[2].Value.ToString();
                dao.Photos(profile, "Membre", txtnom.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void date_onValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = date.Value.ToString();
        }

        private void txtdate_Leave(object sender, EventArgs e)
        {
            if (txtdate.Text=="")
            {
                txtdate.Text = "Date";
            }
        }

        private void txtdate_Enter(object sender, EventArgs e)
        {

            if (txtdate.Text == "Date")
            {
                txtdate.Text = "";
            }
        }

        private void Listemembre_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmrapportBapteme rpb = new FrmrapportBapteme();
            rpb.ShowDialog();
        }
    }
}
