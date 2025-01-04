using _300_async_await_basic;

RunType runType = RunType.AsyncWhenAny;

// By default, all operations in C# are SYNCHRONOUS (or "blocking")
// It means when a thread is waiting for something to finish running in the program, it is stuck and cannot process anything else.

if (runType == RunType.Sync)
{
    Breakfast.PourCoffee();
    Console.WriteLine("coffee is ready");

    Breakfast.FryEggs(2);
    Console.WriteLine("eggs are ready");

    Breakfast.FryBacon(3);
    Console.WriteLine("bacon is ready");

    Toast toast = Breakfast.ToastBread(2);
    Breakfast.ApplyButter(toast);
    Breakfast.ApplyJam(toast);
    Console.WriteLine("toast is ready");

    Breakfast.PourOJ();
    Console.WriteLine("oj is ready");
    Console.WriteLine("Breakfast is ready!");
}

// We can improve this a bit by 1. making the methods `async` and 2. `await` on the delays
// - In C# there is a type called `Task`, which represents a process that needs to be waited to be completed
//   - It contains the STATUS of the task as well as the RESULT of the task (if present)
// - You can `await` a Task in a method. Doing this tells the programme to:
//   - Pause execution on that line while NOT blocking the thread (the process that takes time to finish in the Task is not handled by the main thread)
//   - Once the Task has a completed status, `await` returns the RESULT of the task (NOT the Task itself)
// - You can only use `await` in an `async` method (or top-level in the program entry file). An async method returns a `Task` itself which can be awaited as well
//   - An async method runs SYNCHRONOUSLY until hitting an `await` line
// Now when waiting, the thread is not blocked and can process something else (like "starting to cook another breakfast")
// However, they are still processed one by one so the whole process is still slow

if (runType == RunType.Async)
{
    await BreakfastAsync.FryEggsAsync(2);
    await BreakfastAsync.FryBaconAsync(3);
    await BreakfastAsync.ToastBreadAsync(2);
}

// To optimise it further we need to make them run concurrently.
// The static `Task.WhenAll` takes a list of Task's, returns a Task<void> that only completes when all of them are finished
if (runType == RunType.AsyncWhenAll)
{
    var eggTask = BreakfastAsync.FryEggsAsync(2);
    var baconTask = BreakfastAsync.FryBaconAsync(3);
    var toastTask = BreakfastAsync.ToastBreadAsync(2);
    await Task.WhenAll(eggTask, baconTask, toastTask);
    Console.WriteLine("Eggs are ready");
    Console.WriteLine("Bacon is ready");
    // You can then access the result of the completed task by `await` again
    var toast = await toastTask;
    BreakfastAsync.ApplyButter(toast);
    BreakfastAsync.ApplyJam(toast);
    Console.WriteLine("Toast is ready");
    Console.WriteLine("Breakfast is ready!");
}

// In this use case, the better way is probably `Task.WhenAny`, because we do not need them all to finish before we can proceed
// It returns Task<Task> so it tells you which one is finished

if (runType == RunType.AsyncWhenAny)
{
    var eggTask = BreakfastAsync.FryEggsAsync(2);
    var baconTask = BreakfastAsync.FryBaconAsync(3);
    var toastTask = BreakfastAsync.ToastBreadAsync(2);

    List<Task> tasks = [eggTask, baconTask, toastTask];
    while (tasks.Count > 0)
    {
        Task finishedTask = await Task.WhenAny(tasks);
        if (finishedTask == eggTask)
        {
            Console.WriteLine("Eggs are ready");
        }
        else if (finishedTask == baconTask)
        {
            Console.WriteLine("Bacon is ready");
        }
        else if (finishedTask == toastTask)
        {
            var toast = await toastTask;
            BreakfastAsync.ApplyButter(toast);
            BreakfastAsync.ApplyJam(toast);
            Console.WriteLine("Toast is ready");
        }
        tasks.Remove(finishedTask); // Needs to remove the task from the list so it is not awaited again
    }
}

/**
 * Exceptions
 */
// When async methods throw exceptions, the task is "faulted".
// Instead of erroring the programme, the Task returned from the async method will hold the exception(s) in Task.Exception
// It is only when you `await` a faulted Task it will error the programme

enum RunType
{
    Sync,
    Async,
    AsyncWhenAll,
    AsyncWhenAny
}