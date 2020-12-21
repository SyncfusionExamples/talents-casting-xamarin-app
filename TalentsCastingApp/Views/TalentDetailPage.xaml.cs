using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TalentsCastingApp.Views
{
    public partial class TalentDetailPage : ContentPage
    {
        public TalentDetailPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.TalentViewModel();

        }
    }
}
