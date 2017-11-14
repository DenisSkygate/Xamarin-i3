using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur.Views.Account
{
    public partial class AccountBasicInfoPage : ContentPage
    {
        public AccountBasicInfoPage()
        {
            InitializeComponent();
            Entry_FirstName.Text = GeeCoeurPage.SignedAccount.FirstName;
            Entry_Lastname.Text = GeeCoeurPage.SignedAccount.LastName;
            Entry_Username.Text = GeeCoeurPage.SignedAccount.Pseudo;
            Entry_Birthday.Date = GeeCoeurPage.SignedAccount.Birthday;

        }
        void Next_Clicked(object sender, System.EventArgs e)
        {
            GeeCoeurPage.SignedAccount.FirstName = Entry_FirstName.Text;
            GeeCoeurPage.SignedAccount.LastName = Entry_Lastname.Text;
            GeeCoeurPage.SignedAccount.Pseudo = Entry_Username.Text;

            GeeCoeurPage.SignedAccount.Birthday = Entry_Birthday.Date;

            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) + 1];
        }
    }
}
