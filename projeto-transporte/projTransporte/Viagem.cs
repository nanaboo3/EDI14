using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Viagem
    {
        private Garagem origem;
        private Garagem destino;

        public Viagem()
        {
            Console.WriteLine("Selecionar origem: ");
            this.origem = selecionarGaragem();
            Console.WriteLine("\n\nSelecionar destino: ");
            this.destino = selecionarGaragem();
        }

        public Garagem Origem
        {
            get { return this.origem; }
        }

        public Garagem Destino
        {
            get { return this.destino; }
        }


        private Garagem selecionarGaragem()
        {
            try
            {
                Garagens.listar();
                int index = int.Parse(Console.ReadLine());
                return Garagens.buscar(index);
            } catch(Exception e)
            {
                return null;
            }
        }
    }
}
