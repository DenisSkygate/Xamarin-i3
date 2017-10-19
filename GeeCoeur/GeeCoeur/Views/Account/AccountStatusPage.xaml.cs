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
        }

        void Back_Clicked(object sender, System.EventArgs e)
        {
            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) - 1];
        }
    }
}
