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

namespace ChurchSolution.FormulaireSecondaire
{
    public partial class ListMembre : Form
    {
        public ListMembre()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        private void ListMembre_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select  * from v_membre", Listemembre);

        }

        private void reche_OnTextChange(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select  * from v_membre where nom_complet like '%"+reche.text+"%'", Listemembre);
        }

        private void reche_Leave(object sender, EventArgs e)
        {
            //if (reche.text.Equals(""))
            //{
            //    reche.text = "Rechercher dans ce tableau:";
            //}
        }

        private void reche_Enter(object sender, EventArgs e)
        {
            //if (reche.text.Equals("Rechercher dans ce tableau:"))
            //{
            //    reche.text = "";
            //}
        }

        private void date_onValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = date.Value.ToString();
            string dates = date.Value.ToString("yyy-MM-dd");
            dao.chargementGridOptimise("select  * from v_membre where date_ like '%" + dates + "%'", Listemembre);
        }
    }
}
