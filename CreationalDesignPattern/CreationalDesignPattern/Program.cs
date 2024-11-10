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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Character Creation System!");

           
            PlayerInteraction playerInteraction = new PlayerInteraction();
            CharacterCreationService creationService = CharacterCreationService.Instance;
            CharacterPool characterPool = new CharacterPool();
            CharacterCustomizer characterCustomizer = new CharacterCustomizer(creationService);

            string characterType = playerInteraction.GetCharacterChoice();

            Console.WriteLine("Do you want to add armor to your character? (yes/no)");
            bool addArmor = Console.ReadLine().ToLower() == "yes";

            Console.WriteLine("Do you want to add a weapon to your character? (yes/no)");
            bool addWeapon = Console.ReadLine().ToLower() == "yes";

            Character character = characterCustomizer.ConfigureCharacter(characterType, addArmor, addWeapon);
            playerInteraction.DisplayCharacterAction(character);

            characterPool.GetCharacter(characterType);

            Console.WriteLine("\nTesting the joystick input device...");
            Joystick joystick = new Joystick();
            JoystickAdapter joystickAdapter = new JoystickAdapter(joystick);
            joystickAdapter.Move("Up");
            joystickAdapter.PressButton("A");


            Console.WriteLine("\nReturning character to the pool...");
            characterPool.ReturnCharacter(character);
            playerInteraction.NotifyReturnCharacter(character);
        }
    }
}
