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
    public partial class FrmConf : Form
    {
        public FrmConf()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        private void btnsuite_Click(object sender, EventArgs e)
        {
            if (txtpwd.Text!="ZABM")
            {
                fx.Messages(2);
            }
            else
            {
                Configuration co = new Configuration();
                co.ShowDialog();
                this.Hide();
            }
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnsuite.PerformClick();
            }
        }
    }
}
