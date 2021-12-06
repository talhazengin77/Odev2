using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region SalariedEmployee

            SalariedEmployee s1 = new SalariedEmployee();
            Console.Write("Salaried Employee'nin ismini giriniz:");
            s1.firstName = Console.ReadLine();
            Console.Write("Salaried Employee'nin soyismini giriniz:");
            s1.lastName = Console.ReadLine();
            Console.Write(s1.firstName+" "+s1.lastName+" adli çalisanin sosyal sigorta numarasini giriniz:");
            s1.ssn = Console.ReadLine();
            Console.Write(s1.firstName+" isimli çalışanın haftalık maaşını giriniz:");
            s1._weeklySalary = double.Parse(Console.ReadLine());
            s1.earning();

            #endregion

            #region HourlyEmployee

            Console.WriteLine("--------------------------------------------");
            HourlyEmployee h1 = new HourlyEmployee();
            Console.Write("Hourly Employee'nin ismini giriniz:");
            h1.firstName = Console.ReadLine();
            Console.Write("Hourly Employee'nin soyismini giriniz:");
            h1.lastName = Console.ReadLine();
            Console.Write(h1.firstName + " " + h1.lastName + " adli çalisanin sosyal sigorta numarasini giriniz:");
            h1.ssn = Console.ReadLine();
            Console.Write(h1.firstName+" "+h1.lastName+" isimli çalışanın kaç saat çalıştığını giriniz:" );
            h1._hours=double.Parse(Console.ReadLine());
            Console.Write(h1.firstName + " " + h1.lastName + " isimli çalışanın saatlik maaşını giriniz:");
            h1._wage= double.Parse(Console.ReadLine());
            h1.earning();
            Console.WriteLine("--------------------------------------------");

            #endregion
            
            #region CommissionEmployee

            CommissionEmployee c1 = new CommissionEmployee();
            Console.Write("Commission Employee'nin ismini giriniz:");
            c1.firstName = Console.ReadLine();
            Console.Write("Commission Employee'nin soyismini giriniz:");
            c1.lastName = Console.ReadLine();
            Console.Write(c1.firstName + " adli çalisanin sosyal sigorta numarasini giriniz:");
            c1.ssn = Console.ReadLine();
            Console.Write(c1.firstName+" "+c1.lastName+" isimli çalışanın brüt satış miktarını giriniz:");
            c1._grossSales = Convert.ToDouble(Console.ReadLine());
            Console.Write("Komisyon oranını giriniz:");
            c1._commissionRate = Convert.ToDouble(Console.ReadLine());
            c1.earning();

            #endregion

            #region BasePlus-CommissionEmployee

            Console.WriteLine("--------------------------------------------");
            BasedPlusCommissionEmployee b1 = new BasedPlusCommissionEmployee();
            b1.firstName = c1.firstName;
            b1.lastName = c1.lastName;
            b1.ssn = c1.ssn;
            Console.Write("\nBase salary giriniz:");
            b1._baseSalary = double.Parse(Console.ReadLine());
            b1.earning();

            #endregion

            Console.ReadLine();
        }
    }
}
