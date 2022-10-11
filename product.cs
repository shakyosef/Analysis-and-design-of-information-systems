using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class product
    {
        private string barcode;
        private bool valid_in_stock;
        private int units_in_stock;
        private category category;
        private color color;
        private size size;
        private int price;
        private int amount; //????????
        
        


        public product(string barcode, bool valid_in_stock, int units_in_stock, category category, color color, size size, int price, int amount
           )
        {
            this.barcode = barcode;
            this.valid_in_stock = valid_in_stock;
            this.units_in_stock = units_in_stock;
            this.category = category;
            this.color = color;
            this.size = size;
            this.price = price;
            this.amount = amount;
           
          




        }
    }
}
