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
    public partial class Frmcaisse : Form
    {
        public Frmcaisse()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        float entre;
        float sortie;
        float solde;

        float entre_j;
        float sortie_j;
        float solde_j;
        public void Calcule()
        {
            try
            {
                entre = float.Parse(txtentre.Text);
                sortie = float.Parse(txtsortie.Text);
                solde = (entre - sortie);
                txtsolde.Text = solde.ToString();
                if (solde < 0)
                {
                    txtsolde.ForeColor = Color.Red;
                }
                entre_j = float.Parse(txtentre_j.Text);
                sortie_j = float.Parse(txtsortie_j.Text);
                solde_j = (entre_j - sortie_j);
                txtsolde_j.Text = solde_j.ToString();
                if (solde_j < 0)
                {
                    txtsolde_j.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmcaisse_Load(object sender, EventArgs e)
        {
            txtentre_j.Text = dao.nombre("select Montant_entre from [V_entre_journaliere] ", "Montant_entre");
            txtsortie_j.Text = dao.nombre("select Montant_sortie from [V_sortie_journaliere] ", "Montant_sortie");
            if (txtsortie_j.Text == "")
            {
                txtsortie_j.Text = "0";
            }

            txtentre.Text = dao.nombre("select Montant_entre from V_entre ", "Montant_entre");
            txtsortie.Text = dao.nombre("select Montant_sortie from V_sortie ", "Montant_sortie");
            Calcule();
        }
    }
}
