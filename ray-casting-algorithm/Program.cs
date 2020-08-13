using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json.Serialization;
using System.Windows;

namespace ray_casting_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
          

            List<Coordinate> points = new List<Coordinate>();

         

                var coordinates = JsonConvert.DeserializeObject<List<List<double>>>("[[39.83446060263141,30.641801895218638],[40.692906212913705,32.61934095771864],[40.374376614295976,32.77314955146865],[40.1892676809123,34.465044082718634],[40.54221399351232,34.88252455146864],[41.17613785979679,36.11299330146864],[39.91910706077841,37.07979017646864],[38.74170749540973,36.59639173896864],[38.896413632584746,34.55293470771864],[37.87607338812315,32.83906752021864],[37.35170548248422,32.88301283271865],[39.83446060263141,30.641801895218638]]");


                foreach (var coordinate in coordinates)
                {
                    var point = new Coordinate { X = coordinate[0], Y = coordinate[1] };
                    points.Add(point);
                }
                var data = RayCastingHelper.PointIsInIt(points, new Coordinate { X = 40.482323, Y = 33.283463 });

            string message = data % 2 != 0 ? "the point is inside the polygon" : "the point isn't inside the polygon";

            Console.WriteLine(message);
        }
    }

    
}
