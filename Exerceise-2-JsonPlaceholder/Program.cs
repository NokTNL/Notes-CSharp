using System.Net.Http.Json;
using Exerceise_2_JsonPlaceholder;

HttpClient httpClient = new()
{
    BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
};

// GetFromJsonAsync deserializes the JSON reponse to the specified type (e.g. class / record)!
var posts = (await httpClient.GetFromJsonAsync<List<Post>>("/posts"))!; // Methods like this and `GetStringAsync` calls EnsureSuccessStatusCode() internally, so it will throw if status is not successful

Console.WriteLine($"Count: {posts.Count()}");

var decendingPostsTruncated = posts
    .Where(post => post.Id % 7 == 0)
    .OrderByDescending(post => post.Id)
    .Take(10)
    .Select(post => new {post.Id, post.Title});
foreach (var post in decendingPostsTruncated)
{
    Console.WriteLine($"{post.Id}: {post.Title}");
}


