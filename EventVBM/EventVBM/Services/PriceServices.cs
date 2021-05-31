using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EventVBM.Models;

namespace EventVBM.Services
{
    public class PriceServices
    {
        public List<Price> prices;
        public List<Price> GetPrices()
        {
            prices = new List<Price>()
            {
                new Price
                {
                    Id_Price = 1,
                    Size_Name = "Ăn nhẹ",
                    Size_Price = 20000
                },
                new Price
                {
                    Id_Price = 1,
                    Size_Name = "Vừa bụng",
                    Size_Price = 25000
                },
                new Price
                {
                    Id_Price = 1,
                    Size_Name = "No nê",
                    Size_Price = 29000
                },
                new Price
                {
                    Id_Price = 2,
                    Size_Name = "Ăn nhẹ",
                    Size_Price = 25000
                },
                new Price
                {
                    Id_Price = 2,
                    Size_Name = "Vừa bụng",
                    Size_Price = 29000
                },
                new Price
                {
                    Id_Price = 2,
                    Size_Name = "No nê",
                    Size_Price = 35000
                },
                new Price
                {
                    Id_Price = 3,
                    Size_Name = "Ăn nhẹ",
                    Size_Price = 32000
                },
                new Price
                {
                    Id_Price = 3,
                    Size_Name = "Vừa bụng",
                    Size_Price = 37000
                },
                new Price
                {
                    Id_Price = 3,
                    Size_Name = "No nê",
                    Size_Price = 42000
                },
                new Price
                {
                    Id_Price = 4,
                    Size_Name = "Ăn nhẹ",
                    Size_Price = 29000
                },
                new Price
                {
                    Id_Price = 4,
                    Size_Name = "Vừa bụng",
                    Size_Price = 34000
                },
                new Price
                {
                    Id_Price = 4,
                    Size_Name = "No nê",
                    Size_Price = 39000
                },
            };
            return prices;
        }
        public static async Task<List<Price>> GetPricesAsync(int id)
        {
            await Task.Delay(100);
            var data = new PriceServices().GetPrices().Where(x => x.Id_Price == id);
            return data.ToList();
        }
    }
}
