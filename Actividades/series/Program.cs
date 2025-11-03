using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo de 100 elementos tipo int
        int[] fibonacci = new int[100];

        // Inicializar los dos primeros elementos de la serie
        fibonacci[0] = 1;
        fibonacci[1] = 1;

        // Calcular los siguientes 98 elementos usando una sentencia iterativa
        for (int i = 2; i < 100; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        // Imprimir todos los elementos del arreglo
        Console.WriteLine("Los primeros 100 números de la serie de Fibonacci son:");
        for (int i = 0; i < 100; i++)
        {
            Console.Write(fibonacci[i] + " ");

            // Opcional: Salto de línea cada 10 elementos para mejor visualización
            if ((i + 1) % 10 == 0)
                Console.WriteLine();
        }

        // Esperar a que el usuario presione una tecla para cerrar
        Console.WriteLine("\n\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
