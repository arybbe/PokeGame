using PokemonCommon;
using PokemonCommon.Characters;
using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks.ElectricAttacks;
using PokemonCommon.Pokemons.Attacks.FireAttacks;
using PokemonCommon.Pokemons.Attacks.WaterAttacks;

Trainer ash = new Trainer("Ash");


Pokemon charmander = new Pokemon("Charmander", PokeTypes.Fire);
Ember ember = new Ember();
charmander.LearnAttack(ember, 0);

Pokemon sobble = new Pokemon("Sobble", PokeTypes.Water);
WaterGun waterGun = new WaterGun();
sobble.LearnAttack(waterGun, 0);

Pokemon pikachu = new Pokemon("Pikachu", PokeTypes.Electric);
Discharge discharge = new Discharge();
pikachu.LearnAttack(discharge, 0);


BattleEngine.PokeBattle(charmander, sobble);
Console.WriteLine("-----------------");
BattleEngine.PokeBattle(pikachu, sobble);
