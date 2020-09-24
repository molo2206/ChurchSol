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
    public partial class FrmCompte : Form
    {
        public FrmCompte()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        private void btnsuite_Click(object sender, EventArgs e)
        {
            AjouterCompte aj = new AjouterCompte();
            aj.ShowDialog();
        }

        private void FrmCompte_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_compte", Listebapteme);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_compte", Listebapteme);
        }

        private void reche_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_compte where code like '%"+reche.Text+"%' or compte like '%"+reche.Text+"%' or classe like '%"+reche.Text+"%'", Listebapteme);
        }

        private void Listebapteme_Click(object sender, EventArgs e)
        {
            AjouterCompte aj = new AjouterCompte();
            aj.txtnume.Text = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
            aj.txtcompte.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
            aj.txtclasse.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
            aj.ShowDialog();
        }
    }
}
