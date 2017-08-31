using System;
using System.Collections.Generic;

using Xamarin.Forms;


namespace JustLogin
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
			ServiceWrapper servicewrapper = new ServiceWrapper();
			BindingContext = new Employee();
            var result = await servicewrapper.GetData(1);
            BindingContext = result;
			
        }
		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new LoginPage(), this);
			await Navigation.PopAsync();
		}
		
	}
}
