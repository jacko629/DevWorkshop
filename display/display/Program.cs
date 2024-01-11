Using Windows.Graphics.Display.DisplayInformation

namespace DisplayOrientationUWP
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ChangeDisplayOrientation()
        {
            DisplayInformation displayInfo = DisplayInformation.GetForCurrentView();

            // Set the desired orientation (DisplayOrientations values: Landscape, Portrait, LandscapeFlipped, PortraitFlipped)
            displayInfo.Orientation = DisplayOrientations.Portrait;
        }
    }
}
