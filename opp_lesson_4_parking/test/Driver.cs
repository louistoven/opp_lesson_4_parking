using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.Properties
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }
        public void CreateObjects()
        {
            CarPark carpark = new CarPark();
            carpark.ListOfCustomers.Add(new Customer(1,"a"));
            carpark.ListOfCustomers.Add(new Customer(2,"b"));
            carpark.ListOfCustomers.Add(new Customer(3, "c"));
            carpark.ListOfCustomers.Add(new Customer(4,"d"));
            carpark.ListOfCustomers.Add(new Customer(5,"e"));
            carpark.ListOfCustomers.Add(new Customer(6,"f"));
            carpark.Calculate_charges();

            Customer customer = new Customer(7,"g");
            CarParkCharge carparkcharge = new CarParkCharge();

            Console.WriteLine(carpark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carparkcharge.ToString());
        }
    }
}
