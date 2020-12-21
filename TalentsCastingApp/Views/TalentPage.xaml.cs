using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TalentsCastingApp.Views
{
    public partial class TalentPage : ContentPage
    {
        public TalentPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.TalentViewModel();
        }
    }
}
