using System;

using Xamarin.Forms;

namespace ScrollLoginTest
{
    public partial class ScrollLoginTestPage : ContentPage
    {
        public ScrollLoginTestPage()
        {
            InitializeComponent();
			LoginButton.Clicked += HandleLoginButtonClicked;

			Server.ReturnType = ReturnType.Next;
            Server.Completed += (sender, e) => UserName.Focus();

			UserName.ReturnType = ReturnType.Next;
            UserName.Completed += (sender, e) => Password.Focus();

			Password.ReturnType = ReturnType.Go;
            Password.Completed += (sender, e) => HandleLoginButtonClicked(null, EventArgs.Empty);
        }

		void HandleLoginButtonClicked(object sender, EventArgs e)
		{
			DisplayAlert("Button Clicked", "Button Clicked", "Ok");
		}
    }
}
