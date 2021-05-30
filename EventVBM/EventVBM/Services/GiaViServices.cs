using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using EventVBM.Models;
using System.Threading.Tasks;

namespace EventVBM.Services
{
    public class GiaViServices
    {
        public List<GiaVi> giaVis;
        public List<GiaVi> GetGiaVi()
        {
            giaVis = new List<GiaVi>()
            {
                new GiaVi
                {
                    Id_Giavi = 3,
                    Ten_Giavi = "Ớt",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
                new GiaVi
                {
                    Id_Giavi = 3,
                    Ten_Giavi = "Ngò",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
                new GiaVi
                {
                    Id_Giavi = 3,
                    Ten_Giavi = "Rau răm",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
                new GiaVi
                {
                    Id_Giavi = 3,
                    Ten_Giavi = "Dưa leo",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
                new GiaVi
                {
                    Id_Giavi = 3,
                    Ten_Giavi = "Đồ chua",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
                new GiaVi
                {
                    Id_Giavi = 2,
                    Ten_Giavi = "Sốt thịt nướng",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
                new GiaVi
                {
                    Id_Giavi = 2,
                    Ten_Giavi = "Tương ớt",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
                new GiaVi
                {
                    Id_Giavi = 2,
                    Ten_Giavi = "Bơ",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                },
                new GiaVi
                {
                    Id_Giavi = 1,
                    Ten_Giavi = "Đồ chua",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
                new GiaVi
                {
                    Id_Giavi = 1,
                    Ten_Giavi = "Đồ chua",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
                new GiaVi
                {
                    Id_Giavi = 1,
                    Ten_Giavi = "Đồ chua",
                    Giavi_Option1 = "Không",
                    Giavi_Option2 = "Ít",
                    Giavi_Option3 = "Vừa",
                    Giavi_Option4 = "Nhiều",
                },
            };
            return giaVis;
        }
        public static async Task<List<GiaVi>> GetGiaViByID(int time,int id)
        {
            await Task.Delay(time);
            var data = new GiaViServices().GetGiaVi().Where(x => x.Id_Giavi == id);
            return data.ToList();
        }
    }
}
