class HelloWorld
{
    static void Main()
    {
        //Console.WriteLine("*");
        int n = 33;
        for(int i = 1; i<=n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }
}