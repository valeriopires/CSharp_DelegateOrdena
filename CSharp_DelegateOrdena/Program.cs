using System;

namespace CSharp_DelegateOrdena
{
    public delegate int Comparador(object obj1, object obj2);

    public class Program
    {
        static void Main(string[] args)
        {
            TestaDelegate testaDel = new TestaDelegate();

            // Instancia o delegate
            Comparador cmp = new Comparador(NomeCompleto.CompararNome);

            Console.WriteLine("\nAntes de Ordenar: \n");

            testaDel.ImprimirNomes();

            // observe o argumento do delegate
            testaDel.Ordenar(cmp);

            Console.WriteLine("\nDepois de Ordenar: \n");

            testaDel.ImprimirNomes();

            Console.ReadLine();
        }
    }
}
