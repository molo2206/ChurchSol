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
    public partial class FrmrapportCulte : Form
    {
        public FrmrapportCulte()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string da1 = txtdate.Value.ToString("dd/MM/yyyy");
            string da2 = txtdate1.Value.ToString("dd/MM/yyyy");
            try
            {
                Rapportculte cr = new Rapportculte();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select* from V_CULTE where DATE_CULTE between CONVERT(date, '" + da1 + "', 103) and CONVERT(date,'" + da2 + "', 103) and cellule='" + txtcellule.Text + "'";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "V_CULTE");
                cr.SetDataSource(dao.daset.Tables["V_CULTE"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        ClsDAO dao = new ClsDAO();
        private void FrmrapportCulte_Load(object sender, EventArgs e)
        {
            dao.chargerCombo("select nom_cellule from cellule ","nom_cellule",txtcellule);
        }

        private void txtdate_onValueChanged(object sender, EventArgs e)
        {
            dd.Text = txtdate.Value.ToString();
        }

        private void txtdate1_onValueChanged(object sender, EventArgs e)
        {
            ddd.Text = txtdate1.Value.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string da1 = p1.Value.ToString("dd/MM/yyyy");
            string da2 = p2.Value.ToString("dd/MM/yyyy");
            try
            {
                Rapportculte cr = new Rapportculte();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select * from V_CULTE where DATE_CULTE between CONVERT(date, '" + da1 + "', 103) and CONVERT(date,'" + da2 + "', 103)";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "V_CULTE");
                cr.SetDataSource(dao.daset.Tables["V_CULTE"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void p1_onValueChanged(object sender, EventArgs e)
        {
            date1.Text = p1.Value.ToString();
        }

        private void p2_onValueChanged(object sender, EventArgs e)
        {
            date2.Text = p2.Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
