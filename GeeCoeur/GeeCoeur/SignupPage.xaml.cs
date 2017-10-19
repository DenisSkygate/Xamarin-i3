using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur
{
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);


        }
        async void Login_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void Signup_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GeeCoeur());

        }
    }
}
