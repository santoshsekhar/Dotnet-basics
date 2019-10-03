using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Tasks
    {

        public void Square()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("enter area of square");
            double area = Convert.ToDouble(Console.ReadLine());
            double perimeter = Math.Sqrt(area) * 4;
            Console.WriteLine("perimeter is {0}",perimeter);
            Console.ReadKey();


        }

        public void HoursWorked()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter number of hours worked");
            double hours = Convert.ToDouble(Console.ReadLine());
            double gross = hours * 12;
            double tax = 0.15 * gross;
            double pay = gross - tax;
            Console.WriteLine("{0}", pay);
            Console.ReadKey();
        }
        public void Profit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter number of attendees");

            int persons = Convert.ToInt32(Console.ReadLine());
            double personcost = 0.5 * persons;

            Console.WriteLine((persons * 5) - (20 + personcost));
            Console.ReadKey();

        }
        public void Tiles()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter Length of Area");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Area");
            double breadth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length of square Tile");
            double side = Convert.ToDouble(Console.ReadLine());
            double tileCount = ((length * breadth) / (side * side));
            Console.WriteLine("Tiles required {0}", tileCount);
            Console.ReadKey();
        }

        public void Volumes()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            double side = Math.Pow(27,(1.0/3.0));

            double newCubeSide = side * 2;

            double diff = Math.Pow(newCubeSide, 3) - 27;

            Console.WriteLine(diff);
            Console.ReadKey();
        }

        public void Earnings()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            double brain = (240000 * 100) / 80;
            double chad = (300000 * 100) / 85;

            double Mich = (brain - 240000) + (chad - 300000);
            Console.WriteLine("Mich's income {0}", Mich);

            Console.ReadKey();
        }

        public void WorkDone()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            double work = (15 * 20) / (15 + 20);
            Console.WriteLine("work done together is {0}", work);

            Console.ReadKey();
        }

        public void Rocket()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Enter time in seconds");
            double time = Convert.ToDouble(Console.ReadLine());

            double speedSecond = 7900 * time;

            double height = 0.5 * speedSecond * Math.Pow(time, 2);
            Console.WriteLine("Height reached in meters {0}", height);

            Console.ReadKey();
        }
    }

}
