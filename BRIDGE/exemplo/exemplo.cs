using System;

namespace BridgeExample
{
    public interface IDevice
    {
        void TogglePower();
        void VolumeUp();
        void VolumeDown();
    }

    public class Tv : IDevice
    {
        private bool isOn = false;
        private int volume = 0;

        public void TogglePower()
        {
            isOn = !isOn;
            Console.WriteLine($"TV power: {isOn}");
        }

        public void VolumeUp()
        {
            if (isOn)
            {
                volume++;
                Console.WriteLine($"TV volume: {volume}");
            }
        }

        public void VolumeDown()
        {
            if (isOn)
            {
                volume--;
                Console.WriteLine($"TV volume: {volume}");
            }
        }
    }

    public class Radio : IDevice
    {
        private bool isOn = false;
        private int volume = 0;

        public void TogglePower()
        {
            isOn = !isOn;
            Console.WriteLine($"Radio power: {isOn}");
        }

        public void VolumeUp()
        {
            if (isOn)
            {
                volume++;
                Console.WriteLine($"Radio volume: {volume}");
            }
        }

        public void VolumeDown()
        {
            if (isOn)
            {
                volume--;
                Console.WriteLine($"Radio volume: {volume}");
            }
        }
    }

    public abstract class RemoteControl
    {
        protected IDevice device;

        protected RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public abstract void TogglePower();
        public abstract void VolumeUp();
        public abstract void VolumeDown();
    }

    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public override void TogglePower()
        {
            device.TogglePower();
        }

        public override void VolumeUp()
        {
            device.VolumeUp();
        }

        public override void VolumeDown()
        {
            device.VolumeDown();
        }

        public void Mute()
        {
            Console.WriteLine("Remote: Mute device");
            while (true)
            {
                device.VolumeDown();
                // interrompe o loop quando o volume chegar a zero
                break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new Tv();
            RemoteControl remote = new AdvancedRemoteControl(tv);
            remote.TogglePower();
            remote.VolumeUp();
            ((AdvancedRemoteControl)remote).Mute();

            IDevice radio = new Radio();
            remote = new AdvancedRemoteControl(radio);
            remote.TogglePower();
            remote.VolumeUp();
            remote.VolumeDown();
        }
    }
}