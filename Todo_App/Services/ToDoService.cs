


using System.Net.Http.Json;

public class ToDoService
{
    private readonly HttpClient _httpclient;

    public ToDoService(HttpClient httpClient)
    {
        _httpclient = httpClient;
    }

    public async Task<List<ToDo>> ShowAllToDosAsync()
    {
        var response = await _httpclient.GetAsync("api/ToDo");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<ToDo>>();
        }
        return new List<ToDo>();
    }

    //simple todo searcher method that utilises searches for the todo id and can be used on the razor page
    public async Task<ToDo> ShowToDoById(int id)
    {
        var response = await _httpclient.GetAsync($"api/ToDo/{id}");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<ToDo>();
        }
        return null;
    }

    //simple createtodo method that can be used on the razor page
    public async Task<bool> CreateToDo(ToDo newToDo)
    {
        var response = await _httpclient.PostAsJsonAsync("api/ToDo/post", newToDo);

        return response.IsSuccessStatusCode;
    }

    //Simple Put method, updating a ToDo in the DB
    public async Task<bool> UpdateToDo(ToDo updatedToDo)
    {
        var response = await _httpclient.PutAsJsonAsync<ToDo>("api/ToDo/update", updatedToDo);

        return response.IsSuccessStatusCode;
    }

    public async Task<List<ToDo>> GetUncompletedToDos()
    {
        var response = await _httpclient.GetAsync("api/ToDo/uncompleted");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<ToDo>>();
        }
        return new List<ToDo>();
    }

    public async Task<List<ToDo>> GetcompletedToDos()
    {
        var response = await _httpclient.GetAsync("api/ToDo/completed");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<ToDo>>();
        }
        return new List<ToDo>();
    }
}