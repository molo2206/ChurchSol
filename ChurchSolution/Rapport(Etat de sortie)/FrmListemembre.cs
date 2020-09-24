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
    public partial class FrmListemembre : Form
    {
        public FrmListemembre()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        private void FrmListemembre_Load(object sender, EventArgs e)
        {
            dao.chargerCombo("select nom_cellule from cellule", "nom_cellule", txtcellule);
        }

        private void txtcellule_SelectedIndexChanged(object sender, EventArgs e)
        {
            rapport();
        }
        public void rapport()
        {
            try
            {
                RapportMembre cr = new RapportMembre();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select nom_complet,sexe,etat_civil,adresse,phone,nom_cellule  from v_membre WHERE nom_cellule ='" + txtcellule.Text + "'";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "v_membre");
                cr.SetDataSource(dao.daset.Tables["v_membre"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
