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

namespace ChurchSolution.FormulairePrincipale
{
    public partial class AjouterCompte : Form
    {
        public AjouterCompte()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int code;
        int code_classe;
        private void btnsuite_Click(object sender, EventArgs e)
        {
            if (txtclasse.Text==""||txtcompte.Text==""||txtnume.Text=="")
            {
                fx.Messages(3);
            }
            else
            {
                try
                {
                    string rqt = "exec [AjoutCompte] '" + txtnume.Text + "','"+txtclasse.Text+"','" + txtcompte.Text + "'";
                    dao.Executer(rqt);
                    initialise();
                }
                catch (Exception ex)
                {

                }
            }

        }
        void initialise()
        {
            txtclasse.Text = "";
            txtcompte.Text = "";
            txtnume.Text = "";

        }
        private void AjouterCompte_Load(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
