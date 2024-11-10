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

        public JoystickAdapter(Joystick joystick)
        {
            _joystick = joystick;
        }

        public void Move(string direction)
        {
            _joystick.MoveJoystick(direction);  // Adapts move to the joystick's method
        }

        public void PressButton(string button)
        {
            _joystick.PressButton(button);  // Adapts button press to the joystick's method
        }
    }
}
