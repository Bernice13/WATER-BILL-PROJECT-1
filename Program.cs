using System;
using System.Linq;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerID;
            string customerName;
            int Unit;
            double charges,
            surCharges = 0.0,
            amountCharges,
            netAmount = 0.0;


            Console.Write("Please input your Customer ID :");
            customerID = (Console.ReadLine());
            while ((String.IsNullOrEmpty(customerID)) || (customerID.All(char.IsDigit)) == false)
            {

                Console.WriteLine("please enter a valid ID Number");
                Console.Write("Input Customer ID :");
                customerID = (Console.ReadLine());

                foreach (char c in customerID)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("Your ID is in digit format only");
                        Console.WriteLine("please enter a valid ID Number");
                        Console.Write("Input Customer ID :");
                        customerID = (Console.ReadLine());
                        break;
                    }
                }
            }

            Console.WriteLine("Please enter your user name :");
            customerName = (Console.ReadLine());
            while ((String.IsNullOrEmpty(customerName)) || (customerName.All(char.IsLetter)) == false)
            {
                Console.WriteLine("please enter a user name");
                customerName = (Console.ReadLine());

                foreach (char c in customerName)
                {
                    if (char.IsDigit(c))
                    {
                        Console.WriteLine("Your name should be in letters only");
                        Console.WriteLine("please enter a valid user name");
                        Console.Write("Input Customer ID :");
                        customerName = (Console.ReadLine());
                        break;
                    }
                }
            }

            Console.Write("Input your unit : ");
            var UnitAsString = Console.ReadLine();

            while ((String.IsNullOrEmpty(customerName)) || !int.TryParse(UnitAsString, out Unit))
            {
                Console.WriteLine("Input your correct Unit");
                UnitAsString = Console.ReadLine();
            }

            if (Unit <= 199)
            {
                charges = 1.20;
            }

            else if ((Unit >= 200) && (Unit < 400))
            {
                charges = 1.50;
            }
            else if (Unit >= 400 && Unit < 600)
            {
                charges = 1.80;
            }
            else
            {
                charges = 2.00;
            }


            //To calculate the total unit/charge
            amountCharges = Unit * charges;
            //To determine surcharge and net amount
            if (amountCharges > 300.0)
            {
                surCharges = amountCharges * 15.0 / 100.0;
                netAmount = amountCharges + surCharges;

                if (netAmount < 100.0)
                {
                    netAmount = 100.0;
                    Console.WriteLine("Your minimum bill is: " + netAmount + "naira");

                }
            }



            //To display customers information and total bill
            Console.Write("\nYour total Water Bill is stated below \n");
            Console.Write("Customer IDNO                       :{0}\n", customerID);
            Console.Write("Customer Name                       :{0}\n", customerName);
            Console.Write("unit Consumed                       :{0}\n", Unit);
            Console.Write("Amount Charges @Naira. {0} per unit  :{1}.00\n", charges, amountCharges);
            Console.Write("Surchage Amount                     :{0}.00\n", surCharges);
            Console.Write("Net Amount Paid By the Customer     :{0}.00\n", netAmount);


        }
    }
}
