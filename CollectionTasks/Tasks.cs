using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//using System.Collections.Generic;

namespace CollectionTasks
{
    class Tasks
    {
        public void StudentMarks()
        {
            double[] marks = new double[5];
            double sum = 0.0; 
            double averag ;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter 5 subject marks one after another");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToDouble(Console.ReadLine());
                sum += marks[i]; 
            } 
            averag = sum / marks.Length;
            Console.WriteLine("Sum is {0}, Average is {1}", sum, averag);
            Console.ReadKey();
        }

        public void StudentNames()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("how many students?");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter names one after another(Duplicates not counted)");
            List<string> names = new List<string>();
            string s;
          for (int i = 0;i < count; i++)
            {
                start:
                s = Console.ReadLine();
                if (names.Contains(s))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("name already exists!!! enter another name");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    goto start;
                }
                else
                {
                    names.Add(s);
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("enter name to search");
            s = Console.ReadLine();
            if (names.Contains(s))
            {
                Console.WriteLine("Name exists");
            }
            else
            {
                Console.WriteLine("Name does not exist");
            }
            Console.ReadKey();
        }



        public void EvenOdd()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("how many numbers u want to enter?");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numbers one after another(Duplicates not counted)");
            List<double> numbers = new List<double>();           
            for (int i = 0; i < count; i++)
            {            
                    numbers.Add(Convert.ToDouble(Console.ReadLine()));
            }
            HashSet<double> numbers1 = new HashSet<double>(numbers);
            List<double> even = new List<double>();
            List<double> odd = new List<double>();
            foreach (double x in numbers1)
            {
                  if(x%2 == 0)
                  {
                    even.Add(x);  
                  }
                 else
                  {
                    odd.Add(x);
                  }
            }
           // var evenAndOdd = even.Zip(odd, (n, w) => new { Even = n, Odd = w });
            Console.WriteLine("lists are");
                foreach(var nw in even.Zip(odd, Tuple.Create))
            {
                Console.WriteLine(nw.Item1+"|"+ nw.Item2);
            }          
            Console.ReadKey();
        }

        public void NumberSearch()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("how many numbers u want to enter?");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numbers one after another(Duplicates not counted)");
            ArrayList numbers2 = new ArrayList();
            for(int i =0;i<count;i++)
            {
                numbers2.Add(Convert.ToDouble(Console.ReadLine()));
            }
            Console.WriteLine("Displaying list");
            foreach(double x in numbers2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("enter number to search");
            double d = Convert.ToDouble(Console.ReadLine());
            if (numbers2.Contains(d))
            {
                int a = numbers2.IndexOf(d);
                Console.WriteLine("NUmber found at index {0}", a);
            }
            else
            {
                Console.WriteLine("NUmber does not exist");
            }
            Console.ReadKey();
        }

        public void NamesFiddle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("how many names u want to enter?");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter names one after another");
            List<string> names1 = new List<string>();
            for (int i = 0; i < count; i++)
            {
                names1.Add(Console.ReadLine());
            }
            Console.WriteLine("Displaying names");
            foreach (string s in names1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Enter name to remove");
            string rem = Console.ReadLine();
            lb:
            if(names1.Contains(rem))
            {
                names1.Remove(rem);
            }
            else
            {
                Console.WriteLine("name does not exist, try name from list above");
                goto lb;
            }
            Console.WriteLine("Updated List");
            foreach (string s in names1)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }


        public void NumberFiddle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("how many numbers u want to enter?");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numbers one after another");
            List<int> numbers4 = new List<int>();
            for (int i = 0; i < count; i++)
            {
                numbers4.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Displaying numbers");
            foreach (int s in numbers4)
            {
                Console.WriteLine(s);
            }
            lb2:
            Console.WriteLine("Enter number to remove");
            int rem = Convert.ToInt32(Console.ReadLine());
        
            if (numbers4.Contains(rem))
            {
                numbers4.Remove(rem);
            }
            else
            {
                Console.WriteLine("numbers does not exist, try number from list above");
                goto lb2;
            }
            int maxValue = numbers4.Max(); 
            Console.WriteLine("largest value in List is {0}", maxValue);           
            Console.ReadKey();
        }

        public void ProjectData()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("How many project records do u want to enter?");
            int count = Convert.ToInt32(Console.ReadLine());
            List<Project> pList = new List<Project>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter details of project {0} Id, Name, Details in order",i+1);
                int projectID = Convert.ToInt32(Console.ReadLine());
                string projectName = Console.ReadLine();
                string projectDetails = Console.ReadLine();
                pList.Add(new Project() { id = projectID, name = projectName, details = projectDetails });

            }
            foreach(var x in pList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Want to Change a project name?? (y/n)");
            string choice = Console.ReadLine();
            if (choice == "Y" || choice == "y")
            {      
                Console.WriteLine("Enter Project Id to change the name");
                int id_1 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter new name for the project");
                string newName = Console.ReadLine();
                foreach(Project p in pList)
                {
                    if(p.id == id_1)
                    {
                        p.name = newName;
                    }
                    else
                    {
                        Console.WriteLine("Project Id does not exist try Project id from list above");                        
                    }

                }

            }
            Console.WriteLine("Want to Delete a project?? (y/n)");
            string choiceDelete = Console.ReadLine();
            if (choiceDelete == "Y" || choiceDelete == "y")
            {
                Console.WriteLine("Enter Project Id to delete");
                int id_2 = Convert.ToInt32(Console.ReadLine());                
                for(int i = 0; i < pList.Count; i++)
                    {
                        if (pList[i].id == id_2)
                        {
                            pList.Remove(pList[i]);
                        }
                        else
                        {
                            Console.WriteLine("project id does not exist try project id from list above");
                        }
                    }
            }
            foreach (var x in pList)
            {
                Console.WriteLine(x);
            }           
            Console.ReadKey();
        }

        public void EmployeeData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How many employee records do u want to enter?");
            int count = Convert.ToInt32(Console.ReadLine());
            List<Employee> eList = new List<Employee>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter details of employee {0} Id, Name, Date of joining and Salary in order", i + 1);
                int empID = Convert.ToInt32(Console.ReadLine());
                string empName = Console.ReadLine();
                string empDOJ = Console.ReadLine();
                double salary = Convert.ToDouble(Console.ReadLine());
                eList.Add(new Employee() { eId = empID, eName = empName, edoj = empDOJ, eSalary= salary });

            }
            foreach (var x in eList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Want to Change a employee salary?? (y/n)");
            string choice = Console.ReadLine();
            if (choice == "Y" || choice == "y")
            {
                Console.WriteLine("Enter employee Id to change the salary");
                int id_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter new salary for the employee");
                double newSalary = Convert.ToDouble(Console.ReadLine());
                foreach (Employee p in eList)
                {
                    if (p.eId == id_1)
                    {
                        p.eSalary = newSalary; 
                    }
                    else
                    {
                        Console.WriteLine("Employee Id does not exist try Project id from list above");
                    }

                }

            }
            Console.WriteLine("Want to Delete an Employee?? (y/n)");
            string choiceDelete = Console.ReadLine();
            if (choiceDelete == "Y" || choiceDelete == "y")
            {
                Console.WriteLine("Enter employee Id to delete");
                int id_2 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < eList.Count; i++)
                {
                    if (eList[i].eId == id_2)
                    {
                        eList.Remove(eList[i]);
                    }
                    else
                    {
                        Console.WriteLine("employee id does not exist try employee id from list above");
                    }
                }
            }
            foreach (var x in eList)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }

        public void Product()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("How many products records do u want to enter?");
            int count = Convert.ToInt32(Console.ReadLine());
            List<Product> proList = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter details of products {0} Id, Name, UNitsOfStock and price in order", i + 1);
                int proID = Convert.ToInt32(Console.ReadLine());
                string proName = Console.ReadLine();
                double proUnits = Convert.ToDouble(Console.ReadLine());
                double proPrice = Convert.ToDouble(Console.ReadLine());
                proList.Add(new Product() { pId = proID, pName = proName, units = proUnits, price = proPrice });

            }
            foreach (var x in proList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Want to Change a products unitsStock and Price?? (y/n)");
            string choice = Console.ReadLine();
            if (choice == "Y" || choice == "y")
            {
                Console.WriteLine("Enter products Id to change the salary");
                int id_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter new units for the products");
                double newUnits = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter new Price");
                double newPrice = Convert.ToDouble(Console.ReadLine());

                foreach (Product pro in proList)
                {
                    if (pro.pId == id_1)
                    {
                        pro.units = newUnits;
                        pro.price = newPrice;
                    }
                    else
                    {
                        Console.WriteLine("products Id does not exist try products from list above");
                    }

                }

            }
            Console.WriteLine("Want to Delete a producs?? (y/n)");
            string choiceDelete = Console.ReadLine();
            if (choiceDelete == "Y" || choiceDelete == "y")
            {
                Console.WriteLine("Enter products Id to delete");
                int id_2 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < proList.Count; i++)
                {
                    if (proList[i].pId == id_2)
                    {
                        proList.Remove(proList[i]);
                    }
                    else
                    {
                        Console.WriteLine("products id does not exist try products id from list above");
                    }
                }
            }
            foreach (var x in proList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Search products above what value?");
            double limit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Products above price :{0} are: ",limit);
            foreach (var x in proList)
            {
                if(x.price>limit)
                
                Console.WriteLine(x);
            }


            Console.ReadKey();
            
        }








    }

    


}

    

