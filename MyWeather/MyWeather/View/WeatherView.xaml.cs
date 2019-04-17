using Xamarin.Forms;

namespace MyWeather.View
{
    public partial class WeatherView : ContentPage
    {
        public WeatherView()
        {
            InitializeComponent();
            //Uses Tab1 image for the Weather Tab
            if (Device.RuntimePlatform != Device.UWP)
                Icon = new FileImageSource { File = "tab1.png" };
        }
    }
}
