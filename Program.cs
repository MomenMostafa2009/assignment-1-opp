namespace assignment_1_opp
{
    enum WeekDays
    { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }//.
            #endregion
            #region Q2
                Person[] people = new Person[3];

                people[0] = new Person { Name = "Alice", Age = 30 };
                people[1] = new Person { Name = "Bob", Age = 25 };
                people[2] = new Person { Name = "Charlie", Age = 35 };

                foreach (Person person in people)
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
        #endregion


    }
}
}
