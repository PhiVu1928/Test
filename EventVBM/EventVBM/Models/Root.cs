using System;
using System.Collections.Generic;
using EventVBM.Models;
using System.Text;

namespace EventVBM.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class LstSize
    {
        public int id { get; set; }
        public int size { get; set; }
        public string size_name_vn { get; set; }
        public string size_name_en { get; set; }
        public string name_vn { get; set; }
        public string name_en { get; set; }
        public double price { get; set; }
    }

    public class LstCombo
    {
        public int id { get; set; }
        public string name_vn { get; set; }
        public string name_en { get; set; }
        public double price { get; set; }
        public string combine_id { get; set; }
    }

    public class LstEme
    {
        public int index { get; set; }
        public string name_vn { get; set; }
        public string name_en { get; set; }
        public int class_id { get; set; }
        public int type_eme { get; set; }
        public string img { get; set; }
        public bool is_has_combo { get; set; }
        public List<LstSize> lst_size { get; set; }
        public List<LstCombo> lst_combo { get; set; }
        public List<int> lst_unsell_store { get; set; }
    }

    public class LstSubMenu
    {
        public int id { get; set; }
        public int index { get; set; }
        public string name_vn { get; set; }
        public string name_en { get; set; }
        public List<LstEme> lst_emes { get; set; }
    }

    public class Data
    {
        public int id { get; set; }
        public int index { get; set; }
        public string name_vn { get; set; }
        public string name_en { get; set; }
        public List<LstSubMenu> lst_sub_menu { get; set; }
    }

    public class Root
    {
        public bool Success { get; set; }
        public int Count { get; set; }
        public List<Data> Datas { get; set; }
    }


}
