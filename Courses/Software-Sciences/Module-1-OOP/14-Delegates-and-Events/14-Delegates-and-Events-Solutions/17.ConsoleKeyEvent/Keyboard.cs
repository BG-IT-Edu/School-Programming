using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleKeyEvent
{

    public delegate void PressKeyEvent();
    public class Keyboard
    {
        public event PressKeyEvent PressKeyA = null;
        public event PressKeyEvent PressKeyB = null;

        public void PressKeyAEvent()
        {
            if (PressKeyA != null)
            {
                PressKeyA.Invoke();
            }
        }

        public void PressKeyBEvent()
        {
            if (PressKeyB != null)
            {
                PressKeyB.Invoke();
            }
        }

        public void Start()
        {
            while (true)
            {
                string keyPressed = Console.ReadLine();
                switch (keyPressed)
                {
                    case "a":
                        PressKeyAEvent();
                        break;
                    case "b":
                        PressKeyBEvent();
                        break;
                    default:
                        Console.WriteLine("No event handler for key {0}.", keyPressed);
                        break;
                }
            }
        }
    }
}
