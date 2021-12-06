using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class HourlyEmployee : Employee
    {
        private double wage;

        public double _wage
        {
            get 
            {
                return wage; 
            }
            set 
            {
                wage = value; 
               
            }
        }

        private double hours;

        public double _hours
        {
            get 
            {
                return hours; 
            }
            set
            {
                hours = value; 
            }
        }
        public double currentWage;
        public override double earning() 
        {
            if (hours<=40)
            {
                currentWage = wage * hours;
                Console.WriteLine(firstName+" isimli çalışanın şu anki maaşı:"+currentWage);
            }

            else if (hours>40)
            {
                currentWage = (40 * wage) + ((hours - 40) * wage * 1.5);
                Console.WriteLine(firstName + " isimli çalışanın şu anki maaşı:" + currentWage);
            }

            return currentWage;
        }



    }
}
