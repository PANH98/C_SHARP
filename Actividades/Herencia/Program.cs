using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{

    class Program 
    {
        static void Main(string[] args)
        {
            Chihuahua perro1 = new Chihuahua();
            Console.WriteLine(perro1.PerroLadrar());
            Console.ReadKey();

        }
    
    }
    public class Perro
    {
        public string PerroLadrar() { return "Perro ladrando"; }
    }

    public class Chihuahua : Perro
    { 
    
    public void ChihuahuaLadrar()
        {
            base.PerroLadrar();
        }
        


    
    
    }








}