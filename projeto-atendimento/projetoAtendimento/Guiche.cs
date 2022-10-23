using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public Guiche()
        {
            this.id = 0;
            this.atendimentos = new Queue<Senha>();
        }

        public Queue<Senha> Atendimentos
        {
            get { return this.atendimentos; }
            set { this.atendimentos = value; }
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            try
            {
                atendimentos.Enqueue(filaSenhas.First());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

    }
}
