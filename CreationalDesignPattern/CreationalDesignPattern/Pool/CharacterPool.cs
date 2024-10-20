using CreationalDesignPattern.Domain;
using CreationalDesignPattern.Factory;

namespace CreationalDesignPattern.Pool
{

    public class CharacterPool
    {
        private List<Character> availableCharacters = new List<Character>();
        private List<Character> inUseCharacters = new List<Character>();

        public Character GetCharacter(string type)
        {
            // Check if there is an available character in the pool
            Character character = availableCharacters.FirstOrDefault(c => c.GetType().Name == type);

            if (character == null) // If not, create a new one
            {
                character = CharacterCreationService.Instance.CreateCharacter(type);
                availableCharacters.Add(character);
            }

            // Move character from available to in-use
            availableCharacters.Remove(character);
            inUseCharacters.Add(character);

            return character;
        }

        public void ReturnCharacter(Character character)
        {
            // Return character from in-use back to available
            inUseCharacters.Remove(character);
            availableCharacters.Add(character);
        }
    }

}
