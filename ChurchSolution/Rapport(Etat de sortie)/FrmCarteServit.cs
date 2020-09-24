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
    public partial class FrmCarteServit : Form
    {
        public FrmCarteServit()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        private void btnsuite_Click(object sender, EventArgs e)
        {
            rapport();
        }
        public void rapport()
        {
            try
            {
                Carteservit cr = new Carteservit();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select * from v_serviteur WHERE nom ='" + rech.Text + "'";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "v_serviteur");
                cr.SetDataSource(dao.daset.Tables["v_serviteur"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text == "")
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

        private void rech_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCarteServit_Load(object sender, EventArgs e)
        {
            dao.Autocomplete("SELECT nom FROM v_serviteur", "nom", rech);
            dao.chargerCombo("select nom_cellule from CELLULE","nom_cellule",txtcellule);
        }

        private void txtcellule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcellule_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Carteservit cr = new Carteservit();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select * from v_serviteur WHERE nom_CELLULE ='" + txtcellule.Text + "'";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "v_serviteur");
                cr.SetDataSource(dao.daset.Tables["v_serviteur"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }

}

