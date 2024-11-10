namespace CreationalDesignPattern.Domain
{
    public class Wizard : Character
    {
        public override void PerformAction()
        {
            Console.WriteLine("Wizard prepares for fight");
        }

        public override void Attack()
        {
            Console.WriteLine("Wizard casts a spell!");
        }
        

    }

}
