using CreationalDesignPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Devices
{
    public class JoystickAdapter : InputDevice
    {
        private readonly Joystick _joystick;
        private readonly Dictionary<string, string> _buttonMappings;

        public JoystickAdapter(Joystick joystick)
        {
            _joystick = joystick;
            _buttonMappings = new Dictionary<string, string>
            {
                { "A", "Attack" },
                { "B", "Block" },
                { "X", "SpecialAbility" },
                { "Y", "Jump" }
            };
       
        }

        public void Move(string direction)
        {
            _joystick.MoveJoystick(direction); 
        }

        public void PressButton(string button)
        {
            _joystick.PressButton(button);  
        }
    }

}
