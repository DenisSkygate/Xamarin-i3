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
        }
        void Next_Clicked(object sender, System.EventArgs e)
        {
            if (Birthday.Date.Year <= DateTime.Today.Year - 18)
            {
                GeeCoeurPage.User.SetBasicInfo(firstName: FirstName.Text, lastName: Lastname.Text, username: Username.Text, birthday: Birthday.Date);
                var papa = (this.Parent as TabbedPage);
                papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) + 1];
            }
            
        }

    }
}
