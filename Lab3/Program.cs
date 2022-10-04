using System;

namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int height, width;

            //Console.WriteLine("Enter rectangle height: ");
            //height = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter rectangle width:");
            //width = Int32.Parse(Console.ReadLine());

            //Rectangle rect = new Rectangle(height, width);
            //rect.areaCalculator();
            //rect.perimeterCalculator();
            //Console.WriteLine("End of Task 1");

            //Book StarshipTroopers = new Book();
            //StarshipTroopers.Show();
            //Console.WriteLine("End of Task 2");

            //Point A = new Point(1, 1);
            //Point B = new Point(1, 2);
            //Point C = new Point(2, 1);
            //Point D = new Point(2, 2);

            //Figure rectangle = new Figure(A, B, C, D);
            //rectangle.PerimeterLength();
            //rectangle.Out();

            Invoice invoice = new Invoice(1, "US Government", "Dunder Mifflin Inc.", 20);
            invoice.withPDV();
            invoice.noPDV();
        }
    }
}
