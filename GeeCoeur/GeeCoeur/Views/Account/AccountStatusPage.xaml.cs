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

            Switch_Friend.IsToggled = GeeCoeurPage.SignedAccount.Status[0];
            Switch_FriendPlus.IsToggled = GeeCoeurPage.SignedAccount.Status[1];
            Switch_Player2.IsToggled = GeeCoeurPage.SignedAccount.Status[2];
        }
        void Next_Clicked(object sender, System.EventArgs e)
        {
            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) + 1];

            GeeCoeurPage.SignedAccount.Status[0] = Switch_Friend.IsToggled;
            GeeCoeurPage.SignedAccount.Status[1] = Switch_FriendPlus.IsToggled;
            GeeCoeurPage.SignedAccount.Status[2] = Switch_Player2.IsToggled;
        }

        void Back_Clicked(object sender, System.EventArgs e)
        {
            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) - 1];
        }
    }
}
