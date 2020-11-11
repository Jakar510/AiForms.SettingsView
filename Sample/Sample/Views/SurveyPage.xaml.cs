﻿using System;
using System.Collections.Generic;
using AiForms.Renderers;
using Xamarin.Forms;

namespace Sample.Views
{
    public partial class SurveyPage : ContentPage
    {
        public SurveyPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            settings.ScrollToBottom = true;
            settings.ScrollToTop = true;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            customCell.Reload();
            //var section = settings.Root[0];
            //var temp = section[0];
            //section[0] = temp;
        }
    }
}
