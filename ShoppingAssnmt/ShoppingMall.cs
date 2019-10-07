using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAssnmt
{
    class ShoppingMall
    {
        List<Shop> shops = new List<Shop>();
         public void AddShop(Shop obj)
        {
            shops.Add(obj);
        }

        public void CloseShop(string RegistrationNo)
        {
            foreach(Shop s in shops)
            {
                if(s.RegistrationNo  == RegistrationNo)
                {
                    s.Status = 0;
                }
                else
                {
                    s.Status = 1;
                }
            }
        }

        public void ModifyShop(string RegistrationNo, string option, string value)
        {
            foreach(Shop s in shops)
            {
                if(s.RegistrationNo == RegistrationNo)
                {
                    switch (option.ToUpper())
                    {
                        case "NAME": { s.ShopName = value; break; }
                        case "OWNER": { s.Owner = value;  break; }
                        case "SHOPTYPE": { s.ShopName = value; break; }
                        default: break;                   
                    }
                }
            }
        }


        public List<string> GetShopNames(int FloorNo)
        {
            List<string> shopNames = new List<string>();
            foreach(Shop s in shops)
            {
                if(s.FloorNo == FloorNo)
                {
                    shopNames.Add(s.ShopName);
                }
            }
            return shopNames;
        }

        public bool FindShop(string shopname)
        {
            foreach(Shop s in shops)
            {                           
                if(s.ShopName == shopname)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            return false;
        }

    }
}
