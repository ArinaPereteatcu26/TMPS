using System;
using CreationalDesignPattern.Domain;
using CreationalDesignPattern.Factory;
using CreationalDesignPattern.Pool;
using GameCharacterCreation.client;

namespace GameCharacterCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Character Creation System!");

            // Initialize interaction service for player
            PlayerInteraction playerInteraction = new PlayerInteraction();

            // Get the singleton instance of CharacterCreationService
            CharacterCreationService creationService = CharacterCreationService.Instance;

            // Create a pool for reusing characters
            CharacterPool characterPool = new CharacterPool();

            // Ask the player to choose a character type
            string characterType = playerInteraction.GetCharacterChoice();

            // Create or reuse the character based on player choice
            Character character = characterPool.GetCharacter(characterType);
            playerInteraction.DisplayCharacterAction(character);

            // Return the character to the pool (optional step to show pooling)
            Console.WriteLine("\nReturning character to the pool...");
            characterPool.ReturnCharacter(character);
            playerInteraction.NotifyReturnCharacter(character);
        }
    }
}
