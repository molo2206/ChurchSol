using ChurchSolution.ClassePrincipale;
using ChurchSolution.Rapport_Etat_de_sortie_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.FormulairePrincipale
{
    public partial class ListePresence : Form
    {
        public ListePresence()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        private void ListePresence_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select  * from V_Presence", Listemembre);
            total.Text = dao.Countnombre("select count(code) as code from Agent ", "code");
            present.Text = dao.Countnombre("SELECT COUNT(CODE_AGENT) as code FROM ENTETE_PRESENCE WHERE CODE IN(SELECT CODE_ENTETE FROM DETAIL_PRESENCE) AND CONVERT(varchar(10), DATE_PRES, 103)= CONVERT(varchar(10), GETDATE(), 103)", "code");
            absent.Text = dao.Countnombre("select count(CODE) as code from AGENT where CODE not in(select CODE_AGENT from ENTETE_PRESENCE where CONVERT(varchar(10), DATE_PRES, 103) = CONVERT(varchar(10), GETDATE(), 103))", "code");
        }

        private void reche_OnTextChange(object sender, EventArgs e)
        {
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = date.Value.ToString();
        }

        private void txtdate_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void reche_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select  * from V_Presence where nom like '%" + reche.Text + "%'", Listemembre);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FrmListpresence lsp = new FrmListpresence();
            lsp.ShowDialog();
        }
    }
}
