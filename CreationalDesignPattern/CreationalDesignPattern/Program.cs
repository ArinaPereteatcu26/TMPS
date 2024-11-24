using System;
using CreationalDesignPattern.Domain;
using CreationalDesignPattern.Factory;
using CreationalDesignPattern.Pool;
using GameCharacterCreation.client;
using CreationalDesignPattern.Devices;

namespace GameCharacterCreation
{
    class Program
    {
        private static bool addSkill;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Character Creation System!");


            PlayerInteraction playerInteraction = new PlayerInteraction();
            CharacterCreationService creationService = CharacterCreationService.Instance;
            CharacterPool characterPool = new CharacterPool();
            CharacterCustomizer characterCustomizer = new CharacterCustomizer(creationService);

            Console.WriteLine("\n=== Character Creation ===");
            string characterType = playerInteraction.GetCharacterChoice();

            Console.WriteLine("Do you want to add skill to your character? (yes/no)");
            bool addASkill = Console.ReadLine().ToLower() == "yes";


            //Console.WriteLine("Do you want to add armor to your character? (yes/no)");
            //bool addArmor = Console.ReadLine().ToLower() == "yes";

            //Console.WriteLine("Do you want to add a weapon to your character? (yes/no)");
            //bool addWeapon = Console.ReadLine().ToLower() == "yes";

            Character character = characterCustomizer.CreateCustomCharacter(characterType, addSkill);
            Console.WriteLine($"\nCreated character: {character.Name}");

            Console.WriteLine("\n=== Character Action ===");
            playerInteraction.DisplayCharacterAction(character);


            //Console.WriteLine("\n=== Input Device Testing ===");
            //Joystick joystick = new Joystick();
            //JoystickAdapter joystickAdapter = new JoystickAdapter(joystick);

            //Console.WriteLine("\nTesting character movement with joystick:");
            //string[] directions = { "Up", "Down", "Left", "Right" };
            //foreach (var direction in directions)
            //{
            //    joystickAdapter.Move(direction);
            //}

            //Console.WriteLine("\nTesting character actions with joystick buttons:");
            //string[] buttons = { "A", "B", "X", "Y" };
            //foreach (var button in buttons)
            //{
            //    joystickAdapter.PressButton(button);
            //}

            Console.WriteLine("\n=== Character Pool Management ===");
            Console.WriteLine("Creating additional characters from pool...");

            Character basicCharacter = characterCustomizer.CreateBasicCharacter(characterType);
            Console.WriteLine($"Basic character created from pool: {basicCharacter.GetType().Name}");
            playerInteraction.DisplayCharacterAction(basicCharacter);

            Console.WriteLine("\nReturning characters to pool...");
            characterPool.ReturnCharacter(character);
            playerInteraction.NotifyReturnCharacter(character);

            characterPool.ReturnCharacter(basicCharacter);
            playerInteraction.NotifyReturnCharacter(basicCharacter);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}