using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.Repport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.Rapport_Etat_de_sortie_
{
    public partial class FrmCarte : Form
    {
        public FrmCarte()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        private void FrmCarte_Load(object sender, EventArgs e)
        {
            dao.Autocomplete("SELECT NOM_COMPLET FROM agent", "NOM_COMPLET", rech);
        }
        public void rapport()
        {
            try
            {
                carte cr = new carte();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select NOM_COMPLET, EMAIL, PHONE, PHOTO, barcode from AGENT WHERE nom_complet ='" + rech.Text + "'";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "agent");
                cr.SetDataSource(dao.daset.Tables["agent"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            rapport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text=="")
            {
                rech.Text = "Rechercher le nom";
            }
        }

        private void rech_Enter(object sender, EventArgs e)
        {
            if (rech.Text == "Rechercher le nom")
            {
                rech.Text = "";
            }
        }
    }
}
