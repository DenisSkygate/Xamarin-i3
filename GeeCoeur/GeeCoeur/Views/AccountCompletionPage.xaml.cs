using System;
using System.Collections.Generic;
using GeeCoeur.Views.Account;
using Xamarin.Forms;

namespace GeeCoeur
{
    public partial class AccountCompletionPage : TabbedPage
    {
        public AccountCompletionPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
            Children.Add(new AccountBasicInfoPage() { Title = "Basic Info" });
            Children.Add(new AccountStatusPage() { Title = "Status" });
            Children.Add(new AccountInterestsPage() { Title = "Interests" });
            Children.Add(new AccountSkillsPage() { Title = "Skills" });
            Children.Add(new AccountWorkPage() { Title = "Work" });

        }
    }
}
