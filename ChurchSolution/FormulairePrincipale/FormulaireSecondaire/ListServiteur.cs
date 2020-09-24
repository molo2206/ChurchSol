using ChurchSolution.ClassePrincipale;
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
    public partial class ListServiteur : Form
    {
        public ListServiteur()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        private void ListServiteur_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from v_serviteur", Listeserviteur);
        }

        private void reche_OnTextChange(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from v_serviteur where nom like '%" + reche.text + "%'", Listeserviteur);
        }

        private void date_onValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = date.Value.ToString();
            string dates = date.Value.ToString("yyy-MM-dd");
            dao.chargementGridOptimise("select  * from [V_Serviteur] where date like '%" + dates + "%'", Listeserviteur);
        }
    }
}
