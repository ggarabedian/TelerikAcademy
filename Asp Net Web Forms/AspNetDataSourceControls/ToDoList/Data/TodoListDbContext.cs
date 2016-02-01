namespace ToDoList.Data
{
    using System.Data.Entity;

    using Migrations;

    public class TodoListDbContext : DbContext
    {
        public TodoListDbContext() : base("TodoListDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TodoListDbContext, Configuration>());
        }

        public DbSet<Todo> Todos { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}