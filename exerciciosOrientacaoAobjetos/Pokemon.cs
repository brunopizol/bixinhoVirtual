using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosOrientacaoAobjetos
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public int Forca {  get; set; }
        public int Calorias { get; set; }
        public int Idade { get; set; }
        public bool Estado { get; set; }
        public string Classe { get; set; }

        public Pokemon()
        {

        }

        public void Nascer()
        {
            Console.WriteLine("Digite o nome do seu pokemon:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a classe do seu pokemon:");
            Classe = Console.ReadLine();
            Idade = 0;
            Estado = true;
            Calorias = 10;
            Forca = 10;
            Console.WriteLine($"{Nome} nasceu!");
        }
        public void correr() {
            if (Estado && Forca > 0)
            {
                Forca -= 5;
                Calorias -= 5;
                Console.WriteLine($"{Nome} correu e agora tem {Forca} de força e {Calorias} calorias.");
                return;
            }
        }

        public void comer() {
            if (Estado && Calorias < 100)
            {
                Calorias += 10;
                Forca -= 2;
                Console.WriteLine($"{Nome} comeu e agora tem {Calorias} calorias e {Forca} de Forca.");
                return;
            }
            Console.WriteLine($"{Nome} está morto e não pode comer.");
            return;
        }
        public void dormir()
        {
            if (Estado)
            {
                Forca += 10;
                Calorias -= 2;
                Console.WriteLine($"{Nome} dormiu e agora tem {Forca} de força e {Calorias} calorias.");
                return;
            }
            Console.WriteLine($"{Nome} está morto e não pode dormir.");
            return;
        }
        public void MostrarDetalhes()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Classe: {Classe}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Estado: {(Estado ? "Vivo" : "Morto")}");
            Console.WriteLine($"Caloria: {Calorias}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine("--------------------");
        }
        public void morrer()
        {
            Forca = 0;
            Estado = false;
            Console.WriteLine($"{Nome} morreu!");
        }
    }
}
