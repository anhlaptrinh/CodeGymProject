namespace StopWatchOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();

            
            Random rand = new Random();
            int[] numbers = new int[100000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 1000000);
            }

            
            stopWatch.Start();

            
            SelectionSort(numbers);

            // Dừng đo thời gian
            stopWatch.Stop();

            
            Console.WriteLine("Time elapsed for Selection Sort: " + stopWatch.GetElapsedTime() + " milliseconds");
        }

        
        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}
