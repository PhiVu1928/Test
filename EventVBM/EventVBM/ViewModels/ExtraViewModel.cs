using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;
using EventVBM.Models;
using EventVBM.Services;

using System.Threading.Tasks;
using Xamarin.Forms;

namespace EventVBM.ViewModels
{
    public class ExtraViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Price> Prices;
        public ObservableRangeCollection<Extra> Extras;
        public ObservableRangeCollection<GiaVi> giaVis;
        public ObservableRangeCollection<Items> ItemsWater;
        public Items _SelectedItems;
        public ExtraViewModel(Items items)
        {
            SelectedItems = items;
            Prices = new ObservableRangeCollection<Price>();
            Extras = new ObservableRangeCollection<Extra>();
            giaVis = new ObservableRangeCollection<GiaVi>();
            ItemsWater = new ObservableRangeCollection<Items>();
            Getprice(SelectedItems.Id_Price);
            Getextra();
            GetGiavi();
            GetWater();
        }
        public Items SelectedItems
        {
            get
            {
                return _SelectedItems;
            }
            set
            {
                _SelectedItems = value;
                OnPropertyChanged();
            }
        }
        public async void GetWater()
        {
            ItemsWater.Clear();
            var data = await ItemsServices.GetWater(100);
            foreach(var items in data)
            {
                ItemsWater.Add(items);
            }
        }
        public async void Getprice(int id)
        {
            Prices.Clear();
            var data = await PriceServices.GetPricesAsync(id);
            foreach (var items in data)
            {
                Prices.Add(items);
            }
        }
        public async void Getextra()
        {
            Extras.Clear();
            var data = await ExtraServices.GetExtraById(100, SelectedItems.Lst_extra);
            foreach(var items in data)
            {
                Extras.Add(items);
            }
        }
        public async void GetGiavi()
        {
            giaVis.Clear();
            var data = await GiaViServices.GetGiaViByID(100, SelectedItems.Lst_Giavi);
            foreach(var items in data)
            {
                giaVis.Add(items);
            }
        }
    }
}
