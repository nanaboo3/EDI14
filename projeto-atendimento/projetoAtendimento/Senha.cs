using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime? dataAtend;

        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now;
        }

        public string dadosParciais()
        {
            return id + "-" + dataGerac;
        }

        public string dadosCompletos()
        {
            return id + "-" +dataGerac+"-"+dataAtend;
        }

        public DateTime? DataAtend
        {
            get { return dataAtend; }
            set { this.dataAtend = value; }
        }
        
        public int Id
        {
            get { return this.id; }
        }

    }
}
