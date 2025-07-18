namespace Assemente
{
    internal class Program
    {
        
            #region Q-1
             enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        static void Main(string[] args)
        {
            Console.WriteLine("Days of the week:");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
        }
        #endregion
    }
    }
