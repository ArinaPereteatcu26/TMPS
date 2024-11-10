namespace CreationalDesignPattern.Domain
{
    public class Warrior : Character
    {
        public override void PerformAction()
        {
            Console.WriteLine("Warrior prepares for fight");
        }

        public override void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword!");
        }
    }
}
