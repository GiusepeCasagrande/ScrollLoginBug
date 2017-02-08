using Xamarin.Forms;

namespace ScrollLoginTest
{
    public partial class ScrollLoginTestPage : ContentPage
    {
        public ScrollLoginTestPage()
        {
            InitializeComponent();
            LoginButton.Clicked += (sender, e) => DisplayAlert("Button Clicked", "Button Clicked", "Ok");
        }
    }
}
