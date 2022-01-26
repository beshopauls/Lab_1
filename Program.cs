using System;


namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int m = 0, n = 0;
            bool success;
            Console.WriteLine("\t\tTask 1");
            do{
                Console.Write(" Please enter value m : ");
                success = int.TryParse(Console.ReadLine(), out m);
                if (!success) Console.WriteLine(" Please try again");
            } while (!success);
            do{
                Console.Write(" Please enter value n : ");
                success = int.TryParse(Console.ReadLine(), out n);
                if (!success) Console.WriteLine(" Please try again");
            } while (!success);
            //n+++m
            //m-- >n
            //n-- >m
            Console.WriteLine("\t\tTask 1.1");
            Console.WriteLine("\t m = {0} , n = {1}", m, n);
            //Task 1.1
            Console.WriteLine("Pre => n+++m = {0}", n++ + m);
            //Task 1.2
            Console.WriteLine("\t\tTask 1.2");
            Console.WriteLine("Check m-- > n");
            Console.WriteLine("Result for first operate is {0}", m-- > n);
            //Task 1.3
            Console.WriteLine("\t\tTask 1.3");
            Console.WriteLine("Check n-- > m");
            Console.WriteLine("Result for second operate is {0}", n-- > m);
            //Task 1.4
            //sin(x)+x3+(1/(x2+1))
            double x;
            Console.WriteLine("\t\tTask 1.4");
            Console.Write("Please Enter value X : ");
            do {
                success = double.TryParse(Console.ReadLine(), out x);
                if (!success) Console.WriteLine(" Please try agian"); 
            }while (!success);
            Console.WriteLine("Result for sin(x)+x3+(1/(x2+1)) where x =  {0} is  {1}", x, Math.Asin(x) + Math.Pow(x, 3) + (1 / (Math.Pow(x, 2) + 1)));
            //Task 2
            Console.WriteLine("\t\tTask 2");
            float x1, y1;
            Console.WriteLine("Enter a value you need checked ");
            Console.Write("Enter a value X ");
            do
            {
                success = float.TryParse(Console.ReadLine(), out x1);
                if (!success) Console.WriteLine(" Please try agian");
            } while (!success);
            Console.Write("Enter a value Y ");
            do
            {
                success = float.TryParse(Console.ReadLine(), out y1);
                if (!success) Console.WriteLine(" Please try agian");
            } while (!success);
            bool exp = (x1 >= 0) && (x1 <= 5) && (y1 >= 0) && (y1 <= 2);
            if (exp)
                Console.WriteLine("The point ( {0} , {1} ) belong to the shaded area", x1, y1);
            else
                Console.WriteLine("The point ( {0} , {1} ) not belong to the shaded area", x1, y1);
            //Task 3
            float fa = 1000f, fb = 0.0001f, FR;
            double da = 1000, db = 0.0001, DR;
            Console.WriteLine("\t\t Task 3");

            FR = ((float)Math.Pow(fa + fb, 2)) - ((float)(Math.Pow(fa, 2) + (2 * fa * fb))) / (float)Math.Pow(fb, 2);
            Console.WriteLine("The Result for expretion by datatype float is {0} ", FR);

            DR = ((double)Math.Pow((da + db), 2) - ((double)Math.Pow(da, 2) + (2 * da * db))) / (double)(Math.Pow(db, 2));
            Console.WriteLine("The Result for expretion by datatype double is {0} ", DR);
        }
    }
}
