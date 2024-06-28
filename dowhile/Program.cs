using System;

class Program
{
    static void Main(string[] args)
    {
        string nombre, apellido;
        bool continuar;

        do
        {
            Console.WriteLine("Ingrese su nombre: \n");
            nombre = Console.ReadLine().Trim();


            Console.WriteLine("Ingrese su apellido: \n");
            apellido = Console.ReadLine().Trim();


            Console.WriteLine($"Hola, {nombre} {apellido}!");


            Console.WriteLine(" Desea ingresar otro nombre y apellido? (s/n)");
            string respuesta = Console.ReadLine().ToLower();


            continuar = (respuesta == "s");


        } while ( continuar );


        Console.WriteLine("Gracias por usar este programa. Presione cualquier tecla para salir");
        Console.ReadKey();
    }
}