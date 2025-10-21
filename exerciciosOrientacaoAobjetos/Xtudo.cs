using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosOrientacaoAobjetos
{
    public class Xtudo: Hamburguer
    {
        public int ovo {  get; set; }
        public int queijo { get; set; }
        public int bacon {  get; set; }

        public Xtudo(int ovo, int queijo, int bacon, int pao, carne carne)
            :base (pao, carne)
        {
            this.ovo = ovo;
            this.queijo = queijo;
            this.bacon = bacon;
   
        }

        public void fritarBaconEovo()
        {
            Console.WriteLine($"fritando ovo e bacon");
        }

    }
}
