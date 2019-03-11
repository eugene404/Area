using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    class Circle  
    {
        double circl;
        double CircleArea;
        double CircleRadius;

        public int getRadius()
        {
            Console.WriteLine("Please enter Circle radius in meters to Calculate Area");
            int rad = Convert.ToInt32(Console.ReadLine());
            return rad;
           
        }
        public void CalculateArea()
        {

            CircleRadius = getRadius();
            CircleArea = CircleRadius * Math.PI;
            Console.WriteLine("Your Circles square meters is : " + CircleArea);
        }

    }
}
