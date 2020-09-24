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

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification
{
    public partial class FrmAfficher : Form
    {
        public FrmAfficher()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmValidation f = new FrmValidation();
            f.code.Text = txttype.Text;
            f.label6.Text = label1.Text;
            this.Close();
            f.ShowDialog();          
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
