using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        public string Nombre { get; set; }
        public decimal SalarioHora {  get; set; }
        public int Horas { get; set; }
        static void Main(string[] args)
        {
            //Promedio();
            OrdenarAreglo();
            Console.ReadKey();
        }
        public static void Promedio()
        {
            int[] arreglo = { 10, 20, 30, 40, 50 };
            int suma = 0;
            int salida = 0;

            for(int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i];
            }
            salida = suma / arreglo.Length;
            Console.WriteLine("Promedio: " +  salida);
        }
        public static void ContadorVocales()
        {
            Console.WriteLine("Ingresa la cadena");
            string cadena = Console.ReadLine();
            //Creamos una variable modificable en el proceso
            // Contador 
            int conteo = 0;
            //ciclo para recorrer las cadena por cada uno de sus elementos 
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u' || cadena[i] == 'A' || cadena[i] == 'E' || cadena[i] == 'I' || cadena[i] == 'O' || cadena[i] == 'U')
                {
                    conteo++;
                }
            }
            Console.WriteLine("Numero de vocales en la cadena: " + conteo);
        }
        public static void CalcularaSalario()
        {
            decimal SalarioFinal = 0;
            Program program = new Program();
            Console.WriteLine("Ingresa el nombre del trabajador");
            program.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el salario por horas");
            program.SalarioHora = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingresa las horas trabajadas");
            program.Horas = Convert.ToInt32(Console.ReadLine());
            SalarioFinal = program.SalarioHora * program.Horas;
            Console.WriteLine("*****************");
            Console.WriteLine("Nombre del trabajador: " +program.Nombre);
            Console.WriteLine("Horas trabajadas: " + program.Horas);
            Console.WriteLine("Salario por hora: " + program.SalarioHora);
            Console.WriteLine("Salario Total: " + SalarioFinal);
            Console.WriteLine("*****************");

        }
        public static void OrdenarAreglo()
        {
            int[] numeros = { 5, 3, 8, 1, 2 };
            int temp;

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }
            Console.Write("Arreglo ordenado: ");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
        }
    }
}
