using System;

namespace Lab3
{
    public class Figure
    {
        public string Name { get; }
        public Point[] pointMassive { get; set;}
        public double Perimeter { get; set; }
        public Figure(Point A, Point B, Point C)
        {
            pointMassive = new Point[3];
            pointMassive[0] = A;
            pointMassive[1] = B;
            pointMassive[2] = C;
            Name = "Трикутник";
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            pointMassive = new Point[4];
            pointMassive[0] = A;
            pointMassive[1] = B;
            pointMassive[2] = C;
            pointMassive[3] = D;
            Name = "Чотирикутник";
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            pointMassive = new Point[5];
            pointMassive[0] = A;
            pointMassive[1] = B;
            pointMassive[2] = C;
            pointMassive[3] = D;
            pointMassive[4] = E;
            Name = "П'ятикутник";
        }

        public double LengthSide(Point A, Point B)
        {

            return Math.Sqrt((Math.Pow(B.x - A.x, 2)) + Math.Pow(B.y - A.y, 2));
        }
        public double PerimeterLength()
        {
            for(int i = 0; i < pointMassive.Length - 1; i++)
            {
                Perimeter += LengthSide(pointMassive[i], pointMassive[i+1]);
            }
            Perimeter += LengthSide(pointMassive[0], pointMassive[pointMassive.Length-1]); // Цей рядок для обрахування сторони яка знаходиться між 
                                                                                           //першою та останньою точкою в масиві

            return Perimeter;
        }
        public void Out()
        {
            Console.WriteLine($"Назва фігури - {Name}");
            Console.WriteLine($"Периметр фігури: {Perimeter}");
        }
    }
}
