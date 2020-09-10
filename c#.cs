using System;

namespace semana2_1
{
    class Program
    {
        static void Main(string[] args){Menu();}
        static void Menu()
        {
            try
            {
                Console.WriteLine("Calculadora\nBienvenido al menu\n---------------------------------------------------\n\nQue desea hacer?:\n1- sumar\n2- restar\n3- dividir\n4- multiplicar");
                string operacion = Console.ReadLine();
                switch (operacion)
                {
                    case "sumar":
                       
                        break;
                    case "restar":
                        break;
                    case "dividir":
                        break;
                    case "multiplicar":
                        break;
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
    public class Calculadora
    {
        //public string Numero2 { get; set; }
        Calculadora Calcular = new Calculadora();
        public static void Suma()
        {
            Console.WriteLine("Cual es el primer numero?");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es el segundo numero?");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = numero1 + numero2;
            Console.WriteLine($"El resultado es {resultado}");
        }
        public static void Resta()
        {
            Console.WriteLine("Cual es el primer numero?");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es el segundo numero?");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = numero1 - numero2;
            Console.WriteLine($"El resultado es {resultado}");

        }
        public static void Division()
        {
            Console.WriteLine("Cual es el primer numero?");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es el segundo numero?");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = numero1 / numero2;
            Console.WriteLine($"El resultado es {resultado}");

        }
        public static void Multiplicacion()
        {
            Console.WriteLine("Cual es el primer numero?");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es el segundo numero?");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = numero1 * numero2;
            Console.WriteLine($"El resultado es {resultado}");

        }
    }
}
