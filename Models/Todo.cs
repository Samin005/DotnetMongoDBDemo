namespace DotnetMongoDBDemo.Models;

public class Todo {
    public string title { get; set; }

    public string description { get; set; }


    public Todo(string title, string description)
    {
        this.title = title;
        this.description = description;
    }
}