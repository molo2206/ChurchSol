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
    public partial class FrmListeOperation : Form
    {
        public FrmListeOperation()
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
                ListedesOperations cr = new ListedesOperations();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select * from V_Operation___ where adddate between CONVERT(date, '" + da1 + "', 103) and CONVERT(date,'" + da2 + "', 103)";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "[V_Operation___]");
                cr.SetDataSource(dao.daset.Tables["[V_Operation___]"]);
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

        private void btnsuite_Click(object sender, EventArgs e)
        {
            //if (txtdebut.Text== "Entrée")
            //{
            //    txtdebut.Text = "Sortie";
            //}
            //else
            //{
            //    txtdebut.Text = "Entrée";
            //}
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //if (txtdebut.Text=="Entrée")
            //{
            //    try
            //    {
            //        ListedesOperations cr = new ListedesOperations();
            //        dao.InitialiserConnexion();
            //        if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
            //        string rqt = "select * from V_Operation___ where type='"+txtdebut.Text+"'";
            //        dao.daset = new DataSet();
            //        dao.dp = new SqlDataAdapter(rqt, dao.conn);
            //        dao.dp.Fill(dao.daset, "[V_Operation___]");
            //        cr.SetDataSource(dao.daset.Tables["[V_Operation___]"]);
            //        crystalReportViewer1.ReportSource = cr;
            //    }
            //    catch (Exception ex) { MessageBox.Show(ex.Message); }
            //}
            //else
            //{
            //    try
            //    {
            //        ListedesOperations cr = new ListedesOperations();
            //        dao.InitialiserConnexion();
            //        if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
            //        string rqt = "select * from V_Operation___ where type='" + txtdebut.Text + "'";
            //        dao.daset = new DataSet();
            //        dao.dp = new SqlDataAdapter(rqt, dao.conn);
            //        dao.dp.Fill(dao.daset, "[V_Operation___]");
            //        cr.SetDataSource(dao.daset.Tables["[V_Operation___]"]);
            //        crystalReportViewer1.ReportSource = cr;
            //    }
            //    catch (Exception ex) { MessageBox.Show(ex.Message); }
            //}
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string da1 = txtdate.Value.ToString("dd/MM/yyyy");
            string da2 = txtdate1.Value.ToString("dd/MM/yyyy");
            try
            {
                Journal cr = new Journal();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select * from Journal_Filtre where adddate between CONVERT(date, '" + da1 + "', 103) and CONVERT(date,'" + da2 + "', 103)";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "[Journal_Filtre]");
                cr.SetDataSource(dao.daset.Tables["[Journal_Filtre]"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
