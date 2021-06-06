using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventVBM.Models;

namespace EventVBM.Services
{
    public class DanhMucServices
    {
        public List<DanhMuc> danhMucs;
        public List<DanhMuc> GetDanhMuc()
        {
            danhMucs = new List<DanhMuc>()  
            {
                new DanhMuc{ Cate_Id = 1, Name = "Món Chính"},
                new DanhMuc{ Cate_Id = 2, Name = "Món Khác"},
                new DanhMuc{ Cate_Id = 3, Name = "Nước"},
                new DanhMuc{ Cate_Id = 4, Name = "Sản phẩm khác"},
                new DanhMuc{ Cate_Id = 5, Name = "Bánh mì", ParentID = 1},
                new DanhMuc{ Cate_Id = 6, Name = "Thuần thực vật", ParentID = 1},
                new DanhMuc{ Cate_Id = 7, Name = "Buger", ParentID = 1},
                new DanhMuc{ Cate_Id = 8, Name = "Mì ý", ParentID = 1},
                new DanhMuc{ Cate_Id = 9, Name = "Egg Family", ParentID = 1},
            };
            return danhMucs;
        }
        public static async Task<List<DanhMuc>> GetDmAsync(int time)
        {
            await Task.Delay(time);
            var data = new DanhMucServices().GetDanhMuc().Where(x => x.ParentID == 0);
            return data.ToList();
        }
        public static async Task<List<DanhMuc>> GetDmByParentId(int time,int parentID)
        {
            await Task.Delay(time);
            var data = new DanhMucServices().GetDanhMuc().Where(x => x.ParentID == parentID);
            return data.ToList();
        }
    }
}
