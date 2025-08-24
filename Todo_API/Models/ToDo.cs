
namespace Todo_API.Models
{

    public class ToDo
    {
    public int Id { get; set; }
    public string Name { get; set; }

    public DateTime dateTime { get; set; }

    public bool? IsCompleted { get; set; } //This has been set to nullable
    }

}

