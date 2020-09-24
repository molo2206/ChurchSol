using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        ClsLogin lg = new ClsLogin();
        Clsfonctions fx = new Clsfonctions();
        logine log = new logine();
        Form1 frm = new Form1();
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
        //    if (e.KeyCode==Keys.Enter)
        //    {
        //        txtpwd.Focus();
        //    }
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode==Keys.Enter)
            //{
            //    btnsuite.PerformClick();
            //}
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            
        }
    }
}
