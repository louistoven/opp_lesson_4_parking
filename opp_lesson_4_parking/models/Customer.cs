using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.Properties
{
    public class Customer
    {
        public int HoursParked { get; set; }
        public string Registration { get; set; }
        public Customer(int _hoursparked, string _registration)
        {
            Console.WriteLine("I am the customer");
            HoursParked = _hoursparked;
            Registration = _registration;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
