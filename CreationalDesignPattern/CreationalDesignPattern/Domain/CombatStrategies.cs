namespace CreationalDesignPattern.Domain.Combat
{
    public class AggressiveCombatStrategy : ICombatStrategy
    {
        public void ExecuteAttack(Character character)
        {
            Console.WriteLine($"{character.Name} uses aggressive combat style!");
            character.Attack();
            Console.WriteLine("Follows up with a powerful strike!");
        }
    }

    public class DefensiveCombatStrategy : ICombatStrategy
    {
        public void ExecuteAttack(Character character)
        {
            Console.WriteLine($"{character.Name} takes defensive stance!");
            character.Attack();
            Console.WriteLine("Quickly returns to defensive position!");
        }
    }

    public class RangedCombatStrategy : ICombatStrategy
    {
        public void ExecuteAttack(Character character)
        {
            Console.WriteLine($"{character.Name} maintains distance!");
            character.Attack();
            Console.WriteLine("Steps back to maintain range!");
        }
    }
}