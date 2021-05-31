using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

using EventVBM.Models;

namespace EventVBM.Services
{
    public class ExtraServices
    {
        public List<Extra> extras;
        public List<Extra> GetExtras()
        {
            extras = new List<Extra>()
            {
                //extra 3
                new Extra
                {
                    Id_extra = 3,
                    Ten_extra = "Thêm Nâms thập cẩm",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 3,
                    Ten_extra = "Thêm Đậu hũ nướng",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 3,
                    Ten_extra = "Thêm Phá lấu Đậu hũ",
                    Slg = 0,
                    NguyenGia = 5000
                },
                //extra 2
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm xà lách",
                    Slg = 0,
                    NguyenGia = 2000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Jambon",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Chả",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Pate",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Xíu Mại",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Bơ",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Giỏ Thủ",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Thịt Nướng",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Chả Cá",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Nấm thập cẩm",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Đậu hũ nướng",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Phá lấu Đậu hũ",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Rau củ rim",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Phô Mai",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Xíu mại đậu",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm thịt nướng đậu",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm nấm nướng ngũ vị",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Trứng rán",
                    Slg = 0,
                    NguyenGia = 10000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Thịt Gogi",
                    Slg = 0,
                    NguyenGia = 10000
                },
                new Extra
                {
                    Id_extra = 2,
                    Ten_extra = "Thêm Thịt Sogogi",
                    Slg = 0,
                    NguyenGia = 15000
                },
                //extra 1
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm xà lách",
                    Slg = 0,
                    NguyenGia = 2000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Jambon",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Chả",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Pate",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Xíu Mại",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Bơ",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Giỏ Thủ",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Thịt Nướng",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Chả Cá",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Nấm thập cẩm",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Đậu hũ nướng",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Phá lấu Đậu hũ",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Rau củ rim",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Phô Mai",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Xíu mại đậu",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm thịt nướng đậu",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm nấm nướng ngũ vị",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Trứng rán",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Thịt Gogi",
                    Slg = 0,
                    NguyenGia = 5000
                },
                new Extra
                {
                    Id_extra = 1,
                    Ten_extra = "Thêm Thịt Sogogi",
                    Slg = 0,
                    NguyenGia = 5000
                },
            };
            return extras;
        }
        public static async Task<List<Extra>> GetExtraById(int time, int Id)
        {
            await Task.Delay(time);
            var data = new ExtraServices().GetExtras().Where(x => x.Id_extra == Id);
            return data.ToList();
        }
    }
}
