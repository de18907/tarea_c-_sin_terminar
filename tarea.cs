 /*
al iniciar el sistema se nos debe preguntar cual operacion queremos realizar
luego preguntarnos 
cual es el primer numero
cual es el segundo 
el sistema debe estar orientado a objetos esto quiere decir que debe existir una clase para el manejo del menu y otra para realizar las operaciones (Valor 1 pto)

 */
using System;
namespace calculadora
{
    public class Program
    {
        static void Main(string[] args){
            Menu();
        }
        public static void Menu()
        {
            try
            {
                console.clear();
                Console.WriteLine("Calculadora\nBienvenido al menu\n---------------------------------------------------\n\nQue desea hacer?:\n1- sumar\n2- restar\n3- dividir\n4- multiplicar");
                string operacion = Console.ReadLine();
                switch (operacion)
                {
                    case "sumar":
                        Suma();
                        break;
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("La palabra que escribiste no es la correcta");
                Console.ReadKey();
                Menu();
            }
        }
        public static void Suma()
        {
            try
            {
                console.clear();
                Numeros Valor_total = new Numeros();
                Console.WriteLine("Cual es el primer numero?");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cual es el segundo numero?");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int resultado = numero1 + numero2;
                Valor_total.Resultado = resultado;
                Console.WriteLine("El resultado es "+resultado);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Elnumero que escribiste no es la correcta");
                Console.ReadKey();
                Suma();
            }
        }
        public static void Restar()
        {
            try
            {
                console.clear();
                Numeros Valor_total = new Numeros();
                Console.WriteLine("Cual es el primer numero?");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cual es el segundo numero?");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int resultado = numero1 - numero2;
                Valor_total.Resultado = resultado;
                Console.WriteLine("El resultado es "+resultado);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Elnumero que escribiste no es la correcta");
                Console.ReadKey();
                Restar();
            }
        }
        public static void Dividir()
        {
            try
            {
                console.clear();
                Numeros Valor_total = new Numeros();
                Console.WriteLine("Cual es el primer numero?");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cual es el segundo numero?");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int resultado = numero1 / numero2;
                Valor_total.Resultado = resultado;
                Console.WriteLine("El resultado es "+resultado);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Elnumero que escribiste no es la correcta");
                Console.ReadKey();
                Dividir();
            }
        }
        public static void Multiplicar()
        {
            try
            {
                console.clear();
                Numeros Valor_total = new Numeros();
                Console.WriteLine("Cual es el primer numero?");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cual es el segundo numero?");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int resultado = numero1 * numero2;
                Valor_total.Resultado = resultado;
                Console.WriteLine("El resultado es "+resultado);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Elnumero que escribiste no es la correcta");
                Console.ReadKey();
                Multiplicar();
            }
        }
    }
    public class Numeros
    {
        public int Resultado { get; set;}
    }
}