namespace Adddays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 to 7: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());

            string day = Day(dayNumber);
            Console.WriteLine(day);

            Console.Write("Input number to add to the day: ");
            int newday = Convert.ToInt16(Console.ReadLine());

            string finalDay = Newday(dayNumber, newday);
            Console.WriteLine(finalDay); 
        }
        public static string Day(int dayNumber)
        {
            string message = "";

            switch (dayNumber)
            {
                case 1:
                    message = "The day is MONDAY";
                    break;
                case 2:
                    message = "The day is TUESDAY";
                    break;
                case 3:
                    message = "The day is WEDNESDAY";
                    break;
                case 4:
                    message = "The day is THURSDAY";
                    break;
                case 5:
                    message = "The day is FRIDAY";
                    break;
                case 6:
                    message = "The day is SATURDAY";
                    break;
                case 7:
                    message = "The day is SUNDAY";
                    break;
                default:
                    message = "Invalid Input.";
                    break;
            }
            return message;
        }

        public static string Newday(int dayNumber, int newday)
        {
            int Newday = dayNumber + newday;
            string message = "";

            switch (Newday)
            {
                case 1:
                    message = "The day is MONDAY";
                    break;
                case 2:
                    message = "The day is TUESDAY";
                    break;
                case 3:
                    message = "The day is WEDNESDAY";
                    break;
                case 4:
                    message = "The day is THURSDAY";
                    break;
                case 5:
                    message = "The day is FRIDAY";
                    break;
                case 6:
                    message = "The day is SATURDAY";
                    break;
                case 7:
                    message = "The day is SUNDAY";
                    break;
                default:
                    message = "Invalid Input.";
                    break;
            }
            return message;
        }
    }
}
