namespace CreationalDesignPattern.Domain
{
    public class Wizard : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Wizard casts a spell!");
        }
    }

}
