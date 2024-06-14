using TodoApi.Models;

namespace TodoApi.Dto;

public class TodoDto
{
    public static TodoItemDto ItemToDto(TodoItem todoItem) => new TodoItemDto
   {
       Id = todoItem.Id,
       Name = todoItem.Name,
       IsComplete = todoItem.IsComplete
   };
}
