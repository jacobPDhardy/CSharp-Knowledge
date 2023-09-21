using System.Diagnostics;

int[] generateNumbers(int length) {

    int[] numbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        numbers[i] = new Random().Next(0, 100000);
    }
    return numbers;
}

void outputNumbers(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}

int[] bSort(int[] numbers)
{
    while (true)
    {
        int swaps = 0;
        for (int i=0;i<numbers.Length-1;i++)
        {
                if (numbers[i] > numbers[i+1])
                {
                int temp = numbers[i];
                numbers[i] = numbers[i+1];
                numbers[i + 1] = temp;
                swaps++;
                }
        }
        if (swaps == 0)
            {
                break;
            }
        
    }
    return numbers;
}

int[] numbers = generateNumbers(10000);

var timer = new Stopwatch();
timer.Start();
outputNumbers(bSort(generateNumbers(10000)));
timer.Stop();
Console.WriteLine(timer.Elapsed.ToString());