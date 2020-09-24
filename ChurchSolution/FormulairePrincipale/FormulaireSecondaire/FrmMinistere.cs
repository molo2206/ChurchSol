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

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    public partial class FrmMinistere : Form
    {
        public FrmMinistere()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtministere.Text.Equals(""))
                {
                    fx.Messages(2);
                }
                else
                {
                    string rqt = "exec [Add_Ministere]'"+txtidenti.Text+"','"+txtministere.Text.ToUpper()+"'";
                    dao.Executer(rqt);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text=="")
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

        private void FrmMinistere_Load(object sender, EventArgs e)
        {
            dao.Autocomplete("select designation from ministere", "designation", rech);

        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            txtidenti.Text = dao.CodeMinistere(rech.Text);
            txtministere.Text = dao.Ministere(rech.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
