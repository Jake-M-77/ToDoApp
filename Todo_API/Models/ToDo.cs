
namespace Todo_API.Models
{

    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateOnly dateTime { get; set; }

        public bool IsCompleted { get; set; }

        public string? Notes { get; set; }

    }
    


}

