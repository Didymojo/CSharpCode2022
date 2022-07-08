using System;

namespace FlooringCost // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Enter width of room in meters (eg. 5.6m):");
            decimal width = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter length of room in meters (eg. 7.5m):");
            decimal length = decimal.Parse(Console.ReadLine());
  
            Console.WriteLine("Enter cost per m2:");
            decimal cost = decimal.Parse(Console.ReadLine());

            decimal costOfFlooring = width * length * cost;
           
            Console.WriteLine("Area of room is: " + width * length + "m2");
            Console.WriteLine("Cost of flooring is: $" + Math.Round(costOfFlooring,2));
            
            Console.WriteLine();

            //area of round house
            Console.WriteLine("Your house is round! Measure its diameter (the longest width across the room eg. 5.5m):");
            //assuming easier to measure the diameter and divide by 2 than find centre of room and measure the radius.
            double diameter = double.Parse(Console.ReadLine());
            double areaFloorRound = 3.14159 * (diameter / 2) * (diameter / 2);
            areaFloorRound = Math.Round(areaFloorRound, 2);

            //converts round floor area in m2 to square foot & multiplies that by $ per square foot
            double costOfFloorRound = (areaFloorRound * 10.764) * 4.3;
            Console.WriteLine("Area of the round room is: " + areaFloorRound + "m2");
            Console.WriteLine("Cost of the flooring in round room is: $" + Math.Round(costOfFloorRound,2));

        }
    }
}