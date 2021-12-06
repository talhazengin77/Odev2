using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class SalariedEmployee : Employee
    {

        private double weeklySalary;
        public double _weeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                weeklySalary = value;
            }
        }

        public override double earning() 
        {

            Console.WriteLine(firstName+" "+lastName+" isimli calisanin haftalik kazanci:"+weeklySalary+"\nToplam aylık kazancı:"+(4*weeklySalary));
            return (4*weeklySalary);
        }

    }
}
