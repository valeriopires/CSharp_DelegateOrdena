using System;


namespace CSharp_DelegateOrdena
{
    public class TestaDelegate
    {
        NomeCompleto[] nomes = new NomeCompleto[5];
        public TestaDelegate()
        {
            nomes[0] = new NomeCompleto("Rafael", "Monteiro");
            nomes[1] = new NomeCompleto("Jessica", "Brumado");
            nomes[2] = new NomeCompleto("Janice", "Santos");
            nomes[3] = new NomeCompleto("Daniel", "Silveira");
            nomes[4] = new NomeCompleto("Armando", "Nascimento");
            nomes[5] = new NomeCompleto("Mauro", "Bones");
        }

        public void Ordenar(Comparador comparar)
        {
            object temp;
            for (int i = 0; i < nomes.Length; i++)
            {
                for (int j = i; j < nomes.Length; j++)
                {
                    // usa o delegate "comparador" como um método normal
                    if (comparar(nomes[i], nomes[j]) > 0)
                    {
                        temp = nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = (NomeCompleto)temp;
                    }
                }
            }
        }

        public void ImprimirNomes()
        {
            Console.WriteLine("Nomes: \n");
            foreach (NomeCompleto nome in nomes)
            {
                Console.WriteLine(nome.ToString());
            }
        }
    }
}
