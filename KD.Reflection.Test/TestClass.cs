using System;
using System.Runtime.InteropServices;

namespace KD.Reflection.Tests
{
    public class TestClass
    {
        public int MyProperty { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        public void PrintHello()
        {
            MessageBox(new IntPtr(0), "Hello from KD.Reflection !!!", "", 0);
        }
    }
}