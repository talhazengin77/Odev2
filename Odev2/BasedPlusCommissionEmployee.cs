using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class BasedPlusCommissionEmployee:CommissionEmployee 
    {
        private double baseSalary;

        public double _baseSalary
        {
            get 
            { 
                return baseSalary; 
            }
            set 
            { 
                baseSalary = value; 
            }
        }

        public double newsalary;
        public double final;
        
        public double commission()
        {
             final = (_commissionRate * _grossSales) / 100;
            return final;
        }
        public override double earning() 
        {
            Console.WriteLine("Comission:"+_commissionRate);
            Console.WriteLine("Gross Sales:"+_grossSales);
            
            newsalary = final + baseSalary;
            Console.WriteLine("Total Salary:"+newsalary);
            return newsalary;
        }
    }
}
