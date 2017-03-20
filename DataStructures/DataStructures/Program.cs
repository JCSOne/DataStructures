namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>(5);
            s.Push(4);
            s.Push(3);
            s.Push(2);
            var x = s.Pop();
            System.Console.ReadLine();
        }
    }
}
