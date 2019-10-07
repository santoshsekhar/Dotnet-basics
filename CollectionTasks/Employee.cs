using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTasks
{
    public class Employee
    {
        public int eId { get; set; }
        public string eName { get; set; }

        public string edoj { get; set; }
        public double eSalary { get; set; }

        /* public override bool Equals(object obj)
         {
             return obj is Project project &&
                    id == project.id;
         }
         */
        public override string ToString()
        {
            return string.Format("Employee Details:\nEmployee id: {0}\nEmployee Name: {1}\nEmployee DOJ: {2}\nSalary:$: {3}\n---------------------", eId, eName, edoj, eSalary);
        }
    }
}
