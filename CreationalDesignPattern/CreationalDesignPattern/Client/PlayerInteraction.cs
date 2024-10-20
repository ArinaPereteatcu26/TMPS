using CreationalDesignPattern.Domain;

    namespace GameCharacterCreation.client
    {
        public class PlayerInteraction
        {
            // Ask the player to choose a character type
            public string GetCharacterChoice()
            {
                Console.WriteLine("Please choose a character type: Warrior, Wizard, or Archer.");
                string choice = Console.ReadLine();

                // Ensure valid input
                while (choice != "Warrior" && choice != "Wizard" && choice != "Archer")
                {
                    Console.WriteLine("Invalid choice. Please choose again: Warrior, Wizard, or Archer.");
                    choice = Console.ReadLine();
                }

                return choice;
            }

            // Display the action a character is performing
            public void DisplayCharacterAction(Character character)
            {
                character.Attack();
            }

            // Display message for returning a character to the pool
            public void NotifyReturnCharacter(Character character)
            {
                Console.WriteLine($"{character.GetType().Name} returned to the pool.");
            }
        }
    }


