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
    public partial class FrmFonctionnalite : Form
    {
        public FrmFonctionnalite()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        FrmAhent f = new FrmAhent();
        private void FrmFonctionnalite_Load(object sender, EventArgs e)
        {
            dao.Autocomplete("select designation from menu", "designation", rech);
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmenu.Text == "")
                {
                    fx.Messages(2);
                }
                else
                {
                    string rqt = "exec [Ajout_menu] '" + txtidenti.Text + "','" + txtmenu.Text + "'";
                    dao.Executer(rqt);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            txtmenu.Text = dao.Menu(rech.Text);
            txtidenti.Text = dao.Menu_Code(rech.Text);
        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text == "")
            {
                rech.Text = "Rechercher";
            }
        }

        private void rech_Enter(object sender, EventArgs e)
        {
            if (rech.Text == "Rechercher")
            {
                rech.Text = "";
            }
        }
    }
}
