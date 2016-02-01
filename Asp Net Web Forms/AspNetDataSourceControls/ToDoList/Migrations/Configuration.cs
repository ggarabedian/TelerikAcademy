namespace ToDoList.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Data;

    internal sealed class Configuration : DbMigrationsConfiguration<TodoListDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ToDoList.Data.TodoListDbContext context)
        {
            if (context.Todos.Any())
            {
                return;
            }

            IList<Category> categories = new List<Category>()
            {
                new Category() { Name = "Work" },
                new Category() { Name = "Home" },
                new Category() { Name = "Fun" },
            };

            IList<Todo> todos = new List<Todo>()
            {
                new Todo() { Title = "Buy TV", Content = "Some day?", DateOfLastChange = DateTime.Now, Category = categories[1] },
                new Todo() { Title = "Meet Jim", Content = "Important!", DateOfLastChange = DateTime.Now, Category = categories[1] },
                new Todo() { Title = "Finish the project", Content = "Some day!!", DateOfLastChange = DateTime.Now, Category = categories[0]  },
                new Todo() { Title = "Go Out?!", Content = "Some day!?!?!", DateOfLastChange = DateTime.Now, Category = categories[2]  }
            };

            context.Categories.AddOrUpdate(categories.ToArray());
            context.Todos.AddOrUpdate(todos.ToArray());
        }
    }
}
