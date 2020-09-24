using ChurchSolution.ClasseFonction;
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
    public partial class FrmEntree : Form
    {
        public FrmEntree()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        ClsLogin log = new ClsLogin();
        int code;
        Form1 fr = new Form1();
        float montant;
        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmontant.Text=="" || txtlettre.Text=="" || txtdevise.Text==""||txtbenefi.Text==""||txtmotif.Text=="")
                {
                    fx.Messages(3);
                }
                else
                {               
                     string rqt = "exec [AddOperation]'"+ code + "','"+txttype.Text+"','"+ txtmontant.Text + "','"+txtdevise.Text+"','"+txtlettre.Text+"','"+txtbenefi.Text+"','"+txtmotif.Text+"','"+label10.Text+"'";
                     dao.Executer(rqt);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtdevise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (txtdevise.Text == "Sélectionner la devise")
            {
                txtdevise.Text = "";
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (txtdevise.Text=="")
            {
                txtdevise.Text = "Sélectionner la devise";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEntree_Load(object sender, EventArgs e)
        {
           label10.Text = File.ReadAllText("C:\\church\\user.txt");
            dao.chargerlist("select code from[V_Operation_fINISH]", "code",listBox1);
            dao.chargerlist("select * from [V_Operation]", "code", listBox2);
            label3.Text = dao.MaxId("Operation");
        }
        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void txtlettre_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtlettre_Enter(object sender, EventArgs e)
        {
            if (txtlettre.Text== "Montant en toute lettre")
            {
                txtlettre.Text = "";
            }
        }

        private void txtbenefi_Enter(object sender, EventArgs e)
        {
            if (txtbenefi.Text== "Nom du bénéficiaire")
            {
                txtbenefi.Text = "";
            }
        }

        private void txtbenefi_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtlettre_Leave_1(object sender, EventArgs e)
        {
            if (txtlettre.Text == "")
            {
                txtlettre.Text = "Montant en toute lettre";
            }
        }

        private void txtlettre_Enter_1(object sender, EventArgs e)
        {
            if (txtlettre.Text == "Montant en toute lettre")
            {
                txtlettre.Text = "";
            }
        }

        private void txtbenefi_Leave_1(object sender, EventArgs e)
        {
            if (txtbenefi.Text == "")
            {
                txtbenefi.Text = "Nom du bénéficiaire";
            }
        }

        private void txtbenefi_Enter_1(object sender, EventArgs e)
        {
            if (txtbenefi.Text == "Nom du bénéficiaire")
            {
                txtbenefi.Text = "";
            }
        }

        private void iTalk_TabControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtmontant_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtmontant_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}
