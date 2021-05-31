using System;
using System.Collections.Generic;
using System.Text;

namespace EventVBM.Models
{
    public class Items
    {
        public int Id_sp { get; set; }
        public string Ten_sp { get; set; }
        public int Cate_ID { get; set; }
        public int Id_Price { get; set; }
        public string HinhAnh { get; set; }
        public int Sluong { get; set; }
        public int Id_Promition { get; set; }
        public string Code_Promition { get; set; }
        public float NguyenGia { get; set; }
        public float DonGia { get; set; }
        public int Lst_extra { get; set; }
        public int Lst_Giavi { get; set; }
    }
}
