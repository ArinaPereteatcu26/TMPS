using CreationalDesignPattern.Domain;

    namespace GameCharacterCreation.client
    {
        public class PlayerInteraction
        {
            public string GetCharacterChoice()
            {
                Console.WriteLine("Please choose a character type: Warrior, Wizard, or Archer.");
                string choice = Console.ReadLine();

              
                while (choice != "Warrior" && choice != "Wizard" && choice != "Archer")
                {
                    Console.WriteLine("Invalid choice. Please choose again: Warrior, Wizard, or Archer.");
                    choice = Console.ReadLine();
                }

                return choice;
            }

           
            public void DisplayCharacterAction(Character character)
            {
                character.Attack();
            }

          
            public void NotifyReturnCharacter(Character character)
            {
                Console.WriteLine($"{character.GetType().Name} returned to the pool.");
            }
        }
    }


