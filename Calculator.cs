using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string answer;
            int result = 0;
            
            Console.WriteLine("Welcome to Calculator ");
            Console.WriteLine("Please enter first number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a for addition s for subtraction m for multiplication d for divistion :");
            answer = Console.ReadLine();
            if (answer == "a")
            {
                result= num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                result = num1 / num2;
            }
            Console.WriteLine("The result is: " + result);
        }
    }
        
}