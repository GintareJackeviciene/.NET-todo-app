using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Todo
    {
        
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Completed { get; set; }

        public Todo(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
