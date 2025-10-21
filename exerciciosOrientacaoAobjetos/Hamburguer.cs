using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosOrientacaoAobjetos
{
    public class Hamburguer
    {
        public int Pao { get; set; }
        public carne Carne {  get; set; }
        

        public Hamburguer(int pao, carne carne)
        {
            this.Pao = pao;
            this.Carne = carne;
        }

        public void preparaChapa(int graus)
        {
            Console.WriteLine($"chapa preparada a {graus} graus");
        }

        public void selaPao()
        {
            Console.WriteLine("pao selado");
        }

        public void FritaCarne()
        {
            Console.WriteLine("fritar a carne");
        }

        public void MontarHamburguer()
        {
            Console.WriteLine("montando hamburguer ...");
        }

        public void Servir()
        {
            Console.WriteLine("Servir hamburguer");
        }

        public void MostrarIngredientes()
        {
            Console.WriteLine($"pao: {Pao}, carne: {Carne}");

        }
    }
}
