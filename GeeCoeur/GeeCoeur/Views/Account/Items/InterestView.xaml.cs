using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeeCoeur.Views.Account.Items
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InterestView : ContentView
    {
        string Name;
        List<string> theList;

        public InterestView(string theInterestName, List<string> list)
        {
            InitializeComponent();
            Name = theInterestName;
            InterestName.Text = theInterestName;

            theList = list;
            list.Add(Name);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            theList.Remove(Name);
            this.IsEnabled = false;
            this.IsVisible = false;
        }
    }
}