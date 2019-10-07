using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTasks
{
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public string details { get; set; }

       /* public override bool Equals(object obj)
        {
            return obj is Project project &&
                   id == project.id;
        }
        */
        public override string ToString()
        {
            return string.Format("Project id: {0}\nProject Name: {1}\nDetails: {2}\n---------------------", id,name, details);
        }

        /* public Project(int id, string projectName, string details)
         {
             this.id = id;
             this.projectName = projectName;
             this.details = details;
         }
         */

       
         



    }



     

    
}
