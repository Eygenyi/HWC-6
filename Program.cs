void PlusElements()
{
    Console.WriteLine("Input Massive Length:  ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0)
    {
        Console.WriteLine("Error");
    }
    else
    {
        double[] arr = new double[n];
        int colplus = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Input element  " + (i + 1));
            arr[i] = Convert.ToDouble(Console.ReadLine());
            if (arr[i] > 0)
            {
                colplus++;
            }
        }
        Console.WriteLine("Numbers of Plus elements is:  " + colplus);
    }
}
PlusElements();