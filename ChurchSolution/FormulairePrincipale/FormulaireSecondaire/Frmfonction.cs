using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.FormulaireSecondaire;
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
    public partial class Frmfonction : Form
    {
        public Frmfonction()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        FrmAhent f = new FrmAhent();
        private void btnsuite_Click(object sender, EventArgs e)
        {
         
            try
            {
                if (txtfonction.Text=="")
                {
                    fx.Messages(2);
                }
                else
                {
                    string rqt = "exec Add_Fonction '"+txtidenti.Text+"','"+txtfonction.Text.ToUpper()+"'";
                    dao.Executer(rqt);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            txtfonction.Text=dao.Recherchefonction(rech.Text);
            txtidenti.Text = dao.fonction(rech.Text);
        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text=="")
            {
                rech.Text = "Rechercher";
            }
        }

        private void txtfonction_Enter(object sender, EventArgs e)
        {

        }

        private void rech_Enter(object sender, EventArgs e)
        {

            if (rech.Text == "Rechercher")
            {
                rech.Text = "";
            }
        }

        private void Frmfonction_Load(object sender, EventArgs e)
        {
            dao.Autocomplete("select designation from fonction","designation",rech);
            
        }
    }
}
