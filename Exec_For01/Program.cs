internal class Program
{
    private static void Main(string[] args)
    {
        //倒三角形

        for (int i = 5; i > 0; i--)
        {
            string row = new string('*', i);
            Console.WriteLine(row);
        }
    }
}