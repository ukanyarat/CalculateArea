using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalArea
{
    internal class SwitchCaseCalArea
    {
        static void Main(string[] args)
        {
            int selected;
            double area;
            Console.WriteLine("1 : Ractangle \n2 : Triangle \n3 : Circle");
            Console.Write("Please select shape to calculate area : ");
            selected = Convert.ToInt32(Console.ReadLine());
            switch (selected)
            {
                case 1:
                    int width;
                    int height;
                    Console.Write("Please enter width : ");
                    width = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter height : ");
                    height = Convert.ToInt32(Console.ReadLine());
                    area = width * height;
                    Console.WriteLine("Area = {0}", area);
                    break;
                case 2:
                    int basee;
                    Console.Write("Please enter width : ");
                    basee = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter height : ");
                    height = Convert.ToInt32(Console.ReadLine());
                    area = basee * height * 0.5;
                    Console.WriteLine("Area = {0}", area);
                    break;
                case 3:
                    int radius;
                    Console.Write("Please enter radius : ");
                    radius = Convert.ToInt32(Console.ReadLine());
                    area = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine("Area = {0}", area);
                    break;
                default:
                    Console.WriteLine("Select number must be 1-3");
                    break;
            }
        }
    }
}
