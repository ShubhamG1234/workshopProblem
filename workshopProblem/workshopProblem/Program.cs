


//leap year problem
namespace workshopProblem
{
    class LeapYear
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year: ");
            int checkingYear;

            checkingYear = Convert.ToInt32(Console.ReadLine());


            if ((checkingYear % 4) == 0)
                Console.WriteLine("This is a Leap Year");

            else
            {
                Console.WriteLine("This is not a Leap Year");
            }



        }
    }
}