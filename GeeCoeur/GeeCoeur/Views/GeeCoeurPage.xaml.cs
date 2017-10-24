﻿using GeeCoeur.Model;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur
{
    public partial class GeeCoeurPage : ContentPage
    {
        public GeeCoeurPage()
        {
            User = new Account();
            InitializeComponent();
            if (!Logged)
                LaunchLogin();
        }


        private void LaunchLogin()
        {
            var account = new AccountCreationPage();
            account.Disappearing += LoginDisapeared;
            Navigation.PushModalAsync(account);
        }

        private void LoginDisapeared(object sender, EventArgs e)
        {
            var account = new AccountCompletionPage();
            Navigation.PushModalAsync(account);
        }

        public static Account User;

        public static bool Logged = false;
        public static bool AccountCompleted = false;

    }
}
