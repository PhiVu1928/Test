using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventVBM.Models;
using EventVBM.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventVBM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ChildButton.IsVisible = false;
        }
        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.CurrentSelection.FirstOrDefault() is DanhMuc danhMuc))
                return;
            var data = await DanhMucServices.GetDmByParentId(100,danhMuc.Cate_Id);
            if(data.Count() > 0)
            {
                ChildButton.ItemsSource = data;
                ChildButton.IsVisible = true;
            }
            else
            {
                var items = await ItemsServices.GetItemsByCate(100, danhMuc.Cate_Id);
                Collecitems.ItemsSource = items;
                ChildButton.IsVisible = false;
            }
            
        }

        private void Collecitems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        async void ChildButton_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.CurrentSelection.FirstOrDefault() is DanhMuc danhMuc))
                return;
            var data = await ItemsServices.GetItemsByCate(100, danhMuc.Cate_Id);
            Collecitems.ItemsSource = data;
            ((CollectionView)sender).SelectedItems = null;
        }
    }
}