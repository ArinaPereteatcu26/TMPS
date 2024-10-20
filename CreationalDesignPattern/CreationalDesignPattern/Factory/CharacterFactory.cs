using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CreationalDesignPattern
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string characterType)
        {
            switch (characterType)
            {
                case "Warrior":
                    return new Warrior();
                case "Mage":
                    return new Wizard();
                case "Archer":
                    return new Archer();
                default:
                    throw new ArgumentException("Unknown character type.");
            }
        }
    }

}
