using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchSolution.ClasseModel
{
  public  class ClsUtilisateur
    {
        public string Code { get; set; }
        public string Nom_user { get; set; }
        public string Passe { get; set; }
        public string Agent { get; set; }
        public int Fonction { get; set; }
        public string Nivaeu { get; set; }
        public int Code_fonction { get; set; }
        public int Code_fonctionnalite { get; set; }
        public int Code_menu { get; set; }
        public int Code_validite { get; set; }
    }
}
