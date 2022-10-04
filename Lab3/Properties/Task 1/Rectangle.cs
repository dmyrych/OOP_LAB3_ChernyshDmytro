using System;
namespace Lab3
{
    public class Rectangle
    {
        double side1 { get; set; }
        double side2 { get; set; }

        double area;
        private double Area
        {
            //get { return area; }   
            get => area; //syntax sugar in syntax sugar??? I like sweets
        }
        double perimeter;
        private double Perimeter
        {
            get => perimeter;
        }

        public Rectangle(double height, double width)
        {
            side1 = height;
            side2 = width;
        }
        public void areaCalculator()
        {
            area = side1 * side2;
            Console.WriteLine($"Area of rectangle is {Area} light years squared");
        }
        public void perimeterCalculator()
        {
            perimeter = side1 * 2 + side2 * 2;
            Console.WriteLine($"Perimeter of rectangle is {Perimeter} light years");
        }
    }
}
