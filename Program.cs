namespace Home_Sales2;

class Program
{
    static void Main(string[] args)
    {
        int max = 0;
        //int sumsale = 0;
        string maxsalesperson = "";
        string[] allowed_initials = { "F", "D", "E", "f", "d", "e" };
        string[] initials = { "F", "D", "E" };
        int[] accumulated_sales_values = { 0 };

        for (; ; )
        {
            Console.Write("salesperson: ");
            string salesperson = Console.ReadLine();
            if (salesperson == "z" || salesperson == "Z")
            {
                break;
            }
            bool is_it_allowed = false;
            for (int i = 0; i < 6; i++)
            {
                if (salesperson == allowed_initials[i])
                {
                    is_it_allowed = true;
                }
            }

            if (is_it_allowed == false)
            {
                Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
                continue;
            }
            Console.Write("sale: ");
            int sale = Convert.ToInt32(Console.ReadLine());
            //sumsale = sumsale + sale;
            accumulated_sales_values[0] = accumulated_sales_values[0] + sale;
            if (sale > max)
            {
                max = sale;
                maxsalesperson = salesperson;
            }
        }

        Console.WriteLine("Grand Total: " + accumulated_sales_values[0].ToString("C0"));
        Console.WriteLine("Highest Sale: " + maxsalesperson);
    }
}
