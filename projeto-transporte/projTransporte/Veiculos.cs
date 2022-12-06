using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    static class Veiculos
    {
        private static List<Veiculo> veiculos = new List<Veiculo>();

        public static void cadastrar(params Veiculo[] vs)
        {
            foreach (Veiculo v in vs)
            {
                veiculos.Add(v);
            }
        }

        public static List<Veiculo> lista()
        {
            return veiculos;
        }

        public static void limpar()
        {
            veiculos.Clear();
        }
    }
}
