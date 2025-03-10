﻿using System;
using Codecool.Geometry.Containers;

namespace Codecool.Geometry
{
    /// <summary>
    ///     This is the main class of your program which contains Main method
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     This is the entry point of your program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool isRunning = true;
            var shapeCollection = new ShapeCollection();

            while (isRunning)
            {
                Console.WriteLine("Please choose your option:");
                Console.WriteLine("1. Add new shape");
                Console.WriteLine("2. Print all shapes");
                Console.WriteLine("3. Largest perimeter");
                Console.WriteLine("4. Largest area");
                Console.WriteLine("5. Show formulas");
                Console.WriteLine("0. Exit");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        shapeCollection.AddShape();
                        break;
                    case 2:
                        shapeCollection.GetShapesTable();
                        break;
                    case 3:
                        shapeCollection.GetLargestShapeByPerimeter();
                        break;
                    case 4:
                        shapeCollection.GetLargestShapeByArea();
                        break;
                    case 5:
                        shapeCollection.GetFormulas();
                        break;
                    case 0:
                        isRunning = false;
                        break;
                }
                
            }
        }
    }
}
