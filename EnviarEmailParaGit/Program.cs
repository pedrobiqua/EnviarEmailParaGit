using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviarEmailParaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque o e-mail para ser enviado");
            var input = Console.ReadLine();
            EnviaEmail.EnviarEmail(input);
            Console.ReadLine();
        }
    }
}
