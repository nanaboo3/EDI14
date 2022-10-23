using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento
{
    class Guiches
    {
        private Queue<Guiche> listaGuiches;

        public Guiches()
        {
            this.listaGuiches = new Queue<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            this.listaGuiches.Enqueue(guiche);
        }

        public string quantia()
        {
            return listaGuiches.Count().ToString();
        }

        public Guiche procurar(int index)
        {
            return listaGuiches.ElementAt(index);
        }
    }
}
