using ChurchSolution.ClasseFonction;
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
    public partial class FrmparametreAll : Form
    {
        public FrmparametreAll()
        {
            InitializeComponent();
        }

        classMenu clm = new classMenu();
        private void FrmparametreAll_Load(object sender, EventArgs e)
        {
          clm.openChildForm(new FrmUser(), panelsecond);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmUser(),panelsecond);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new Configuration(),panelsecond);
        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmBackup(), panelsecond);
        }
    }
}
