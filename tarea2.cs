using System;
namespace Persona_general
{
    public class Program
    {
        static void Main(string[] args)
        {
			Persona nombre_value = new Persona();
			Persona edad_value = new Persona();
			Persona sexo_value = new Persona();
			Persona peso_value = new Persona();
			Persona altura_value = new Persona();
			Console.WriteLine("Cual es tu nombre?");
			string nombre = Console.ReadLine();
			nombre_value.Nombre = nombre;
			Console.WriteLine("Cual es tu edad?");
			int edad = Convert.ToInt32(Console.ReadLine());
			edad_value.Edad = edad;
			Console.WriteLine("Eres hombre o mujer?");
			int sexo = Convert.ToInt32(Console.ReadLine());
			sexo_value.Sexo = sexo;
			Console.WriteLine("Cual es tu peso?");
			int peso = Convert.ToInt32(Console.ReadLine());
			peso_value.Peso = peso;
			Console.WriteLine("Cual es tu altura?");
			int altura = Convert.ToInt32(Console.ReadLine());
			altura_value.Altura = altura;
			calcularIMC();
			esMayorDeEdad();
			Console.ReadKey();
        }
    }
    public class Persona
    {
        public String Nombre { get;} ="";
        public int Edad { get;} = 0;
        public int cedula { get; set;}
        public String Sexo { get; set;} ="hombre";
        public int Peso { get;} = 0;
        public int Altura { get;} = 0;
        public static void calcularIMC()
        {
            int valor = Peso/(Altura ** 2);
            if(valor < 20){
                consola.WriteLine("Esta casi desnutrido");
            }
            else if(valor >= 20 && valor <= 25){
                consola.WriteLine("Esta por debajo de su peso");
            }
            else if(valor > 25){
                consola.WriteLine("Tiene sobrepeso");
            }
        }
        public static void esMayorDeEdad()
        {
            if(Edad > 18){
                consola.WriteLine("Edad es True");
            }
            else{
                consola.WriteLine("Edad es False");
            }
        }
    }
}