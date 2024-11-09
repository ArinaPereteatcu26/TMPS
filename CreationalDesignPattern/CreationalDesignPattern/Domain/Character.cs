namespace CreationalDesignPattern.Domain
{
    public abstract class Character
    {
        public string Name { get; set; }
        public abstract void Attack();
        public abstract void PerformAction();
    }

}
