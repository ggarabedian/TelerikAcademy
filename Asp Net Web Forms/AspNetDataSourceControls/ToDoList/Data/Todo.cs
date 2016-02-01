namespace ToDoList.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Todo
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime? DateOfLastChange { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}