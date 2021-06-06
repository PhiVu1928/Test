using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EventVBM.Models;
using System.Linq;
using Newtonsoft.Json;
using System.Diagnostics;

namespace EventVBM.Services
{
    public class ApiServices
    {
        public List<Data> datas;
        public async Task<List<Data>> GetDatas()
        {
            using (var cl = new HttpClient())
            {
                string url = "http://vuabanhmi.com:6519/api/UserData/get_menu_data?channel=1";
                var res = await cl.GetAsync(url);
                string js = await res.Content.ReadAsStringAsync();
                var item = JsonConvert.DeserializeObject<Root>(js);
                return item.Datas;
            }
        }
        public static async Task<List<Data>> getdata()
        {
            await Task.Delay(1000);
            var data = new ApiServices().GetDatas();
            return data.Result.ToList();
        }
    }
}
