using CreationalDesignPattern.Domain;

namespace CreationalDesignPattern.Factory
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string characterType)
        {
            switch (characterType)
            {
                case "Warrior":
                    return new Warrior();
                case "Wizard":
                    return new Wizard();
                case "Archer":
                    return new Archer();
                default:
                    throw new ArgumentException("Unknown character type.");
            }
        }
    }

}
