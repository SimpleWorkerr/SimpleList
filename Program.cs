namespace SimpleList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<Person> list = new MyList<Person>();

            list.PushBack(new Person() { Age = 1, Name = "A", Sername = "B" });
            list.PushBack(new Person() { Age = 12, Name = "B", Sername = "B" });
            list.PushBack(new Person() { Age = 123, Name = "C", Sername = "B" });
            list.PushBack(new Person() { Age = 1234, Name = "D", Sername = "D" });

            Console.WriteLine("Display Info");
            list.DisplayInfo();
            Console.WriteLine("~Display Info");

            Console.WriteLine(list.PopFront());
            Console.WriteLine(list.PopFront());
            Console.WriteLine(list.PopFront());

            Console.WriteLine("Display Info");
            list.DisplayInfo();
            Console.WriteLine("~Display Info");
        }
    }
}