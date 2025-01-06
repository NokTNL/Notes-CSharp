namespace _305_async_without_await;

internal class LongRunningProcess
{
    public static int Wait()
    {
        Console.WriteLine("Task started ...");
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"Task {i} / 10 done ...");
            Task.Delay(1000).Wait();
        }
        Console.WriteLine("Done.");
        return 0;
    }
}