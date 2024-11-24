using CreationalDesignPattern.Domain.Combat;

namespace CreationalDesignPattern.Domain
{
    public abstract class Character
    {
        private ICombatStrategy _combatStrategy;

        public string Name { get; set; }
        public abstract void Attack();
        public void SetCombatStrategy(ICombatStrategy strategy)
        {
            _combatStrategy = strategy;
        }

        public void ExecuteCombatStrategy()
        {
            if (_combatStrategy != null)
            {
                _combatStrategy.ExecuteAttack(this);
            }
            else
            {
                Attack();
            }
        }
    }
}

   
