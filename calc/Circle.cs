using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    class Circle  
    {
        double CircleArea;

        public void CalculateArea(int CircleRadius)
        {
            Console.WriteLine("Please enter Circle radius in meters to Calculate Area");
            CircleArea = CircleRadius * Math.PI;
            Console.WriteLine("Your Circles square meters is : " + CircleArea);
        }

    }
}
