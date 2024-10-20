namespace CreationalDesignPattern.Domain
{
    public class Archer : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Archer shoots an arrow!");
        }
    }
}
