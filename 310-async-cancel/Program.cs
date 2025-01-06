Console.WriteLine("Press any key to start the task");
Console.ReadKey(true);

// To allow cancellation of a Task, we create a new CancellationTokenSource.
CancellationTokenSource cts = new();
// The Token contained inside it should then be passed to the method that creates the Task (e.g. HttpClient.GetAsync, Task.Run ....)
var longTask = Task.Run(async () =>
{
    while (cts.Token.IsCancellationRequested == false) // When a Task is cancelled, CancellationTokenSource.Token.IsCancellationRequested will be set to `true`.
    {
        Console.WriteLine("Task is running, press any key to cancel it...");
        await Task.Delay(1000, cts.Token);
    }
}, cts.Token); // Passing cts.Token everywhere to make sure that they are cancelled cleanly

Console.ReadKey(true);

// When we want to cancel the task, we call CancellationTokenSource.Cancel(). This will cancel the Task.
cts.Cancel();
// We then call Dispose() to release the resources and make it unusable
cts.Dispose();
// !!!! It should then also be assigned null to allow garbage collection, but since we are not reusing this process here, we can ignore it
Console.WriteLine("Task is cancelled");

// - `await`-ing a cancelled Task will throw a TaskCancelledException.
await longTask; // <-- This line throws an error









