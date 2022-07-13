void Main()
{
    Random rnd = new Random();
    int[] myArray = FillArray(5);

    int[] FillArray(int count)
    {
        int[] arr = new int[count];
        for (int x = 0; x < arr.Length; x++)
        {
            arr[x] = rnd.Next(99, 1000);
            Console.Write($"{arr[x]} ");
        }
        return arr;
    }

    void GetCountOfEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; array.Length > i; i++)
        {
            if (i % 2 != 0)
            {
                count = count + array[i];
            }
        }
        Console.WriteLine($"\nСумма {count}");
    }
    GetCountOfEvenNumbers(myArray);
}
Main();