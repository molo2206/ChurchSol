using ChurchSolution.AutresRapport;
using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.Rapport_Etat_de_sortie_;
using DevExpress.XtraReports.UI;
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
    public partial class FrmJournalisation : Form
    {
        public FrmJournalisation()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();

        ClsRapports clr = new ClsRapports();
        private void btnsuite_Click(object sender, EventArgs e)
        {
            Frmjournal j = new Frmjournal();
            j.ShowDialog();
        }

        private void FrmJournalisation_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_Journal",Listebapteme);
        }

        private void Listebapteme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_Journal", Listebapteme);
        }
        private void reche_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_Journal where codeOperation like '%" +reche.Text+ "%' or Libelle like'%"+reche.Text+ "%' or Montant like'%"+reche.Text+"%'", Listebapteme);
        }
        private void date_onValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = date.Value.ToString();
            string dates = date.Value.ToString("dd/MM/yyy");
            dao.chargementGridOptimise("select * from [V_Journal] where convert(varchar(10), AddDate, 103) like convert(varchar(10), '" + dates + "', 103)", Listebapteme);
       
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string da1 = dates1.Value.ToString("yyyy/MM/dd");
            string da2 = dates2.Value.ToString("yyyy/MM/dd");
            if (dd.Text == "" || ddd.Text == "")
            {
                MessageBox.Show("sélectionner d'abord date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RapportJournal xtp = new RapportJournal();
                xtp.DataSource = clr.GetInstance().journal(da1, da2);
                ReportPrintTool printTool = new ReportPrintTool(xtp);
                printTool.ShowRibbonPreview();
            }
        }

        private void Listebapteme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void my_menuItemclicked(object sender, ToolStripItemClickedEventArgs e)
        {

            try
            {
                string code = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
                string rqt = "exec Annul_journal '"+code+"'";
                dao.Executer(rqt);
                dao.chargementGridOptimise("select * from V_Journal", Listebapteme);
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }

        }
        private void Listebapteme_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {

                }
                else
                {
                    ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();
                    int position_row = Listebapteme.HitTest(e.X, e.Y).RowIndex;
                    if (position_row >= 0)
                    {
                        my_menu.Items.Add("Annuler la journalisation").Name = "Annuler la journalisation";

                    }
                    my_menu.Show(Listebapteme, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menuItemclicked);
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string da1 = dates1.Value.ToString("yyyy/MM/dd");
            string da2 = dates2.Value.ToString("yyyy/MM/dd");
            if (dd.Text == "" || ddd.Text == "")
            {
                MessageBox.Show("sélectionner d'abord date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Operations xtp = new Operations();
                xtp.DataSource = clr.GetInstance().Selection_Date_oper(da1, da2);
                ReportPrintTool printTool = new ReportPrintTool(xtp);
                printTool.ShowRibbonPreview();
            }
        }

        private void dates1_onValueChanged(object sender, EventArgs e)
        {
            dd.Text = dates1.Value.ToString();
        }

        private void dates2_onValueChanged(object sender, EventArgs e)
        {
            ddd.Text = dates2.Value.ToString();
        }
    }

}
