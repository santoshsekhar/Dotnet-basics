using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTasks
{
    class Product
    {
        public int pId { get; set; }
        public string pName { get; set; }

        public double units { get; set; }
        public double price { get; set; }

        /* public override bool Equals(object obj)
         {
             return obj is Project project &&
                    id == project.id;
         }
         */
        public override string ToString()
        {
            return string.Format("Product Details:\nProduct id: {0}\nProduct Name: {1}\nProduct Units: {2}\nPrice:$: {3}\n---------------------", pId, pName, units, price);
        }
    }
}
