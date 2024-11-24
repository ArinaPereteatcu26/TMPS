namespace CreationalDesignPattern.Devices
{
    public interface InputDevice
    {
        void Move(string direction);
        void PressButton(string button);
    }
}
