namespace CreationalDesignPattern.Domain
{
    public class Archer : Character
    {

        public override void PerformAction()
        {
            Console.WriteLine("Archer takes aim with a bow");
        }

        public override void Attack()
        {
            Console.WriteLine("Archer shoots an arrow!");
        }
    }
}
