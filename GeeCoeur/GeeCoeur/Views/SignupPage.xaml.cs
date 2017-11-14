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
            GeeCoeurPage.Logged = true;

            GeeCoeurPage.email = Entry_Email.Text;
            GeeCoeurPage.password = Entry_Password.Text;


            await Navigation.PushAsync(new AccountCompletionPage());
        }

       
    }
}
