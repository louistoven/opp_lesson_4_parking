using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.Properties
{
    public class CarParkCharge
    {
        public int MinimumFee { get; set; }
        public int MinimumHours { get; set; }
        public CarParkCharge(int _minimumfee = 2, int _minimumhours = 3)
        {
            Console.WriteLine("I am the carparkcharge()");
            MinimumFee = _minimumfee;
            MinimumHours = _minimumhours;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public int CalculateCharge(int hoursparked)
        {
            int minimumFee = 2;
            int minimumHours = 3;
            int calculatedFee = hoursparked < minimumHours ? minimumFee : hoursparked * minimumFee;
            return calculatedFee;
        }
    }
}
