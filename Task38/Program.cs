void Main()
{
    int[] n = { 3, 7, -22, 2, 78 };
    int Max = 0;
    int Min = 0;
    int i = 0;
    while (n.Length > i)
    {
        if (Max < n[i])
        {
            Max = n[i];
        }
        if (Min > n[i])
        {
            Min = n[i];
        }
        i++;
    }
    Console.WriteLine(Max - Min);
}
Main();
