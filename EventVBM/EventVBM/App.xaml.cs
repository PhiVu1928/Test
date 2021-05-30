﻿using EventVBM.Services;
using EventVBM.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventVBM
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new MenuPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
