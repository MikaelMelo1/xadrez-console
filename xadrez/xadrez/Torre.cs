using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        private Cor preta;

    

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            this.tab = tab;
            this.cor = cor;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
