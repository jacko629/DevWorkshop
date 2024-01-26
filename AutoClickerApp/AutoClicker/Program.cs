using System.Runtime.InteropServices;

//imports

[DllImport("user32.dll")]
static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo); //mouse click

[DllImport( "user32.dll")]
static extern short GetAsyncKeyState(int vKey); //hotkey



//class


const uint LEFTDOWN = 0x02;
const uint LEFTUP = 0x04;
const int HOTKEY = 0x26; //up arrow key

bool enableClicker = false; //set it to false  before click our hotkey
int clickInterval = 5;//how many milli-seconds we wait before clicking again



//main loop for autoclicker

while (true)
{
    if (GetAsyncKeyState(HOTKEY) < 0) ;
    { //if hotkey is down
        enableClicker = !enableClicker; //enable or disable depending on the bool value
        Thread.Sleep(300); //a little delay bewtween hotkey usage
    }
    if (enableClicker) //click if enabled
    {
        MouseClick();
    }
    Thread.Sleep(clickInterval);
}




//create mouse click

void MouseClick()
{
    mouse_event(LEFTDOWN, 0, 0, 0, IntPtr.Zero); //we dont need anymore information than the leftdown constant

    mouse_event(LEFTUP, 0, 0, 0, IntPtr.Zero); //press down then up
}