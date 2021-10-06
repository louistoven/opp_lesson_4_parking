using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.Properties
{
    public class CarPark
    {
        public List<Customer> ListOfCustomers = new List<Customer>();
        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the Carpark");
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public void Calculate_charges()
        {
            foreach (Customer customer in ListOfCustomers)
            {
                int calculatecharge = carParkCharge.CalculateCharge(customer.HoursParked);
                Console.Write($"Calculating charge for customer : cost is {calculatecharge}");
            }
        }
    }
}
