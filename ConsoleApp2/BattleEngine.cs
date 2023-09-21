using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks;

namespace PokeGame;

public static class BattleEngine
{
    // Detta är en statisk metod. Statiska metoder anropas via typen och inte via objekt.
    public static void MakeAttack(Pokemon target, Attack attack)
    {
        target.HealthPoints -= attack.Damage;
    }

    public static Effectiveness CheckEffectiveness(PokeTypes targetType, PokeTypes attackType)
    {
        switch (attackType)
        {
            case PokeTypes.Fire:
                return FireAttackEffectiveness(targetType);
                
                break;
        }
    }

    private static Effectiveness FireAttackEffectiveness(PokeTypes targetType)
    {
        switch (targetType)
        {
            case PokeTypes.Fire:
                return Effectiveness.Decreased;
            case PokeTypes.Water:
                return Effectiveness.Decreased;
            case PokeTypes.Rock:
                return Effectiveness.Decreased;
            case PokeTypes.Dragon:
                return Effectiveness.Decreased;
            case PokeTypes.Grass:
                return Effectiveness.Effective;
            case PokeTypes.Ice:
                return Effectiveness.Effective;
            case PokeTypes.Bug:
                return Effectiveness.Effective;
            case PokeTypes.Steel:
                return Effectiveness.Effective;

        }
    }
}