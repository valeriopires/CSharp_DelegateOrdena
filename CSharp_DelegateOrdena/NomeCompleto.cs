using System;

namespace CSharp_DelegateOrdena
{
    public class NomeCompleto
    {
        public string Nome = null;
        public string Sobrenome = null;

        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // realiza o tratamento do metodo Delegate
        public static int CompararNome(object nome1, object nome2)
        {
            string n1 = ((NomeCompleto)nome1).Nome;
            string n2 = ((NomeCompleto)nome2).Nome;

            if (String.Compare(n1, n2) > 0)
            {
                return 1;
            }
            else if (String.Compare(n1, n2) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
