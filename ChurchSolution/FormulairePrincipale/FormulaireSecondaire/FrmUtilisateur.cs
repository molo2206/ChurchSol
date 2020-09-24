using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
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
    public partial class FrmUtilisateur : Form
    {
        public FrmUtilisateur()
        {
            InitializeComponent();
        }
        ClsLogin lg = new ClsLogin();
        Clsfonctions fx = new Clsfonctions();
        logine log = new logine();
        Form1 frm = new Form1();
        ClsDAO dao = new ClsDAO();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {
            fx.Picture_Rond(profile);
            dao.Photo("agent", txtcodeagent.Text,profile);
            txtconfir.Enabled = false;
            point.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
        }

        private void deconnecte_Paint(object sender, PaintEventArgs e)
        {

        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
     

        }
        public void loguer(ClsLogin l)
        {
            l.NomUser = txtuser.Text;
            l.Pwd = txtpwd.Text;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals("") || txtpwd.Text.Equals(""))
            {
                fx.Messages(3);
            }
            else
            {
                try
                {
                    this.loguer(lg);

                    if (log.login(lg) == true)
                    {
                        txtconfir.Enabled = true;
                        txtconfir.BackColor = Color.SeaShell;
                        nouveau.Text = "Nouveau mot de passe";
                        nouveau.ForeColor = Color.Red;
                        point.Visible = true;
                    }
                    else
                    {
                        fx.Messages(2);

                        txtconfir.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                }

            }
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text.Equals("") || txtpwd.Text.Equals("Entrez") || txtconfir.Enabled.Equals(false))
                {
                    fx.Messages(5);
                }
                else
                {
                    lg.Code = txtcodeutili.Text;
                    lg.NomUser = txtuser.Text;
                    lg.Pwd = txtconfir.Text;
                    string rqt = "exec [AjoutUtilisateur] '" + lg.Code + "','" + lg.NomUser + "','" + lg.Pwd + "'";
                    dao.Executer(rqt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
