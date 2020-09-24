using ChurchSolution.ClasseFonction;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification;
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
    public partial class PersonnelAll : Form
    {
        public PersonnelAll()
        {
            InitializeComponent();
        }

        classMenu clm = new classMenu();
        Clsfonctions fx = new Clsfonctions();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void PersonnelAll_Load(object sender, EventArgs e)
        {
            clm.openChildForm(new Presence(),panelsecond);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new Presence(), panelsecond);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new ListeAgent(), panelsecond);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new ListePresence(), panelsecond);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new Mouvement(), panelsecond);
        }
    }
}
