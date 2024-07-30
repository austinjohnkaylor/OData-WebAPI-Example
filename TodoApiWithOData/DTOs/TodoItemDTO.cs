using TodoApiWithOData.Models;

namespace TodoApiWithOData.DTOs;

public class TodoItemDTO
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    
    public static implicit operator TodoItemDTO(Models.TodoItem todoItem)
    {
        TodoItemDTO dto = new()
        {
            Id = todoItem.Id,
            Name = todoItem.Name,
            IsComplete = todoItem.IsComplete
        };
        return dto;
    }

    public static implicit operator TodoItem(TodoItemDTO todoItemDto)
    {
        TodoItem todoItem = new()
        {
            Id = todoItemDto.Id,
            Name = todoItemDto.Name,
            IsComplete = todoItemDto.IsComplete
        };

        return todoItem;
    }
}