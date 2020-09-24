using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtuser;
            txtuser.Focus();
        }
        ClsDAO dao = new ClsDAO();
        ClsLogin lg = new ClsLogin();
        Clsfonctions fx = new Clsfonctions();
        logine log = new logine();
        classMenu mn = new classMenu();
        Form1 frm = new Form1();

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
        public void loguer(ClsLogin l)
        {
            l.NomUser = txtuser.Text;
            l.Pwd = txtpwd.Text;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            progress.Visible = false;
            if (!Directory.Exists("C:\\church"))
            {
                Directory.CreateDirectory("C:\\church");
                File.Create("C:\\church\\Connexion.txt");
                File.Create("C:\\church\\user.txt");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        string fichier;

        private void btnsuite_Click(object sender, EventArgs e)
        {
            if (txtuser.Text=="" || txtpwd.Text=="" )
            {
                fx.Messages(3);
            }
            else
            {
                this.timer1.Start();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpwd_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsuite.PerformClick();
            }
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtpwd.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                txtpwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtpwd.UseSystemPasswordChar = true;
            }
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            if (txtpwd.Text == "")
            {
                message.Text = "";
                progress.Visible = false;
            }
           
        }

        private void txtuser_OnValueChanged(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                message.Text = "";
                progress.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
                progress.Visible = true;
                try
                {
                    progress.Value = progress.Value + 10;
                    if (progress.Value > 99)
                    {
                        this.loguer(lg);

                        if (log.login(lg) == true)
                        {
                            frm.id.Text = lg.IdAgent.ToString();
                            frm.user.Text = lg.NomUser.ToUpper();
                            frm.fonction.Text = lg.Fonction1.ToLower();
                            frm.niveau_acce = lg.Niveau1;
                            frm.codeutili.Text = lg.Code;
                            frm.Show();
                            this.Hide();
                            this.timer1.Enabled = false;
                        }
                        else
                        {
                        try
                        {
                            message.ForeColor = Color.Red;
                            message.Text = "Mot de passe ou nom utilisateur incorrecte";
                            this.timer1.Enabled = false;
                            progress.Visible = false;
                            progress.Value = progress.Value - 10;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    }
                   
                }
                catch (Exception ex)
                {
                }
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\church\\Connexion.txt"))
            {
                fx.Messages(7);
            }
            else
            {
                FrmConf con = new FrmConf();
                con.ShowDialog();
            }
        }
    }
}
