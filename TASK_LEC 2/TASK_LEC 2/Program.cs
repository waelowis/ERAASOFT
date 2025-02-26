namespace TASK_LEC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---WAEL MOHAMED BADOU OWIS -----");
            Console.WriteLine("WELCOME TO Islam's Carpet Cleaning Service");
            Console.WriteLine("List Price ------  ");
            int SmallRoom = 25;
            int LargeRoom = 35;
            decimal taxRate = 0.06m;
            Console.WriteLine($"  Charges: \n   1 - ${SmallRoom} per small room \n   2 - ${LargeRoom} per large room");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Plaese Enter The Quantity Of SmallRoom ?");
            decimal QSmallRoom =  Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Plaese Enter The Quantity Of LargeRoom ?");
            decimal QLargeRoom = Convert.ToDecimal(Console.ReadLine());
            decimal totalSmallRoom = SmallRoom * QSmallRoom;
            decimal totalLargeRoom = LargeRoom * QLargeRoom;
            Console.WriteLine(" ---- Total Your Order -------");
            Console.WriteLine($"Price per small room: {QSmallRoom} * {SmallRoom}  =  $ {totalSmallRoom}");
            Console.WriteLine($"Price per large room: {QLargeRoom} * {LargeRoom}  =  $ {totalLargeRoom}");
            decimal totalOrder = totalLargeRoom + totalSmallRoom;
            Console.WriteLine("===============================");
            Console.WriteLine($"Total Price: $ {totalOrder}");
            decimal TotalTax = totalOrder * taxRate;
            Console.WriteLine($"Add The Task  $ {TotalTax}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate : ${totalOrder + TotalTax}");
            Console.WriteLine("This estimate is valid for 30 days");
            Console.WriteLine("Thank you");




        }
    }
}
