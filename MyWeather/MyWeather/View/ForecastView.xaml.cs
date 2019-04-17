using Xamarin.Forms;

namespace MyWeather.View
{
    public partial class ForecastView : ContentPage
    {
        public ForecastView()
        {
            InitializeComponent();
            //Uses the Tab2 image for the Forcast tab
            if (Device.RuntimePlatform != Device.UWP)
                Icon = new FileImageSource { File = "tab2.png" };

            ListViewWeather.ItemTapped += (sender, args) => ListViewWeather.SelectedItem = null;
        }
    }
}
