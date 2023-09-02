using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Acitivity__3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int unit_charge;
            Console.WriteLine("Enter the unit charge");
            unit_charge = Convert.ToInt32(Console.ReadLine());

            int units;
            Console.WriteLine("enter the number of Units used : ");
            units =Convert.ToInt32(Console.ReadLine());

            int final_amount;
            final_amount = unit_charge * units;
            Console.WriteLine("Your Amount will be  : " + final_amount);

            int tax_rate;
            Console.WriteLine("Enter the Tax rate : ");
            tax_rate = Convert.ToInt32(Console.ReadLine());


            int final_tax_rate;
            final_tax_rate = final_amount * tax_rate / 100;

            Console.WriteLine("Your Tax amount : "+final_tax_rate);
            int final_bill_amount;
            final_bill_amount = final_amount + final_tax_rate;
            Console.WriteLine("Final Bill Amount : " + final_bill_amount); ;    



            Console.ReadKey();


















        }
    }
}
