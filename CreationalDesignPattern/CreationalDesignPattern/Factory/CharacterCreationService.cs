using CreationalDesignPattern.Domain;

namespace CreationalDesignPattern.Factory
{
    public class CharacterCreationService
    {
        private static CharacterCreationService _instance;

        private CharacterCreationService() { }

        public static CharacterCreationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CharacterCreationService();
                }
                return _instance;
            }
        }

        public Character CreateCharacter(string type)
        {
            CharacterFactory factory = new CharacterFactory();
            return factory.CreateCharacter(type);
        }
    }

}
