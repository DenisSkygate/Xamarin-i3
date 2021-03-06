﻿using System;
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
        void Login_Clicked(object sender, System.EventArgs e)
        {
            var parent = this.Parent as TabbedPage;
            parent.CurrentPage = parent.Children[0];
        }

        async void Signup_Clicked(object sender, System.EventArgs e)
        {
            if (Entry_Password.Text == Entry_PasswordVerif.Text)
            {
                GeeCoeurPage.Logged = true;

                GeeCoeurPage.SignedAccount.Email = Entry_Email.Text;
                GeeCoeurPage.SignedAccount.Password = Entry_Password.Text;

                await Navigation.PushAsync(new AccountCompletionPage());
            }
            else
            {
                Entry_PasswordVerif.BackgroundColor = Color.Red;
            }
        }

        private void Entry_PasswordVerif_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry_PasswordVerif.BackgroundColor = Color.Transparent;
        }
    }
}
