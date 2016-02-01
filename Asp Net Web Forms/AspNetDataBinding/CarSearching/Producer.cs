namespace CarSearching
{
    using System.Collections.Generic;

    public class Producer
    {
        public Producer(string name, ICollection<Model> models)
        {
            this.Name = name;
            this.Models = models;
        }

        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}