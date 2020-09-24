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
    public partial class OperationAll : Form
    {
        public OperationAll()
        {
            InitializeComponent();
            visualiser_menu();
        }
        classMenu clm = new classMenu();
        Clsfonctions fx = new Clsfonctions();
        private void Listemembre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
        }

        private void OperationAll_Load(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmBapteme(), panelsecond);
        }
        private void hidemenu()
        {
            if (paneloffici.Visible == true)
                paneloffici.Visible = false;
        }
        private void Shosubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidemenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }
        private void visualiser_menu()
        {
            paneloffici.Visible=false;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnculte_Click(object sender, EventArgs e)
        {
            Shosubmenu(paneloffici);
        }

        private void btnnouveau_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmBapteme(), panelsecond);
        }

        private void btnservi_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmConcencration(), panelsecond);
        }

        private void btnvisiteur_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmCulte(), panelsecond);
        }

        private void btnpredi_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmPreducateur(), panelsecond);
        }

        private void btnmodera_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmModerateur(), panelsecond);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmVisiteur(), panelsecond);
        }
    }
}
