﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    class Circle  
    {
       
        double CircleArea;
        int CircleRadius;
       

        public void getRadius()
        {
            Console.WriteLine("Please enter Circle radius in meters to Calculate Area");
            CircleRadius = Convert.ToInt32(Console.ReadLine());
            CalculateArea();
            
        }
        public void CalculateArea()
        {

            CircleArea = CircleRadius  * Math.PI;
            Console.WriteLine("Your Circles square meters is : " + CircleArea);
        }

    }
}
