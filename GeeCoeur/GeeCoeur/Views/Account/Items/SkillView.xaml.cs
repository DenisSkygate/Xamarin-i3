using GeeCoeur.Model;
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
    public partial class SkillView : ContentView
    {
        Skill theSkill;
        public SkillView(string theSkillText)
        {
            InitializeComponent();
            theSkill = new Skill(theSkillText);
            skillName.Text = theSkill.name;
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += Button_Clicked;
            DeleteLabel.GestureRecognizers.Add(tapGestureRecognizer);
            GeeCoeurPage.Skills.Add(theSkill);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            GeeCoeurPage.Skills.Remove(theSkill);
            this.IsEnabled = false;
            this.IsVisible = false;
        }
    }
}