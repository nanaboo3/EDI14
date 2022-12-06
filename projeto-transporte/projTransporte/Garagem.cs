using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Garagem
    {
        private int num;
        private static int count = 0;
        private String nome;
        private int capacidadeTotal = 0;
        private Stack<Veiculo> vans = new Stack<Veiculo>();

        public Garagem() {
            Console.WriteLine("Informe o nome da garagem: ");
            this.nome = Console.ReadLine();
            this.num = count++;
        }

        public Garagem(String n)
        {
            this.nome = n;
            this.num = count++;
        }

        public String Nome {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public Stack<Veiculo> Vans
        {
            get { return this.vans; }
            set { this.vans = value; }
        }

        public int Num
        {
            get { return this.num; }
        }

        public void listarVeiculos()
        {
            Console.Clear();

            foreach (Veiculo v in vans)
            {
                Console.WriteLine("Número do veículo: " + v.Num + "\nCapacidade de transporte: " + v.Capacidade + "\n\n");
            }
        }

        public void adicionarVeiculo(Veiculo v)
        {
            this.vans.Push(v);
        }

    }
}
