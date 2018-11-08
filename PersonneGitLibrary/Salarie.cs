using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneGitLibrary
{
   public class Salarie : Personne
  {

    public Salarie(string nom, string prenom, int age, int salaire, int matricule): base(nom, prenom, age)
    {
      Salaire = salaire;
      Matricule = matricule;
    }

    public int Salaire { get; set; }

    public int Matricule { get; set; }
  }
}
