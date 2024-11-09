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

     
        public override void PerformAction()
        {
            _character.PerformAction();
        }

      
        public override void Attack()
        {
            _character.Attack();
        }
    }

    public class ArmorEnhancement : CharacterEnhancement
    {
        public ArmorEnhancement(Character character) : base(character) { }

        public override void PerformAction()
        {
            Console.WriteLine($"{_character.Name} is equipped with armor.");
            base.PerformAction();
        }

        public override void Attack()
        {
            Console.WriteLine($"{_character.Name} attacks with extra defense from the armor.");
            base.Attack();
        }
    }

    public class WeaponEnhancement : CharacterEnhancement
    {
        public WeaponEnhancement(Character character) : base(character) { }

        public override void PerformAction()
        {
            Console.WriteLine($"{_character.Name} is wielding a powerful weapon.");
            base.PerformAction();
        }

        public override void Attack()
        {
            Console.WriteLine($"{_character.Name} strikes with enhanced power from the weapon.");
            base.Attack();
        }
    }
}