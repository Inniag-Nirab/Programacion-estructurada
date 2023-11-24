namespace Programación_estructurada
{
    class Program
    {
        static void Main()
        {
            int[] numeros = { 5, 1, 12, -5, 16, 2, 12, 14 };
            Console.WriteLine("Arreglo original:");
            ImprimirArreglo(numeros);

            OrdenamientoBurbuja(numeros);
            Console.WriteLine("\nArreglo ordenado:");
            ImprimirArreglo(numeros);
        }

        static void OrdenamientoBurbuja(int[] arreglo)
        {
            int temp;
            for (int j = 0; j <= arreglo.Length - 2; j++)
            {
                for (int i = 0; i <= arreglo.Length - 2; i++)
                {
                    if (arreglo[i] > arreglo[i + 1])
                    {
                        temp = arreglo[i + 1];
                        arreglo[i + 1] = arreglo[i];
                        arreglo[i] = temp;
                    }
                }
            }
        }

        static void ImprimirArreglo(int[] arreglo)
        {
            foreach (int i in arreglo)
            {
                Console.Write(i + " ");
            }
        }
    }
}

//Este programa tiene un arreglo de números enteros que se ordena utilizando el algoritmo de ordenamiento por burbuja.
//El método OrdenamientoBurbuja toma un arreglo y lo ordena en su lugar. El método ImprimirArreglo toma un arreglo e imprime sus elementos
//Al imprimirlos todos salen completamente ordenados de menor a mayor
//Hola Profe XDDXD