﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappyPass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetttingsPage : ContentPage
    {
        public SetttingsPage()
        {
            InitializeComponent();
        }

        private async void BackBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}