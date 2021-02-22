using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6_tda_2
{
 
        // 1- Resolver el ejercicio 4 de la práctica de arrays usando clases(IMC)
    class Persona
    {
        public string nombre;
        public ushort edad;
        public double altura;
        public double peso;
        public double imc;
    }

    class Program
    {
        static void SolicitarDatos(Persona[] personas)
        {
            for (int i = 0; i < personas.Length; i++)
            {
                Console.Write($"Indique el nombre numero {i + 1}: ");
                personas[i].nombre = Console.ReadLine();
               
                Console.Write($"Indique una edad para el nombre numero {i + 1}: ");
                personas[i].edad = ushort.Parse(Console.ReadLine());
               
                Console.Write($"Indique la altura (metros) de numero {i + 1}: ");
                personas[i].altura = double.Parse(Console.ReadLine());
               
                Console.Write($"Indique el peso (Kilogramos) de numero {i + 1}: ");
                personas[i].peso = double.Parse(Console.ReadLine());
               
                personas[i].imc = personas[i].peso / Math.Pow(personas[i].altura, 2);

                if (personas[i].edad <= 0 || personas[i].altura <= 0 || personas[i].peso <= 0)
                {
                    throw new ArgumentOutOfRangeException("La edad, la altura o el peso no son válidos");
                }
            }
        }

        static void Respuesta(Persona[] personas)
        {
            Console.WriteLine("Usted escribio: ");
            Console.WriteLine();

            for (int i = personas.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Elemento [{i + 1}] " + $"Nombre: {personas[i].nombre} " + $"Edad: {personas[i].edad} " + $"Peso: {personas[i].peso} " +
                    $"Altura:{personas[i].altura}");
                Console.WriteLine($"Su IMC es {personas[i].imc}");
                Console.Write("Estado: ");
                if (personas[i].imc <= 15)
                {
                    Console.WriteLine("Delgadez muy severa");
                    Console.WriteLine();
                }
                else if (personas[i].imc < 16 && personas[i].imc > 15)
                {
                    Console.WriteLine("Delgadez severa");
                    Console.WriteLine();
                }
                else if (personas[i].imc > 16 && personas[i].imc <= 18.4)
                {
                    Console.WriteLine("Delgadez");
                    Console.WriteLine();
                }
                else if (personas[i].imc >= 18.5 && personas[i].imc <= 24.9)
                {
                    Console.WriteLine("Saludable");
                    Console.WriteLine();
                }
                else if (personas[i].imc >= 25 && personas[i].imc <= 29)
                {
                    Console.WriteLine("Sobrepeso");
                    Console.WriteLine();
                }
                else if (personas[i].imc >= 30 && personas[i].imc <= 34.9)
                {
                    Console.WriteLine("Obesidad Moderada");
                    Console.WriteLine();
                }
                else if (personas[i].imc >= 35 && personas[i].imc <= 39.9)
                {
                    Console.WriteLine("Obesidad Severa");
                    Console.WriteLine();
                }
                else
                // (imc[x] >= 40)
                {
                    Console.WriteLine("Obesidad Mórbida");
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            int cantNombres = 0;
            Persona[] personas;

            Console.Write("Indique la cantidad de nombres a ingresar: ");
            cantNombres = int.Parse(Console.ReadLine());

            while (cantNombres <= 0)
            {
                Console.WriteLine("El número ingresado es inválido, ingrese un número mayor a cero: ");
                cantNombres = int.Parse(Console.ReadLine());

            }

            personas = new Persona[cantNombres];

            for (int i = 0; i < personas.Length; i++)
            {
                personas[i] = new Persona();
            }

            SolicitarDatos(personas);

            Respuesta(personas);



            Console.ReadKey();


        }
    }
}
