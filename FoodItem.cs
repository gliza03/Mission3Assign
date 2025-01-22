using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3Assign
{
    internal class FoodItem
    {
        public string Name, Cat, Quantity, ExpDate;
        public FoodItem(string name, string cat, string quantity, string expirationDate)
        {
            Name = name;
            Cat = cat;
            Quantity = quantity;
            ExpDate = expirationDate;
        }
    }
}
