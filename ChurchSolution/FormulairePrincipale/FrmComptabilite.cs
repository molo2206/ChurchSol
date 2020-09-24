using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire;
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
    public partial class FrmComptabilite : Form
    {
        public FrmComptabilite()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        classMenu clm = new classMenu();
        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmCompte(),panelsecond);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmJournalisation(), panelsecond);
        }

        private void FrmComptabilite_Load(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmCompte(), panelsecond);
        }
    }
}
