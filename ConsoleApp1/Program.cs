﻿using ConsoleApp1.Models;


var todos = new List<Todo>();

while(true)
{
    Console.WriteLine("Please enter your command: 'Add' or 'List'");

    var command = Console.ReadLine();

    if(command == "Add")
    {
        //Functionality for adding
        Console.WriteLine("Please enter the name");
        var name = Console.ReadLine();
        Console.WriteLine("Please enter the description");
        var description = Console.ReadLine();

        var todo = new Todo(name, description);
        todos.Add(todo);
    }

    else if (command == "List")
    {//Functionality for listing all todos
        foreach (var todo in todos)
        {
           Console.WriteLine($"Name:{todo.Name}, Description: {todo.Description}"); 
        }
        
    }
}