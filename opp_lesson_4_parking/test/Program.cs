using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.Properties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Park Charge Solution");
            Driver driver = new Driver();
            driver.CreateObjects();
            Console.ReadKey();
        }
    }
}
