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

            Console.ReadKey();
        }
    }
}
