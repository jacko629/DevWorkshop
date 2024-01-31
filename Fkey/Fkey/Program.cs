using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    // Imports
    [DllImport("user32.dll")]
    static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, IntPtr dwExtraInfo); // keyboard event

    [DllImport("user32.dll")]
    static extern short GetAsyncKeyState(int vKey); // hotkey

    // Class variables
    const byte VK_F = 0x46; // Virtual key code for 'F'
    const uint KEYEVENTF_KEYDOWN = 0x0000; // Key down flag
    const uint KEYEVENTF_KEYUP = 0x0002; // Key up flag
    const int HOTKEY = 0x26; // Up arrow key

    bool enableClicker = false; // Initially disabled
    int clickInterval = 5; // Interval between key presses in milliseconds

    static void Main()
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        // Main loop for auto key presser
        while (true)
        {
            if (GetAsyncKeyState(HOTKEY) < 0) // If hotkey is pressed
            {
                enableClicker = !enableClicker; // Toggle the key presser
                Thread.Sleep(300); // Delay to prevent rapid toggling
            }

            if (enableClicker) // Simulate key press if enabled
            {
                SimulateKeyPress(VK_F);
            }

            Thread.Sleep(clickInterval); // Wait before the next iteration
        }
    }

    // Simulate key press
    void SimulateKeyPress(byte keyCode)
    {
        keybd_event(keyCode, 0, KEYEVENTF_KEYDOWN, IntPtr.Zero); // Key down
        keybd_event(keyCode, 0, KEYEVENTF_KEYUP, IntPtr.Zero); // Key up
    }
}
