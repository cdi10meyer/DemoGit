using PersonneGitLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneGitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Lopper", "Cyndy", 40);
            Console.WriteLine(p1);
            Personne p2 = new Personne("Redford", "Robert");
            Console.WriteLine(p2);
            Personne p3 = p2;
            p3.Age = 33;
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.ReadKey();
        }
    }
}
