using System;


using EventVBM.Models;
using EventVBM.Services;
using EventVBM.ViewModels;
using Xamarin.Forms;
using System.Diagnostics;
using MvvmHelpers;
using System.Linq;
using System.Threading.Tasks;

namespace EventVBM.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public int page = 0;
        public int pagesize = 10;
        public Command GetCateItems { get; set; }
        public Command Lazyload { get; set; }
        public ObservableRangeCollection<DanhMuc> danhMucs { get; set; }
        public ObservableRangeCollection<Items> Items { get; set; }
        public MenuViewModel()
        {
            danhMucs = new ObservableRangeCollection<DanhMuc>();
            Items = new ObservableRangeCollection<Items>();
            Lazyload = new Command(async () => await Getlazy());
            GetCateItems = new Command(async () => await GetCateItemsAsync());
            GetItems();
            GetDM();
        }

        private Task GetCateItemsAsync()
        {
            throw new NotImplementedException();
        }

        private void GetItems()
        {
            Items.Clear();
            var data = new ItemsServices().GetItems();
            foreach(var items in data.Take(pagesize))
            {
                Items.Add(items);
            }
        }

        private async Task Getlazy()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            await Task.Delay(100);
            Items.AddRange(Items.Skip(page * pagesize).Take(pagesize));
            page += pagesize;
            IsBusy = false;
        }

        public async void Getitems()
        {
            try
            {
                Items.Clear();
                var data = await ItemsServices.Getitems(100);
                foreach(var items in data)
                {
                    Items.Add(items);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        public async void GetDM()
        {
            try
            {
                danhMucs.Clear();
                var data = await DanhMucServices.GetDmAsync(100);
                foreach(var items in data)
                {
                    danhMucs.Add(items);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
