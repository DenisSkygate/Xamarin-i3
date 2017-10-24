using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur.Views.Account
{
    public partial class AccountSkillsPage : ContentPage
    {
       

        public AccountSkillsPage()
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
        void AddSkill_Clicked(object sender, System.EventArgs e)
        {
            GeeCoeurPage.Skills.Add(SkillEntry.Text);
            var lab = new Label();
            lab.Text = SkillEntry.Text;
            this.SkillsLayout.Children.Add(lab);
            SkillEntry.Text = "";
        }
    }
}
