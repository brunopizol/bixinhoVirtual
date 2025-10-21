using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosOrientacaoAobjetos
{
    public class hotdog: Hamburguer
    {
        public hotdog(int pure, int pao, carne carne)
            :base(pao, carne)
        {
            this.pure = pure;
        }

        public int pure { get; set;}

        
    }
}
