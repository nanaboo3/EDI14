using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    static class Jornada
    {

        public static void iniciar()
        {
            List<Veiculo> veiculos = Veiculos.lista();
            List<Garagem> destinos = Garagens.lista();
            int j = veiculos.Count();
            try { 
            while (j > 0)
            {
                for (int i = 0; i < destinos.Count(); i++)
                {
                    destinos[i].adicionarVeiculo(veiculos[--j]);
                }
            }
            } catch(Exception e)
            {

            }
        }

        public static void finalizar()
        {
            Viagens.limpar();
            Garagens.limparFrota();
        }
    }
}
