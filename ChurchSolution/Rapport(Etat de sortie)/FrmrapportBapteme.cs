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
    public partial class FrmrapportBapteme : Form
    {
        public FrmrapportBapteme()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string da1 = p1.Value.ToString("dd/MM/yyyy");
            string da2 = p2.Value.ToString("dd/MM/yyyy");
            try
            {
                Rapportbapteme cr = new Rapportbapteme();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select* from V_bapteme where DATE_BAPTE between CONVERT(date, '"+da1+"', 103) and CONVERT(date,'"+da2+"', 103)";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "V_bapteme");
                cr.SetDataSource(dao.daset.Tables["V_bapteme"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bunifuDatepicker3_onValueChanged(object sender, EventArgs e)
        {
            date1.Text = p1.Value.ToString();
        }

        private void p2_onValueChanged(object sender, EventArgs e)
        {
            date2.Text = p2.Value.ToString();
        }

        private void FrmrapportBapteme_Load(object sender, EventArgs e)
        {
            dao.chargerCombo("select nom_cellule from cellule", "nom_cellule", txtcellule);
            dao.Autocomplete("select Baptisé from v_bapteme", "Baptisé",rech);
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtdate_onValueChanged(object sender, EventArgs e)
        {
            dd.Text = txtdate.Value.ToString();
        }

        private void txtdate1_onValueChanged(object sender, EventArgs e)
        {
            ddd.Text = txtdate1.Value.ToString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string da1 = txtdate.Value.ToString("dd/MM/yyyy");
            string da2 = txtdate1.Value.ToString("dd/MM/yyyy");
            try
            {
                Rapportbapteme cr = new Rapportbapteme();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select* from V_bapteme where DATE_BAPTE between CONVERT(date, '" + da1 + "', 103) and CONVERT(date,'" + da2 + "', 103) and nom_cellule='" + txtcellule.Text + "'";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "V_bapteme");
                cr.SetDataSource(dao.daset.Tables["V_bapteme"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text.Equals(""))
            {
                rech.Text = "Rechercher le nom";
            }
        }

        private void rech_Enter(object sender, EventArgs e)
        {
            if (rech.Text.Equals("Rechercher le nom"))
            {
                rech.Text = "";
            }
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {
                carteBapteme cr = new carteBapteme();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select * from V_bapteme where Baptisé='"+rech.Text+"'";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "V_bapteme");
                cr.SetDataSource(dao.daset.Tables["V_bapteme"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
