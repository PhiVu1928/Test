using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventVBM.Models;

namespace EventVBM.Services
{
    public class ItemsServices
    {
        public List<Items> Items;
        public List<Items> GetItems()
        {
            Items = new List<Items>()
           {
               new Items
               {
                   Cate_ID = 3,
                   Ten_sp = "Trà chanh sả",
                   Sluong = 0,
                   NguyenGia = 15.000,
                   HinhAnh ="https://www.phuclong.com.vn/uploads/dish/005aaeed660473-trnhnphclong.png"
               },
               new Items
               {
                   Cate_ID = 3,
                   Ten_sp = "Trà chanh sả",
                   Sluong = 0,
                   NguyenGia = 15.000,
                   HinhAnh ="https://www.phuclong.com.vn/uploads/dish/005aaeed660473-trnhnphclong.png"
               },
               new Items
               {
                   Cate_ID = 3,
                   Ten_sp = "Trà chanh sả",
                   Sluong = 0,
                   NguyenGia = 15.000,
                   HinhAnh ="https://www.phuclong.com.vn/uploads/dish/005aaeed660473-trnhnphclong.png"
               },
               new Items
               {
                   Cate_ID = 3,
                   Ten_sp = "Trà chanh sả",
                   Sluong = 0,
                   NguyenGia = 15.000,
                   HinhAnh ="https://www.phuclong.com.vn/uploads/dish/005aaeed660473-trnhnphclong.png"
               },
               new Items
               {
                   Cate_ID = 3,
                   Ten_sp = "Trà chanh sả",
                   Sluong = 0,
                   NguyenGia = 15.000,
                   HinhAnh ="https://www.phuclong.com.vn/uploads/dish/005aaeed660473-trnhnphclong.png"
               },
               new Items
               {
                   Cate_ID = 3,
                   Ten_sp = "Trà chanh sả",
                   Sluong = 0,
                   NguyenGia = 15.000,
                   HinhAnh ="https://www.phuclong.com.vn/uploads/dish/005aaeed660473-trnhnphclong.png"
               },
               new Items
               {
                   HinhAnh = "WA_BRG_sogogi.jpg",
                   Ten_sp = "Burger Sogogi",
                   NguyenGia = 29.000,
                   Cate_ID = 7, 
                   Lst_extra = 2,
                   Lst_Giavi = 2,
               },
               new Items
               {
                   HinhAnh = "WA_BRG_gogi.jpg",
                   Ten_sp = "Burger Gogi",
                   NguyenGia = 29.000,
                   Cate_ID = 7, 
                   Lst_extra = 2,
                   Lst_Giavi = 2,
               },
               new Items
               {
                   HinhAnh = "WA_BRG_gaxe.jpg",
                   Ten_sp = "Burger Gà Xe",
                   NguyenGia = 29.000,
                   Cate_ID = 7, 
                   Lst_extra = 2,
                   Lst_Giavi = 2,
               },
               new Items
               {
                   HinhAnh = "WA_BRG_mattroi.jpg",
                   Ten_sp = "Burger Bánh Mặt Trời",
                   NguyenGia = 25.000,
                   Cate_ID = 7, 
                   Lst_extra = 2,
                   Lst_Giavi = 2,
               },
               new Items
               {
                   HinhAnh = "WA_BRG_xiumai.jpg",
                   Ten_sp = "Burger Xíu Mại",
                   NguyenGia = 25.000,
                   Cate_ID = 7, 
                   Lst_extra = 2,
                   Lst_Giavi = 2,
               },
               new Items
               {
                   HinhAnh = "WA_BRG_bbq.jpg",
                   Ten_sp = "Burger Thịt Nướng",
                   NguyenGia = 25.000,
                   Cate_ID = 7, 
                   Lst_extra = 2,
                   Lst_Giavi = 2,
               },
               new Items
               {
                   HinhAnh = "MY_Namthapcam.jpg",
                   Ten_sp = "Mì Ý Nấm Thập Cẩm",
                   NguyenGia = 34.000,
                   Cate_ID = 8, 
                   Lst_extra = 3,
                   Lst_Giavi = 3,
               },
               new Items
               {
                   HinhAnh = "MY_Dauhunam.jpg",
                   Ten_sp = "Mì Ý Đậu Hũ Nấm",
                   NguyenGia = 34.000,
                   Cate_ID = 8, 
                   Lst_extra = 3,
                   Lst_Giavi = 3,
               },
               new Items
               {
                   HinhAnh = "MY_Dauhuraucu.jpg",
                   Ten_sp = "Mì Ý Đậu Hũ Rau Củ",
                   NguyenGia = 34.000,
                   Cate_ID = 8, 
                   Lst_extra = 3,
                   Lst_Giavi = 3,
               },
               new Items
               {
                   HinhAnh = "MY_Dauhuphalau.jpg",
                   Ten_sp = "Mì Ý Đậu Hũ Phá Lấu",
                   NguyenGia = 34.000,
                   Cate_ID = 8, 
                   Lst_extra = 3,
                   Lst_Giavi = 3,
               },
               new Items
               {
                   HinhAnh = "zm_chaynam.jpg",
                   Ten_sp = "Bánh Mì Nấm Thập Cẩm",
                   NguyenGia = 25.000,
                   Cate_ID = 1, 
                   Lst_extra = 1,
                   Lst_Giavi = 1,
               },
               new Items
               {
                   HinhAnh = "zm_chaydauhunuong.jpg",
                   Ten_sp = "Bánh Mì Đậu Hũ Nướng",
                   NguyenGia = 29.000,
                   Cate_ID = 5,
                   Lst_extra = 1,
                   Lst_Giavi = 1,
               },
               new Items
               {
                   HinhAnh = "zm_chayphalaudauhu.jpg",
                   Ten_sp = "Bánh Mì Phá Lấu Đậu Hũ",
                   NguyenGia = 29.000,
                   Cate_ID = 5,
                   Lst_extra = 1,
                   Lst_Giavi = 1,
               },
               new Items
               {
                   HinhAnh = "zm_chayraucurim.jpg",
                   Ten_sp = "Bánh Mì Rau Củ Rim",
                   NguyenGia = 25.000,
                   Cate_ID = 5,
                   Lst_extra = 1,
                   Lst_Giavi = 1,
               },
               new Items
               {
                   HinhAnh = "zm_dauhuraucu.jpg",
                   Ten_sp = "Bánh Mì Rau Củ Om Đậu",
                   NguyenGia = 29.000,
                   Cate_ID = 5,
                   Lst_extra = 1,
                   Lst_Giavi = 1,
               },
               new Items
               {
                   HinhAnh = "zm_namnguvi.jpg",
                   Ten_sp = "Bánh Mì Nấm Nướng",
                   NguyenGia = 25.000,
                   Cate_ID = 5,
                   Lst_extra = 1,
                   Lst_Giavi = 1,
               },
           };
            return Items;
        }
        public static async Task<List<Items>> Getitems(int time)
        {
            await Task.Delay(time);
            var data = new ItemsServices().GetItems();
            return data.ToList();
        }
        public static async Task<List<Items>> GetItemsByCate(int time, int cateId)
        {
            await Task.Delay(time);
            var data = new ItemsServices().GetItems().Where(x => x.Cate_ID == cateId);
            return data.ToList();
        }
    }
}
