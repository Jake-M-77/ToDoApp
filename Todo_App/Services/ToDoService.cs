


using System.Net.Http.Json;

public class ToDoService
{
    private readonly HttpClient _httpclient;

    public ToDoService(HttpClient httpClient)
    {
        _httpclient = httpClient;
    }

    public async Task<List<ToDo>> ShowAllTasksAsync()
    {
        var response = await _httpclient.GetAsync("api/ToDo");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<ToDo>>();
        }
        return new List<ToDo>();
    }
}