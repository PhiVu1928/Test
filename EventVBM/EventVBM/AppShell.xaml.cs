using EventVBM.ViewModels;
using EventVBM.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EventVBM
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("home", typeof(MenuPage));
        }
    }
}
