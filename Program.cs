using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
               Console.WriteLine("\n---Clasificaicon de nota---\n");

            Console.WriteLine("\nIngresa tu Nota: ");
            float nota=Convert.ToSingle(Console.ReadLine());

            if (nota >= 9.5)
            {
                Console.WriteLine("Tu nota es Exelente");
                
            }
            else if (nota >= 8.5)
            {
                Console.WriteLine("Tu nota es Muy Buena");
                
            }else if (nota >= 7.0)
            {
                Console.WriteLine("Tu nota es Buena");
                
            }else{
                Console.WriteLine("Tu nota es Deficiente");
            }
        }
    }
}