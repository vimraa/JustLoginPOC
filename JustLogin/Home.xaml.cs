using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JustLogin
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new LoginPage(), this);
			await Navigation.PopAsync();
		}
		async void OnClickedSearch(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchEmployee());
		}
		async void OnClickedProfile(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ProfilePage());
		}
    }
}
