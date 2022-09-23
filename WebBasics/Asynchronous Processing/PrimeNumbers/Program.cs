using System.Diagnostics;

    
 Stopwatch sw = Stopwatch.StartNew();
//Task.Run(FindThePrimeNumber) ;
Thread[] threads = new Thread[4];
threads[0] = new Thread(() => FindThePrimeNumber(1, 2_500_000));
threads[1] = new Thread(() => FindThePrimeNumber(2_500_001, 5_000_000));
threads[2] = new Thread(() => FindThePrimeNumber(5_000_001, 7_500_000));
threads[3] = new Thread(() => FindThePrimeNumber(7_500_001, 10_000_000));

foreach (var thread in threads)
{
    thread.Start();
}

foreach (var thread in threads)
{
    thread.Join();
}

sw.Stop();
Console.WriteLine(sw.Elapsed);
Console.WriteLine(count);

while (true)
{
    
    var input = Console.ReadLine();
    Console.WriteLine(input.ToUpper());
}


static void FindThePrimeNumber(int start, int size)
{
    
    //int n = 10000000;
    int count = 0;
    for (int i = start; i < size; i++)
    {
        bool isPrime = true;
        for (int j = 2; j <= Math.Sqrt(i); j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }

        }
        if (isPrime)
        {
            count++;
        }

    }
   
    
    
}

 




