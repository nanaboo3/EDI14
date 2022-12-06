using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    static class Viagens
    {
        private static Stack<Viagem> viagens = new Stack<Viagem>();

        public static void iniciar(Viagem v)
        {
            try { 
            Console.Clear();
            viagens.Push(v);
            Console.WriteLine("ORIGEM: "+v.Origem.Nome+"\nDESTINO: "+v.Destino.Nome+"\n\nBoa viagem!");
            Console.ReadKey();
            } catch(Exception e)
            {
                Console.WriteLine("Origem ou destino inválidos.");
            }
        }

        public static void listar()
        {
            Console.WriteLine("Escolha a viagem: ");
            int i = 1;
            Console.WriteLine("VIAGENS: "+"\n---------------------------------------------------------------");
            foreach(Viagem v in viagens)
            {
                Console.WriteLine(i++ +". De "+v.Origem.Nome.ToUpper() + " até " + v.Destino.Nome.ToUpper() + "\n\n");
            }
            Console.ReadKey();
        }

        public static void contador(int origem, int destino)
        {
            List<Viagem> lista = buscar(origem, destino);
            Console.WriteLine("Viagens feitas: "+lista.Count());
        }

        public static void historico(int origem, int destino)
        {
            List<Viagem> lista = buscar(origem, destino);
            Console.WriteLine("VIAGENS: " + "\n---------------------------------------------------------------");
            int i = 1;
            foreach (Viagem v in lista)
            {
                Console.WriteLine(i++ + ". De " + v.Origem.Nome.ToUpper() + " até " + v.Destino.Nome.ToUpper() + "\n");
            }
        }

        public static void passageirosTotal(int origem, int destino)
        {
            List<Viagem> lista = buscar(origem, destino);
            int contador = 0;
            try { 
            foreach(Viagem vj in lista)
            {
                foreach(Veiculo v in vj.Origem.Vans)
                {
                    contador += v.Capacidade;
                }
            }
            Console.WriteLine("Número de passageiros transportados de " + lista[0].Origem.Nome.ToUpper() + " até " + lista[0].Destino.Nome.ToUpper() + ": "+contador);
            } catch(Exception e)
            {
            Console.WriteLine("Não houve transporte de passageiros.");
            }
        }

        public static List<Viagem> buscar (int origem, int destino)
        {
            return viagens.Where(v => v.Origem.Num.Equals(origem) && v.Destino.Num.Equals(destino)).ToList();
        }

        public static void limpar()
        {
            viagens.Clear();
        }
    }
}
