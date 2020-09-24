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
    public partial class Frmrapportconcencration : Form
    {
        public Frmrapportconcencration()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string da1 = txtdate.Value.ToString("dd/MM/yyyy");
            string da2 = txtdate1.Value.ToString("dd/MM/yyyy");
            try
            {
                Rapportconcencration cr = new Rapportconcencration();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select* from [V_Concencration] where date between CONVERT(date, '" + da1 + "', 103) and CONVERT(date,'" + da2 + "', 103) and cellule='" + txtcellule.Text + "'";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "[V_Concencration]");
                cr.SetDataSource(dao.daset.Tables["[V_Concencration]"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtdate_onValueChanged(object sender, EventArgs e)
        {
            dd.Text = txtdate.Value.ToString();
        }

        private void txtdate1_onValueChanged(object sender, EventArgs e)
        {
            ddd.Text = txtdate1.Value.ToString();
        }

        private void p1_onValueChanged(object sender, EventArgs e)
        {
            date1.Text = p1.Value.ToString();
        }

        private void p2_onValueChanged(object sender, EventArgs e)
        {
            date2.Text = p2.Value.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string da1 = p1.Value.ToString("dd/MM/yyyy");
            string da2 = p2.Value.ToString("dd/MM/yyyy");
            try
            {
                Rapportconcencration cr = new Rapportconcencration();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select* from V_Concencration where date between CONVERT(date, '" + da1 + "', 103) and CONVERT(date,'" + da2 + "', 103)";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "V_Concencration");
                cr.SetDataSource(dao.daset.Tables["V_Concencration"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnsuite_Click(object sender, EventArgs e)
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

        private void Frmrapportconcencration_Load(object sender, EventArgs e)
        {
            dao.Autocomplete("select nom from v_serviteur ", "nom",rech);
            dao.chargerCombo("select nom_cellule from cellule", "nom_cellule",txtcellule);
        }
    }
}
