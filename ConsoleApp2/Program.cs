using PokemonCommon.Characters;
using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks.FlyingAttacks;
using PokemonCommon.Pokemons.Attacks.NormalAttacks;

Trainer ash = new Trainer("Ash");

Pokemon pigeon = new Pokemon("Pigeon", PokeTypes.Flying);
Pokemon charmander = new Pokemon("Charmander", PokeTypes.Fire);

Tackle tackle = new Tackle();
AirSlash airSlash = new AirSlash();

charmander.LearnAttack(tackle, 0);
pigeon.LearnAttack(airSlash, 0);

foreach (var pigeonAttack in pigeon.Attacks)
{
    if (pigeonAttack == null)
    {
        continue;
    }

    Console.WriteLine(pigeonAttack.Name);
}