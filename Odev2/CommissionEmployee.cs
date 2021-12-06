using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class CommissionEmployee:Employee
    {
        private double grossSales;
        public double _grossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                grossSales = value;
            }
        }

        private double commissionRate;

        public double _commissionRate
        {
            get 
            { 
                return commissionRate; 
            }
            set 
            {
                commissionRate = value; 
            }
        }


        public double latest;

        

        public override double earning() 
        {
            
            latest = commissionRate * grossSales;
            Console.Write("Sonuç:"+latest);
            return latest;
        }

    }
}
