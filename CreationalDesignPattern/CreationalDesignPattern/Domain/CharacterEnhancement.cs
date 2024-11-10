using CreationalDesignPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreationalDesignPattern.Domain
{
    public abstract class CharacterEnhancement : Character
    {
        protected Character _character;
        public CharacterEnhancement(Character character)
        {
            _character = character;
        }
      
        public override void Attack()
        {
            _character.Attack();
        }
    }

    public class ArmorEnhancement : CharacterEnhancement
    {
        public int ArmorValue { get; private set; } = 50;

        public ArmorEnhancement(Character character) : base(character) 
        {
            Name = $"Armored {character.Name}";
        }


        public override void Attack()
        {
            Console.WriteLine($"[Protected by {ArmorValue} armor]");
            base.Attack();
        }
    }

    public class WeaponEnhancement : CharacterEnhancement
    {
        public int BonusDamage { get; private set; } = 25;

        public WeaponEnhancement(Character character) : base(character) 
        {
            Name = $"Enhanced {character.Name}";
        }

        public override void Attack()
        {
            Console.WriteLine($"[Deals {BonusDamage} bonus damage]");
            base.Attack();
        }
    }
}