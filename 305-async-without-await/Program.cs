// Not all libraries come with async methods, but you can turn synchronous operations into asynchoronous ones without it.
// The first thing is the static Task.Run method.
// It accepts a method (can be a lambda) and opens a new thread to run that method, so it is not blocking the new thread. 

using _305_async_without_await;

RunMode runMode = RunMode.TaskRun_ContinueWith;

if (runMode == RunMode.TaskRunOnly)
{
    Task.Run(LongRunningProcess.Wait);
    Console.WriteLine("I am logged before the task is done waiting!"); // The above is non blocking, so this line will log before the task is finished. This is probably not what we want.
}

// Therefore, we want to do some "continuation" work after the task is completed.
// We could use `await` for that; but we can also use static Task.ContinueWith to tell what you want to run after the task is finished
// The method you pass in accepts the completedTask as a param
if (runMode == RunMode.TaskRun_ContinueWith)
{
    Task.Run(LongRunningProcess.Wait)
        .ContinueWith((completedTask) => {
            // This is how to get the result without using await
            // Calling Task.Result here is fine since we are 100% sure that the task is completed
            // Otherwise, calling Task.Result will make the process wait synchronously
            var result = completedTask.Result;
            Console.WriteLine($"Task completed with status {result}"); 
            return result; // If you want to chain ContinueWith, return the Task result so the next ContinueWith will get a Task with the same result
        })
        .ContinueWith((completedTask) => {
            var result = completedTask.Result; // Same Result
        });
    // !!! Note:
    // - ContinueWith still runs even if the the Task before it is FAULTED, so there could be silent error! (unless you await it). The completed task just contains the corresponsing Status and Exception.
    //   - !!! Excpetion is when you pass in a second parameter to ContinueWith.
    //      - e.g. TaskContinuationOptions.OnlyOnRanToCompletion will make it run only on completion
    //      - e.g. TaskContinuationOptions.OnlyOnFaulted will make it run only on fault (so basically acting as a catch block)
    Task.Delay(15000).Wait(); // Adding this delay so the programme does not exit before the task is done.
}
enum RunMode
{
    TaskRunOnly,
    TaskRun_ContinueWith
}

