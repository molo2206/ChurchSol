using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire;
using ChurchSolution.FormulaireSecondaire;
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

namespace ChurchSolution.FormulairePrincipale
{
    public partial class FormulairePrincipal : Form
    {
        public FormulairePrincipal()
        {
            InitializeComponent();
        }
        classMenu clm = new classMenu();
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsLogin lg = new ClsLogin();
        ClsMembreInsertion mb = new ClsMembreInsertion();
        ClsLogin log = new ClsLogin();
        public int niveau_acce;
        int code;
        private void FormulairePrincipal_Load(object sender, EventArgs e)
        {
            fx.Picture_Rond(profile);
            clm.openChildForm(new DashBord(), panelPrincipale);
            noitify();
            dao.Photo("agent", id.Text, profile);
            niveau.Text = niveau_acce.ToString();
            File.WriteAllText("C:\\chemin\\user.txt", codeutili.Text);
        }
        public void noitify()
        {
            notifyIcon1.Icon = new System.Drawing.Icon("icon.ico");
            notifyIcon1.Text = "Lancement de l'application";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
            notifyIcon1.BalloonTipText = "Church solution";
            notifyIcon1.BalloonTipTitle = "Message Infos";
            notifyIcon1.ShowBalloonTip(100);
        }

        private void niveau_Click(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {
            FrmUtilisateur fr = new FrmUtilisateur();
            fr.txtuser.Text = (user.Text);
            fr.txtcodeagent.Text = id.Text;
            fr.txtfonction.Text = fonction.Text;
            fr.txtcodeutili.Text = codeutili.Text;
            fr.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Etes-vous sûr de vouloir déconnecter", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes))
            {
             this.Hide();
                FrmLogin f = new FrmLogin();
                f.txtuser.Text = user.Text;
                f.Show();
            }
        }

        private void dash1_Click(object sender, EventArgs e)
        {

            if (niveau_acce < 7)
            {
                clm.openChildForm(new DashBord(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void dash_Click(object sender, EventArgs e)
        {

            if (niveau_acce < 7)
            {
                clm.openChildForm(new DashBord(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void nouveau1_Click(object sender, EventArgs e)
        {
            if (niveau_acce < 7)
            {
                clm.openChildForm(new EntrementAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            if (niveau_acce < 7)
            {
                clm.openChildForm(new EntrementAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void culte1_Click(object sender, EventArgs e)
        {
            if (niveau_acce <= 4)
            {
                clm.openChildForm(new OperationAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }

        }

        private void culte_Click(object sender, EventArgs e)
        {
            if (niveau_acce <= 4)
            {
                clm.openChildForm(new OperationAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmOperation_(), panelPrincipale);

        }

        private void operation1_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmOperation_(), panelPrincipale);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmComptabilite(), panelPrincipale);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmComptabilite(), panelPrincipale);
        }

        private void person_Click(object sender, EventArgs e)
        {
            if (niveau_acce > 7)
            {
                clm.openChildForm(new PersonnelAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void person1_Click(object sender, EventArgs e)
        {
            if (niveau_acce > 7)
            {
                clm.openChildForm(new PersonnelAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void parametre_Click(object sender, EventArgs e)
        {
            if (niveau_acce == 7)
            {
                clm.openChildForm(new FrmparametreAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void parametre1_Click(object sender, EventArgs e)
        {
            if (niveau_acce == 7)
            {
                clm.openChildForm(new FrmparametreAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }
    }
}
