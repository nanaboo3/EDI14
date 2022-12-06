using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    static class Garagens
    {
        private static List<Garagem> garagens = new List<Garagem>();
        private static bool cadastro = true;

        public static void listar()
        {
            int index = 0;
            foreach(Garagem garagem in garagens)
            {
                Console.WriteLine(index++ +". "+garagem.Nome);
            }
        }

        public static List<Garagem> lista()
        {
            return garagens;
        }

        public static void adicionar(params Garagem[] g)
        {
            if (cadastro)
            {
                foreach (Garagem garagem in g)
                {
                    garagens.Add(garagem);
                }
            } else
            {
                Console.WriteLine("Encerre a jornada para conseguir cadastrar novas garagens.");
            }
        }

        public static int quantidade()
        {
            return garagens.Count();
        }

        public static Garagem buscar(int i)
        {
            Garagem g =  garagens.ElementAt(i);
            return g;
        }

        public static void limparFrota()
        {
            foreach(Garagem garagem in garagens)
            {
                garagem.Vans.Clear();
            }
        }
    }
}
