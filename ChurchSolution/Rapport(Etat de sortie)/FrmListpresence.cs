using ChurchSolution.ClassePrincipale;
using ChurchSolution.FormulairePrincipale;
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
    public partial class FrmListpresence : Form
    {
        public FrmListpresence()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        private void FrmListpresence_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string da1 = txtdate.Value.ToString("dd/MM/yyyy");
            try
            {
                RapportPresence cr = new RapportPresence();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select* from V_SELECT_PRESENCE where CONVERT(date, DATE_PRESENCE, 103) = CONVERT(date, '" + da1+"', 103)";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "V_SELECT_PRESENCE");
                cr.SetDataSource(dao.daset.Tables["V_SELECT_PRESENCE"]);
                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtdate_onValueChanged(object sender, EventArgs e)
        {
            dd.Text = txtdate.Value.ToString();
        }
    }
}
