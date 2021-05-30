using System;
using System.Collections.Generic;
using System.Text;

namespace EventVBM.Models
{
    public class DanhMuc
    {
        public int Cate_Id { get; set; }
        public string Name { get; set; }
        public int ParentID { get; set; }
    }
}
