using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace JustLogin
{
	public partial class SearchEmployee : ContentPage
	{
		
		public SearchEmployee()
		{
			InitializeComponent();
		}

        protected async override void OnAppearing ()
        {
            base.OnAppearing();
			ServiceWrapper servicewrapper = new ServiceWrapper();
			var result = await servicewrapper.GetData();
            MainListView.ItemsSource = result;

        }
		
		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new LoginPage(), this);
			await Navigation.PopAsync();
		}
		async void OnClickedSearchEmployee(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchEmployee());
		}
		
	}
}