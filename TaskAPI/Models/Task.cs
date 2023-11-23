namespace TaskAPI.Models
{
    public class Task
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool Completed { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        // public string Status { get; set; }
        // public string Priority { get; set; }
        // public string Category { get; set; }
        public DateTime Reminder { get; set; }

    }

}