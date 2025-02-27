namespace assignment_1_opp
{
    enum WeekDays
    { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion



        }
    }
}
