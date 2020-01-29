using System;

namespace CAdvanced
{
    public class MenuEventArgs : EventArgs
    {
        public MenuEventArgs(int current)
        {
            Current = current;
            IsExit = false;
        }

        public bool IsExit { get; set; }

        public int Current { get; set; }
    }
}