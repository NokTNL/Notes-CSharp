Console.WriteLine("Press any key to start the task");
Console.ReadKey(true);

// To allow cancellation of a Task, we create a new CancellationTokenSource.
CancellationTokenSource cts = new();

// The Token contained inside the CTS stores the info whether we have trigger a cancellation
// In the middle of a running Task, we should then check periodically if the token is cancelled
// !!!! The task won't just "magically cancel" itself abruptly when we call Token.Cancel, we have to decide what to do when we spot cancellations in the middle of a process
// e.g. the Task below runs a long task in another thread that never stops
var longTask = Task.Run(
    () =>
    {
        // Token.IsCancellationRequested is set to `true` when the token is cancelled
        while (cts.Token.IsCancellationRequested == false)
        {
            Console.WriteLine("Task is running, press any key to cancel it...");
            Task.Delay(1000).Wait();
        }
        // We can simply `return` here and the task will stop, BUT the status of the task will be `RanToCompletion`
        // The proper way to do it is:
        // 1. Throw an OperationCanceledException with e.g. Token.ThrowIfCancellationRequested()
        // 2. Pass the same token to the method that creates the Task (e.g. Task.Run here) so the Task is aware of the token
        // Doing this will make Task.Status to be `Cancelled`
        // See: https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/task-cancellation
        cts.Token.ThrowIfCancellationRequested();
    },
    cts.Token
);

// Between the cancellation is requested and the Task is actually cancelled is a small delay
// We can register something to do immediately after the token is cancelled while waiting
cts.Token.Register(() => Console.WriteLine("Task cancellation is requested..."));

// Wait for user to enter any key
Console.ReadKey(true);

// Call CancellationTokenSource.Cancel() to mark the token as cancelled.
cts.Cancel();

try
{
    // Still need to await the Task to make it run to completion (we haven't made use of the Task yet!)
    // awaiting a cancelled task will throw an OperationCanceledException
    await longTask;
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}
finally
{
    // A cancelled Task will have its status set to `Cancelled`.
    Console.WriteLine($"Task status: {longTask.Status}");
}

// When the token is no longer needed, we can call Dispose() to release the resources and make it unusable
cts.Dispose();











