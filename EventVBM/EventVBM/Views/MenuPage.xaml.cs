using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EventVBM.Models;
using EventVBM.ViewModels;
using EventVBM.Services;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Extensions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace EventVBM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public int pagesize;
        public MenuPage()
        {
            InitializeComponent();
            ScrolltoBottom.Clicked += async (sender, args) =>
            {
                try
                {
                    await scrollView.ScrollToAsync(Collectitems, ScrollToPosition.End , true);
                    await Navigation.PopAsync();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            };
         }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ChildButton.IsVisible = false;
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.CurrentSelection.FirstOrDefault() is Data data))
                return;
            if(data.lst_sub_menu.Count != 1)
            {
                ChildButton.IsVisible = true;
            }
            else
            {               
                ChildButton.IsVisible = false;
            }
        }
    }
}