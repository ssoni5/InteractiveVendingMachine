using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare VendingMachine reference variable.
            VendingMachine vm;

            // Instantiate VendingMachine object.
            vm = new VendingMachine();

            // Test ToString method of vm.
            Console.WriteLine(vm.ToString());


            // Try to buy 6 candy bars.  vm has only five candy 
            // bars, so the 6th time will not be successful.
            // Each candy bar requires 3 quarters.

            // AlmoundJoy
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy(VendingMachine.CandyBar.AlmoundJoy));
            }
            Console.WriteLine(vm.ToString());

            // Butterfingers
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy(VendingMachine.CandyBar.ButterFinger));
            }
            Console.WriteLine(vm.ToString());

            // Twix
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy(VendingMachine.CandyBar.Twix));
            }
            Console.WriteLine(vm.ToString());

            // Snickers
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy(VendingMachine.CandyBar.Snickers));
            }
            Console.WriteLine(vm.ToString());
            Console.ReadLine();
        }
    }
}
