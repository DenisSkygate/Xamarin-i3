using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur
{
    public partial class AccountCreationPage : TabbedPage
    {
        public AccountCreationPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Children.Add(new LoginPage() { Title = "Log in"});
            Children.Add(new SignupPage() { Title = "Sign up"});
        }
    }
}
