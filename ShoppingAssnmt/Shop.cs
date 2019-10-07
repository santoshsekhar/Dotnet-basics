using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAssnmt
{
    class Shop
    {
        public string RegistrationNo{ get; set;}
        public int Capital { get; set; }
        public string Owner { get; set; }
        public string ShopName { get; set; }
        public string ShopType { get; set; }
        public int FloorNo { get; set; }
        public int Status { get; set; }

        public static int randomNo = 1;
        private string floorNumber { get; set; }
        private string shStatus { get; set; }

        public Shop( int capital, string owner, string shopName, 
                    string shopType, int floorNo)
        {
            this.RegistrationNo = string.Concat("SH000", Convert.ToString(randomNo));
            this.Capital = capital;
            this.Owner = owner;
            this.ShopName = shopName;
            this.ShopType = shopType;
            this.FloorNo = floorNo;
            this.Status = 1;
        }

        //public Shop(int capital, string owner, string shopName, string shopType, string floorNumber, string shStatus)
        //{
        //    Capital = capital;
        //    Owner = owner;
        //    ShopName = shopName;
        //    ShopType = shopType;
        //    this.floorNumber = floorNumber;
        //    this.shStatus = shStatus;
        //}
    }
}
