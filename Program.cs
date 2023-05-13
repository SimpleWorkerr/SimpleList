namespace SimpleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<Person> list = new MyList<Person>();

            list.PushBack(new Person() { Age = 1, Name = "A", Sername = "A" });
            list.PushBack(new Person() { Age = 2, Name = "B", Sername = "B" });
            list.PushBack(new Person() { Age = 3, Name = "C", Sername = "C" });
            list.PushBack(new Person() { Age = 4, Name = "D", Sername = "D" });
            list.PushBack(new Person() { Age = 5, Name = "E", Sername = "E" });

            list.DisplayInfo();

            list[3] = new Person() { Age = 44, Name = "DD", Sername = "DD" };

            Console.WriteLine();
            Console.WriteLine(list.PopFront());
            Console.WriteLine();
            list.DisplayInfo();
        }
    }
}