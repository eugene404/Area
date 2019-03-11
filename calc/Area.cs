using System;

namespace CalculateArea
{
    class Area 
    {
        string shape;

        public void ChooseShape()
        {

            Console.WriteLine("Please choose what shape you want to Calculate");
            Console.WriteLine("Circle", " Rectangle", "Square");
            shape = Console.ReadLine();

            if (shape == "Circle" || shape == "circle")
            {
                Circle inst = new Circle();
                inst.getRadius();

            }

        }
        static void Main(string[] args)
        {
            Area inst = new Area();

            inst.ChooseShape();

            Console.ReadLine();
            

            
        }
    }
}
