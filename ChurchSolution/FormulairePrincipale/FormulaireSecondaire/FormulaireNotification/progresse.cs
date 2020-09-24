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

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification
{
    public partial class progresse : Form
    {
        public progresse()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ProgressBar1__.Value = ProgressBar1__.Value + 10;
                if (ProgressBar1__.Value > 99)
                {
                    FrmLogin fr = new FrmLogin();
                    fr.Show();
                    timer1.Enabled = false;
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void progresse_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
