namespace ToDoListt.Client.Pages;
using System.Net.Http.Json;
public partial class TodayTasks
{
    [Inject] public HttpClient? _httpClient { get; set; }

    ToDoTask task = new();
    List<ToDoTask>? tasks;

    protected async Task OnInitializedAsync() => tasks = await GetTasks();

    private async Task<List<ToDoTask>?> GetTasks() =>
        await _httpClient.GetFromJsonAsync<List<ToDoTask>>("api/tasks");



    private async Task SaveTask()
    {
        if (task == null)
            return;  // Use Toster to tell the user the Task is empty



        if (task.Id == null)
            await AddTask();
        else
            await EditTask();
    }



    protected async Task AddTask()
    {
        await _httpClient.PostAsJsonAsync<ToDoTask>("api/tasks", task);



        task = new();
        tasks = await GetTasks();
    }



    protected async Task EditTask()
    {
        await _httpClient.PutAsJsonAsync($"api/tasks", task);



        task = new();
        tasks = await GetTasks();
    }



    protected async Task DeleteTask(Guid? id)
    {
        if (id == null)
            return; // Use Toster to tell the user the Task is empty



        await _httpClient.DeleteAsync($"api/tasks/{id}");
        tasks = await GetTasks();
    }
}