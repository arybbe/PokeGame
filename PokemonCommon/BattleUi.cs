using PokemonCommon.Enums;

namespace PokemonCommon;

public static class BattleUi
{
    private static Dictionary<Effectiveness, string> messages = new Dictionary<Effectiveness, string>()
    {
        { Effectiveness.None, "It has no effect!" },
        { Effectiveness.Decreased, "It's not very effective..." },
        { Effectiveness.Normal, "" },
        { Effectiveness.Effective, "It's super effective!" }
    };

    public static void DisplayDamageEffectiveness(Effectiveness effectiveness, string attackName, string attacker)
    {
        Console.WriteLine($"{attacker} used {attackName}! {messages[effectiveness]}");
    }
}