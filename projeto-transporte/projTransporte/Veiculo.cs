using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Veiculo
    {
        private int num;
        private int capacidade;
        private static int count = 0;

        public Veiculo() {
            this.num = ++count;
            Console.WriteLine("Capacidade máxima de transporte do veículo: ");
            this.capacidade = int.Parse(Console.ReadLine());
        }

        public Veiculo(int c)
        {
            this.num = ++count;
            this.capacidade = c;
        }

        public int Num
        {
            get { return num; }
        }

        public int Capacidade
        {
            get { return this.capacidade; }
            set { this.capacidade = value; }
        }
    }
}
