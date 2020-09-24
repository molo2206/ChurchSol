using ChurchSolution.ClasseFonction;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire;
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

namespace ChurchSolution.FormulairePrincipale
{
    public partial class EntrementAll : Form
    {
        public EntrementAll()
        {
            InitializeComponent();
        }
        classMenu clm = new classMenu();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmMembre(),panelsecond);
        }

        private void EntrementAll_Load(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmMembre(), panelsecond);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmMembre(), panelsecond);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmAhent(), panelsecond);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmServiteur(), panelsecond);
        }
    }
}
