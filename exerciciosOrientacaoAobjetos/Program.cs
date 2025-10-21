// See https://aka.ms/new-console-template for more information
using exerciciosOrientacaoAobjetos;

Console.WriteLine("Hello, World!");
exercicioHamburguer();



void exercicioHamburguer()
{
    Hamburguer burguer1 = new Hamburguer(2, carne.bovina);
    burguer1.preparaChapa(200);
    burguer1.selaPao();
    burguer1.FritaCarne();
    burguer1.MontarHamburguer();
    burguer1.MostrarIngredientes();

    Xtudo xtudo = new Xtudo(ovo: 1, queijo: 2, bacon: 2, pao: 2, carne: carne.suina);
    xtudo.FritaCarne();
    xtudo.MontarHamburguer();
    xtudo.preparaChapa(230);
    xtudo.selaPao();
    xtudo.fritarBaconEovo();
    xtudo.MostrarIngredientes();

    hotdog hotdog = new hotdog(100, 1, carne.salsicha);
    Console.WriteLine("######################################################################");
    pokemon();

    void pokemon()
    {
        Pokemon pokemon = new Pokemon();
        pokemon.Nascer();
        var random = new Random();
        while (pokemon.Estado)
        {
            int acao = random.Next(1, 4);
            switch (acao)
            {
                case 1:
                    pokemon.comer();
                    break;
                case 2:
                    pokemon.correr();
                    break;
                case 3:
                    pokemon.dormir();
                    pokemon.Idade++;
                    break;

            }
            if (pokemon.Forca <= 0 || pokemon.Calorias < 0)
            {
                pokemon.morrer();
            }
            pokemon.MostrarDetalhes();
        }
        Console.WriteLine($"{pokemon.Nome} viveu por {pokemon.Idade} dias!!");
    }
}