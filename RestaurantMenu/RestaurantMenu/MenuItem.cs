using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        double price { get; set; }
        string description { get; set; }
        string category { get; set; }
        bool isNew { get; set; }

        public MenuItem(double price, string description,string category, bool isnew = true)
        {
            this.price = price;
            this.description = description;
            this.category = category;
            this.isNew = isnew;
        }
    }
}
