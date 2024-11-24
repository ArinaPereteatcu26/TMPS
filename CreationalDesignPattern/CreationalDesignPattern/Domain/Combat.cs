

namespace CreationalDesignPattern.Domain.Combat
{
    public interface ICombatStrategy
    {
        void ExecuteAttack(Character character);
    }
}
