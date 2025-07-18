namespace Assemente
{
    internal class Program
    {

        #region Q-1
        //     enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Days of the week:");
        //    foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        //    {
        //        Console.WriteLine(day);
        //    }
        //}
        #endregion
        #region Q-2
        enum Season { Spring, Summer, Autumn, Winter }

        static void Main(string[] args)
        {

            Console.Write("Enter season name (Spring/Summer/Autumn/Winter): ");
            string input = Console.ReadLine();

            Season selectedSeason;
            if (Enum.TryParse(input, true, out selectedSeason))
            {
                switch (selectedSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered.");
            }
        }
        #endregion
    }
}
