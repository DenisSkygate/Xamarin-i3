using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur.Views.Account
{
    public partial class AccountStatusPage : ContentPage
    {
        public AccountStatusPage()
        {
            InitializeComponent();
        }
        void Next_Clicked(object sender, System.EventArgs e)
        {
            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) + 1];

            GeeCoeurPage.status_Friend = Switch_Friend.IsToggled;
            GeeCoeurPage.status_FriendPlus = Switch_FriendPlus.IsToggled;
            GeeCoeurPage.status_Player2 = Switch_Player2.IsToggled;
        }

        void Back_Clicked(object sender, System.EventArgs e)
        {
            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) - 1];
        }
    }
}
