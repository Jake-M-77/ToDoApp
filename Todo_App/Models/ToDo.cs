using System.ComponentModel.DataAnnotations;

public class ToDo
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    public DateTime dateTime { get; set; }

    public bool IsCompleted { get; set; } 

    public string? Notes { get; set; }

}