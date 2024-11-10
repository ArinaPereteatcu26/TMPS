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
         
            Character character = availableCharacters.FirstOrDefault(c => c.GetType().Name == type);

            if (character == null) 
            {
                character = CharacterCreationService.Instance.CreateCharacter(type);
                availableCharacters.Add(character);
            }

        
            availableCharacters.Remove(character);
            inUseCharacters.Add(character);

            return character;
        }

        public void ReturnCharacter(Character character)
        {
          
            inUseCharacters.Remove(character);
            availableCharacters.Add(character);
        }
    }

}
