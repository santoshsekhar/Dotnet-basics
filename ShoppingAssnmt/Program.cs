using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAssnmt
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome :");
            ShoppingMall sm = new ShoppingMall();
            string flow = "y";
            do
            {
                //start:
                Console.WriteLine("-----------------------\n" + "Please choose from the menu :\n" +
                    "1:- To add one active Shop\n" +
                    "2:-To close one shop\n" +
                    "3:-To modify the information about shop\n" +
                    "4:-To get the all Shop names belong to a floor\n" +
                    "5:-Check the availability of one shop by shop name\n" +
                    "6:-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Please enter the Shop details");
                            Console.WriteLine("Enter Capital");
                            int capital = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter owner");
                            string owner = Console.ReadLine();
                            Console.WriteLine("Enter shop name");
                            string shopName = Console.ReadLine();
                            Console.WriteLine("Enter shop type like (Garments / Ornaments / Confectionery / Memento / Watch Shop) ");
                            string shopType = Console.ReadLine();
                            Console.WriteLine("Enter floor number");
                            int floorNumber = Convert.ToInt32(Console.ReadLine());

                            Shop s1 = new Shop(capital, owner, shopName, shopType, floorNumber);
                            sm.AddShop(s1);

                            Console.WriteLine("Shop record added!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Please enter the Shop Registration to close");
                            string reg = Console.ReadLine();
                            sm.CloseShop(reg);
                            Console.WriteLine("Shop closed");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please enter the Shop Registration to make changes");
                            string reg = Console.ReadLine();
                            Console.WriteLine("enter which details to be changed? : Name / Owner / ShopType");
                            string option = Console.ReadLine();
                            Console.WriteLine("enter new value ");
                            string newValue = Console.ReadLine();
                            sm.ModifyShop(reg, option, newValue);
                            Console.WriteLine("Shop details modified!");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter floor Number to check shops ");
                            int flNumber = Convert.ToInt32(Console.ReadLine());
                            List<string> shopsOnFloor = sm.GetShopNames(flNumber);
                            if (shopsOnFloor.Count == 0)
                            {
                                Console.WriteLine("No shops on floor!!!");
                            }
                            else
                            {
                                foreach (string s in shopsOnFloor)
                                {
                                    Console.WriteLine(s);
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter shop name to check availability");
                            string sName = Console.ReadLine();
                            if (sm.FindShop(sName))
                            {
                                Console.WriteLine("Open!!!");
                            }
                            else
                            {
                                Console.WriteLine("Close...");
                            }
                            break;
                        }
                    case 6:                       
                                flow = "n";
                                break;
                    default:    Console.WriteLine("Wrong option... Select from 1-6 only");
                                break;
                }
            }while (flow != "n");  
            
            Console.ReadKey();                       
        }
    }

}
