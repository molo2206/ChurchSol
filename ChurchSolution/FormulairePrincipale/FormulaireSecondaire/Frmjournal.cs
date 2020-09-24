using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
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
    public partial class Frmjournal : Form
    {
        public Frmjournal()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmjournal_Load(object sender, EventArgs e)
        {
            user = File.ReadAllText("C:\\church\\user.txt");
            dao.chargementGridOptimise("select * from V_Operation_encoure where code not in (select codeOperation from Journal)", Listebapteme);
            dao.Autocomplete("select designation from COMPTE", "designation", txtcompte1);
            dao.Autocomplete("select designation from COMPTE", "designation", txtcompte2);
            label7.Text=dao.chargerNombre("v_non_journaliser", "count(code)");
            txtdate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Listebapteme_Click(object sender, EventArgs e)
        {
            try
            {
                txtcode.Text = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
                txttype.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
                txtmontant.Text = Listebapteme.SelectedRows[0].Cells[2].Value.ToString();
                txtdevise.Text = Listebapteme.SelectedRows[0].Cells[3].Value.ToString();
                txtben.Text = Listebapteme.SelectedRows[0].Cells[4].Value.ToString();
                motif.Text = Listebapteme.SelectedRows[0].Cells[5].Value.ToString();
                txtmotif.Text= Listebapteme.SelectedRows[0].Cells[5].Value.ToString().ToUpper();
            }
            catch (Exception ex)
            {

            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void motif_Leave(object sender, EventArgs e)
        {
            if (motif.Text=="")
            {
                motif.Text = "Entrer le motif";
            }
        }

        private void motif_Enter(object sender, EventArgs e)
        {
            if (motif.Text == "Entrer le motif")
            {
                motif.Text = "";
            }
        }

        private void txtcompte1_Leave(object sender, EventArgs e)
        {
            if (txtcompte1.Text=="")
            {
                txtcompte1.Text = "Entrer ici le compter à débuter";
            }
        }

        private void txtcompte1_Enter(object sender, EventArgs e)
        {
            if (txtcompte1.Text == "Entrer ici le compter à débuter")
            {
                txtcompte1.Text = "";
            }
        }

        private void txtcompte2_Enter(object sender, EventArgs e)
        {
            if (txtcompte2.Text == "Entrer ici le compter à créditer")
            {
                txtcompte2.Text = "";
            }
        }

        private void txtcompte2_Leave(object sender, EventArgs e)
        {
            if (txtcompte2.Text=="")
            {
                txtcompte2.Text = "Entrer ici le compter à créditer";
            }
        }
        string user;
        private void btnsuite_Click(object sender, EventArgs e)
        {
           int oper =int.Parse(txtcode.Text);
            try
            {
                string rqt = "exec [Journalisation] '"+txtdebut.Text+"','"+txtfin.Text+"','"+code_compte1+"','"+code_compte2+"','"+ oper + "','"+txtmontant.Text+"','"+txtdevise.Text+"','"+motif.Text+"','"+ user+ "'";
                dao.Executer(rqt);
                dao.chargementGridOptimise("select * from V_Operation_encoure where code not in (select codeOperation from Journal)", Listebapteme);
                label7.Text = dao.chargerNombre("v_non_journaliser", "count(code)");
            }
            catch (Exception ex)
            {
                
            }
        }
        string code_compte1;
        string code_compte2;
        private void txtcompte1_TextChanged(object sender, EventArgs e)
        {
            code_compte1=dao.IdCombo("Compte","codes",txtcompte1.Text,"designation");
        }

        private void txtcompte2_TextChanged(object sender, EventArgs e)
        {
            code_compte2 = dao.IdCombo("Compte", "codes", txtcompte2.Text, "designation");
        }

        private void reche_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_Operation_encoure where code like '%" + reche.Text + "%' or Motif like'%" + reche.Text + "%' or Montant like'%" + reche.Text + "%'", Listebapteme);
        }
    }
}
