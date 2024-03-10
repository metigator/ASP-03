namespace ASP03.TodoApp.Blazor.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Completed { get; set; }
    }
}
