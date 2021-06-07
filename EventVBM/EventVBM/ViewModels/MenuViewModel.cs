using System;
using EventVBM.Models;
using EventVBM.Services;
using EventVBM.ViewModels;
using Xamarin.Forms;
using System.Diagnostics;
using MvvmHelpers;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using Xamarin.Forms.Extended;

namespace EventVBM.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public int pagesize = 10;
        public LstSubMenu _selectedSubmenu { get; set; }
        public Data _selectedDanhmucs { get; set; }
        public ObservableRangeCollection<LstSubMenu> lstSubMenus { get; set; }
        public ObservableRangeCollection<Data> danhMucs { get; set; }
        public InfiniteScrollCollection<LstEme> lstEmes { get; set; }
        public MenuViewModel()
        {
            danhMucs = new ObservableRangeCollection<Data>();
            lstSubMenus = new ObservableRangeCollection<LstSubMenu>();
            lstEmes = new InfiniteScrollCollection<LstEme>
            {
                OnLoadMore = async () =>
                {
                    await Task.Delay(1000);
                    IsBusy = true;
                    int page = lstEmes.Count() / pagesize;
                    List<LstEme> lsts = await GetEmenu(page, pagesize);
                    IsBusy = false;
                    return lsts;
                },
                OnCanLoadMore = () => lstEmes.Count < Total
            };
            GetAPI();
        }
        public Data SelectedDanhmucs
        {
            get
            {
                return _selectedDanhmucs;
            }
            set
            {
                _selectedDanhmucs = value;
                lstSubMenus.Clear();
                if (_selectedDanhmucs.lst_sub_menu.Count != 1)
                {
                    lstSubMenus.AddRange(_selectedDanhmucs.lst_sub_menu);
                }
                else
                {
                    lstEmes.Clear();
                    Total = 0;
                    foreach(var items in _selectedDanhmucs.lst_sub_menu)
                    {
                        lstEmes.AddRange(items.lst_emes.Where(x => x.img != ""));
                        Total++;
                    }                    
                }
                OnPropertyChanged();
            }
        }
        public LstSubMenu SelectedSubmenu
        {
            get
            {
                return _selectedSubmenu;
            }
            set
            {
                _selectedSubmenu = value;
                Total = 0;
                lstEmes.Clear();
                lstEmes.AddRange(_selectedSubmenu.lst_emes.Take(pagesize));
                Total = _selectedSubmenu.lst_emes.Count();
                OnPropertyChanged();
            }
        }
        private int _total;
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                OnPropertyChanged();
            }
        }
        
        public async Task<List<LstEme>> GetEmenu(int page, int pagesize)
        {
            await Task.Delay(100);
            var data = SelectedSubmenu.lst_emes.Skip(page * pagesize).Take(pagesize);
            return data.ToList();
        }
        

        public async void GetAPI()
        {
            try
            {
                using (var cl = new HttpClient())
                {
                    string url = "http://vuabanhmi.com:6519/api/UserData/get_menu_data?channel=1";
                    var res = await cl.GetAsync(url);
                    string js = await res.Content.ReadAsStringAsync();
                    var DMlist = JsonConvert.DeserializeObject<Root>(js);
                    danhMucs.AddRange(DMlist.Datas);
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Errors", ex.ToString(), "OK");
            }

        }
    }
}
