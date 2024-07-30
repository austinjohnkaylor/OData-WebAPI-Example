namespace TodoApi.Models;
/// <summary>
/// Represents a single to-do item.
/// </summary>
public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Secret { get; set; }
}