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
    public partial class AutreConf : Form
    {
        public AutreConf()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
            FrmConf con = new FrmConf();
            con.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
