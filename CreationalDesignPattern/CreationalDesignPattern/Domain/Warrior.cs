namespace CreationalDesignPattern.Domain
{
    public class Warrior : Character
    {

        public override void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword!");
        }
    }
}
