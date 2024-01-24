namespace Ejercicio2Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Introduce un número entero de dos cifras: ");
            } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 10 || numero > 99);

            Console.WriteLine("Múltiplos de" + numero + "entre 400 y 700: ");

            int suma = 0;
            int cantidad = 0;

            for (int i = 401; i < 700; i++)
            {
                if (i % numero == 0)
                {
                    Console.WriteLine(i);
                    suma += i;
                    cantidad++;
                }
            }

            if (cantidad > 0)
            {
                double media = (double)suma / cantidad;
                Console.WriteLine("Suma de los múltiplos: " +suma);
                Console.WriteLine($"Media aritmética de los múltiplos: {media:F2}");
            }
            else
            {
                Console.WriteLine("No hay múltiplos de" + numero + "entre 400 y 700");
            }
        }

    }
}
