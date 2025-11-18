using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appusuario
{
    class Program
    {
        public void Main(string[] args)
        {
            int numA = 4;
            int resultado1 = Cuadrado(numA);
            int resultado2 = Cuadrado(12);
            int resultado3 = Cuadrado(resultado1 * 3);

            Console.WriteLine(resultado3);
            Console.ReadKey();
        }
        public static int Cuadrado(int i)
        {

        return i* i;
    }



    }
}
    
