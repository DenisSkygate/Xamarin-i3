using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur
{
    public partial class GeeCoeur : ContentPage
    {
        public GeeCoeur()
        {
            InitializeComponent();
            if (!Logged)
                LaunchLogin();
        }

        private void LaunchLogin()
        {
            Navigation.PushModalAsync(new LoginPage());
        }

        static bool Logged = false;
    }
}
