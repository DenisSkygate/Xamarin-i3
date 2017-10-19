using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur
{
    public partial class GeeCoeurPage : ContentPage
    {
        public GeeCoeurPage()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            if (!Logged)
                LaunchLogin();
            if (!AccountCompleted)
                LaunchAccountCompletion();
        }
        private void LaunchLogin()
        {
            Navigation.PushModalAsync(new AccountCreationPage());
        }
        private void LaunchAccountCompletion()
        {
            Navigation.PushModalAsync(new AccountCreationPage());
        }

        static bool Logged = false;
        static bool AccountCompleted = false;
    }
}
