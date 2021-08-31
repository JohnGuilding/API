using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Interfaces
{
    public interface ITodoItemsRepository
    {
        Task<IEnumerable<TodoItemDTO>> GetAllTodoItems();

        Task<TodoItemDTO> GetTodoItem(int id);

        Task<TodoItemDTO> CreateTodoItem(TodoItemDTO todoItemDTO);
    }
}
