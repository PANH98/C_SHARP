using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Name = "Pedro";
            persona1.Age = 30;
            Console.WriteLine("persona1 Name= {0} Age = {1}",persona1.Name,persona1.Age);

            Persona persona2 = persona1;
            persona2.Name = "Lucia";
            persona2.Age = 15;
            Console.WriteLine("persona2 Name ={0} Age = {1}", persona2.Name, persona2.Age);
            Console.WriteLine("persona1 Name ={0} Age = {1}", persona1.Name, persona1.Age);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }

    }
    public struct Persona
    {
        public string Name;
        public int Age;






    }
}