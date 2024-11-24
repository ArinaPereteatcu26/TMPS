using CreationalDesignPattern.Domain;
using CreationalDesignPattern.Domain.Combat;

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

        public ICombatStrategy GetCombatStrategyChoice()
        {
            Console.WriteLine("Choose your combat style:");
            Console.WriteLine("1. Aggressive");
            Console.WriteLine("2. Defensive");
            Console.WriteLine("3. Ranged");

            string choice = Console.ReadLine();

            while (!new[] { "1", "2", "3" }.Contains(choice))
            {
                Console.WriteLine("Invalid choice. Please choose 1, 2, or 3:");
                choice = Console.ReadLine();
            }

            return choice switch
            {
                "1" => new AggressiveCombatStrategy(),
                "2" => new DefensiveCombatStrategy(),
                "3" => new RangedCombatStrategy(),
                _ => new AggressiveCombatStrategy() // default
            };
        }

        public void DisplayCharacterAction(Character character)
        {
            character.ExecuteCombatStrategy();
        }

        public void NotifyReturnCharacter(Character character)
        {
            Console.WriteLine($"{character.GetType().Name} returned to the pool.");
        }

        public bool GetYesNoChoice(string question)
        {
            Console.WriteLine($"{question} (yes/no)");
            string response = Console.ReadLine().ToLower();
            while (response != "yes" && response != "no")
            {
                Console.WriteLine("Please answer 'yes' or 'no':");
                response = Console.ReadLine().ToLower();
            }
            return response == "yes";
        }
    }
}
