using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
using ChurchSolution.FormulairePrincipale;
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

namespace ChurchSolution
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private void label2_Click(object sender, EventArgs e)
        {
            if (niveau_acce >=4)
            {
                clm.openChildForm(new EntrementAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void noitify()
        {
            notifyIcon1.Icon = new System.Drawing.Icon("icon.ico");
            notifyIcon1.Text = "Starting Church Solution";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
            notifyIcon1.BalloonTipText = "Church solution";
            notifyIcon1.BalloonTipTitle = "Message Infos";
            notifyIcon1.ShowBalloonTip(100);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fx.Picture_Rond(profile);
            clm.openChildForm(new DashBord(), panelPrincipale);
            noitify();
            dao.Photo("agent", id.Text, profile);
            niveau.Text = niveau_acce.ToString();
            File.WriteAllText("C:\\church\\user.txt",codeutili.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {
                clm.openChildForm(new DashBord(), panelPrincipale);     
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

        private void panelPrincipale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new DashBord(), panelPrincipale);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (niveau_acce >= 4)
            {
                clm.openChildForm(new EntrementAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (niveau_acce >= 4)
            {
                clm.openChildForm(new PersonnelAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (niveau_acce >=4)
            {
                clm.openChildForm(new OperationAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

        private void profile_Click(object sender, EventArgs e)
        {

            FrmUtilisateur fr = new FrmUtilisateur();
            fr.txtuser.Text = (user.Text);
            fr.txtcodeagent.Text = id.Text;
            fr.txtfonction.Text = fonction.Text;
            fr.txtcodeutili.Text = codeutili.Text;
            fr.ShowDialog();
        }

        private void rech1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void culte_Click(object sender, EventArgs e)
        {
            if (niveau_acce >= 4)
            {
                clm.openChildForm(new OperationAll(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void person_Click(object sender, EventArgs e)
        {
            if (niveau_acce >=4)
            {
                clm.openChildForm(new PersonnelAll(), panelPrincipale);
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
        FrmOperation_ f = new FrmOperation_();
        private void operation1_Click(object sender, EventArgs e)
        {
            if (niveau_acce >= 5 || fonction.Text=="SECRETAIRE")
            {
                clm.openChildForm(new FrmOperation_(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            if (niveau_acce >= 6)
            {
                clm.openChildForm(new FrmComptabilite(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            if (niveau_acce <= 5)
            {
                clm.openChildForm(new FrmOperation_(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (niveau_acce >= 6)
            {
                clm.openChildForm(new FrmOperation_(), panelPrincipale);
            }
            else
            {
                fx.Messages(6);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
