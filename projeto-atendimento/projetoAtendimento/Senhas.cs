using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Senhas()
        {
            this.filaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 1;
        }

        public void gerar(Senha senha)
        {
            this.filaSenhas.Enqueue(senha);
        }

        public void tirar()
        {
            this.filaSenhas.Dequeue();
        }
     
        public Queue<Senha> Fila
        {
            get { return filaSenhas; }
        }

        public int ProximoAtendimento
        {
            get { return this.proximoAtendimento; }
            set { this.proximoAtendimento = value; }
        }
    }
}
