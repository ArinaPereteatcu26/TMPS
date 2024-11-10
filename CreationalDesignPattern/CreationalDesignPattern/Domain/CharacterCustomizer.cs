using CreationalDesignPattern.Factory;
using CreationalDesignPattern.Pool;
using GameCharacterCreation.client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Domain
{
    public class CharacterCustomizer
    {
        private readonly CharacterCreationService _creationService;
        private readonly CharacterPool _characterPool;
        private readonly PlayerInteraction _playerInteraction;

        public CharacterCustomizer(CharacterCreationService creationService)
        {
            _creationService = CharacterCreationService.Instance;
            _characterPool = new CharacterPool();
            _playerInteraction = new PlayerInteraction();
        }
        public Character CreateBasicCharacter(string type)
        {
            return _characterPool.GetCharacter(type);
        }

        public Character CreateCustomCharacter(string type, bool addArmor, bool addWeapon)
        {
            Character character = _characterPool.GetCharacter(type);

            if (addArmor)
            {
                character = new ArmorEnhancement(character);
            }

            if (addWeapon)
            {
                character = new WeaponEnhancement(character);
            }

            return character;
        }
    }
}
