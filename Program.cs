namespace assignment_1_opp
{
    enum WeekDays
    { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}//.
            #endregion
            #region Q2
                //Person[] people = new Person[3];

                //people[0] = new Person { Name = "Alice", Age = 30 };
                //people[1] = new Person { Name = "Bob", Age = 25 };
                //people[2] = new Person { Name = "Charlie", Age = 35 };

                //foreach (Person person in people)
                //{
                //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                //}
            #endregion
            #region Q3
            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March, April, May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June, July, August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September, October, November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December, January, February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
        #endregion

    }
}
}
