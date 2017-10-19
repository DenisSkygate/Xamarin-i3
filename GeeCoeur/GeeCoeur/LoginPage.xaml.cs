using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

           
        }

        async void Login_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GeeCoeur());

        }

        async void Signup_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SignupPage());
        }

    }
}
