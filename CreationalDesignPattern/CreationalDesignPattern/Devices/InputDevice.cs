using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Devices
{
    public interface InputDevice
    {
        void Move(string direction);
        void PressButton(string button);
    }
}
