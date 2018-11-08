using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneGitLibrary
{
    public class Personne
    {
        #region "Propriétés d'instance"
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        public Personne(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
        }

        public Personne(string nom, string prenom):this(nom, prenom, 18)
        {

        }
        #endregion "Constructeurs"


        #region "Méthodes substituées"
        public override string ToString()
        {
            return $"{Nom} {Prenom}, {Age} ans";
        }

        #endregion "Méthodes substituées"

        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"

    }
}
