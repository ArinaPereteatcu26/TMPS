﻿namespace CreationalDesignPattern.Devices
{
    public class Joystick
    {
        public void MoveJoystick(string direction)
        {
            Console.WriteLine($"Joystick moving in direction: {direction}");
        }

        public void PressButton(string button)
        {
            Console.WriteLine($"Joystick button {button} pressed");
        }
    }
}
