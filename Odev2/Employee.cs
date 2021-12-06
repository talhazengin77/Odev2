using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public abstract class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        private string SSN;
        public string ssn
        {
            get
            {
                return SSN;
            }

            set
            {
                SSN = value;
            }
        }

        public abstract double earning();
    }
}
