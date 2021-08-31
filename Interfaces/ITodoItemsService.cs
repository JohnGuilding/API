using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Interfaces
{
    public interface ITodoItemsService
    {
        Task<IEnumerable<TodoItemDTO>> GetAllTodoItems();

        Task<TodoItemDTO> GetTodoItem(int id);

        Task<TodoItemDTO> CreateTodoItem(TodoItemDTO todoItemDTO);

        Task<TodoItemDTO> UpdateTodoItem(int id, TodoItemDTO todoItemDTO);

        Task<bool?> DeleteTodoItem(int id);
    }
}
