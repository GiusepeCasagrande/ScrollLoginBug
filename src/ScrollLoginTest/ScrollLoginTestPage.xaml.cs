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
			Server.ReturnCommand = new Command(() => UserName.Focus());

			UserName.ReturnType = ReturnType.Next;
			UserName.ReturnCommand = new Command(() => Password.Focus());

			Password.ReturnType = ReturnType.Go;
			Password.ReturnCommand = new Command(() => HandleLoginButtonClicked(null, EventArgs.Empty));
        }

		void HandleLoginButtonClicked(object sender, EventArgs e)
		{
			DisplayAlert("Button Clicked", "Button Clicked", "Ok");
		}
    }
}
