using System.ComponentModel;
using System.Text.Json.Serialization.Metadata;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 7)
            {

                Console.WriteLine("Seleccione un ejercicio:\n ");
                Console.WriteLine("1. Figonacci");
                Console.WriteLine("2. Numeros Primos");
                Console.WriteLine("3. Palindromo");
                Console.WriteLine("4. Suma de numeros hasta N");
                Console.WriteLine("5. Tablas de multiplicar hasta 10");
                Console.WriteLine("6. Conteo de vocales");
                Console.WriteLine("7. Salir\n");



                int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Fibonacci();
                        break;
                    case 2:
                        NumerosPrimos();
                        break;
                    case 3:
                        Palindromo();
                        break;
                    case 4:
                        SumaNumeros();
                        break;
                    case 5:
                        Tablas();
                        break;
                    case 6:
                        Vocales();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        break;
                }
            }

        }

        public static void Fibonacci()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Serie Fibonacci");
            Console.WriteLine("---------------");



            Console.WriteLine("Cuantos numeros quieres: ");
            int.TryParse(Console.ReadLine(), out int numero);
            Console.Clear();

            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine($"{i + 1})   {c}");
                a = b;
                b = c;
                c = a + b;

            }
            Console.ReadKey();
            Console.Clear();

        }

        public static void NumerosPrimos()
        {

            Console.WriteLine("---------------");
            Console.WriteLine("Numeros Primos");
            Console.WriteLine("---------------");


            Console.WriteLine("Ingrese un numero: ");

            int.TryParse(Console.ReadLine(), out int numero);
            Console.Clear();

            if (numero < 2)
            {
                Console.WriteLine("No es primo");
            }

            for (int i = 2; i <= numero; i++)
            {
                if (numero % i == 0 && numero != 2)
                {
                    Console.WriteLine("No es primo");
                    break;
                }
                else if (i == numero - 1 || numero == 2)
                {
                    Console.WriteLine("Es primo");
                    break;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void Palindromo()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Palindromo");
            Console.WriteLine("---------------\n");

            string texto = Console.ReadLine();

            for (int i = texto.Length; i > 0; i--)
            {
                Console.Write(texto[i - 1]);
            }

            Console.ReadKey();
            Console.Clear();





        }
        public static void SumaNumeros()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Suma de Numeros");
            Console.WriteLine("---------------");


            Console.WriteLine("Ingrese un numero: ");

            int.TryParse(Console.ReadLine(), out int numero);
            Console.Clear();


            int suma = 0;
            for (int i = 0; i <= numero; i++)
            {
                suma += i;
            }

            Console.WriteLine($"La suma de los numeros hasta {numero} es: {suma}");
            Console.ReadKey();
            Console.Clear();

        }
        public static void Tablas()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Tablas de Multiplicar");
            Console.WriteLine("---------------------");

            Console.WriteLine("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out int numero);
            Console.Clear();


            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i + ")");
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");

                }
                Console.WriteLine();
                Console.WriteLine();

            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void Vocales()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Conteo de Vocales");
            Console.WriteLine("---------------\n");

            Console.WriteLine("Ingrese un texto: ");
            string texto = Console.ReadLine().ToLower();

            

            int a = 0, e = 0, i = 0, o = 0, u = 0;
            int espacios = 0;


            for (int j = 0; j < texto.Length; j++)
            {
                if (texto[j] == 'a') a++;
                if (texto[j] == 'e') e++;
                if (texto[j] == 'i') i++;
                if (texto[j] == 'o') o++;
                if (texto[j] == 'u') u++;
                if (texto[j] == ' ') espacios++;
            }

            Console.WriteLine($"\nEl total de vocales es: {texto.Length - espacios}");
            Console.WriteLine($"A: {a}\nE: {e}\nI: {i}\nO: {o}\nU: {u}");

            Console.ReadKey();
            Console.Clear();

        }
    }
}
