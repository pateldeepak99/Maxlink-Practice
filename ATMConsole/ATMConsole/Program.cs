using System;

namespace ATMConsole
{
    class Program
    {
        static void Main()
        {
            const string format = "{0,4}"; //Formatting purpose 
            string noteid;
            int sum = 0,tc=0, amount=0;
            int[] note = { 2000, 500, 200, 100 };
            while (true)
            {
                try
                {
                    
                    Console.Write("Insert Withdraw amount: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("XXXXXXXXXXXX Please Enter Valid Input XXXXXXXXXXXX");
                }
                if (amount != 0 & amount%100==0) { break; } else { Console.Clear(); Console.WriteLine("XXXXXXXXXXXX Please Enter Valid Input XXXXXXXXXXXX"); }
            }
            foreach (var item in note)
            {
                int count = (int)(amount / item);
                tc += count;
                if ((amount / item) > 0)
                {
                    sum += count * item;
                    amount -= (count * item);
                    noteid = string.Format(format, item);
                    //Console.WriteLine(string.Format(format, item));
                    Console.WriteLine( noteid+"Rs X " + count + " Notes= " + count * item + " Rs");
                    amount = (amount <= 0) ? 0 : amount;
                }
                else {
                    noteid = string.Format(format, item);
                    Console.WriteLine(noteid + "Rs X " + count + " Notes= " + count * item + " Rs"); 
                    //Console.WriteLine(item + "Rs X " + count + " Notes= " + (count * item) + " Rs");
                }
            }
            Console.WriteLine("==============================");
            Console.WriteLine("Total    "+tc+" Notes= " +sum+"Rs");
            Console.ReadKey();
        }
    }
}
