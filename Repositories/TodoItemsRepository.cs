using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Models;

namespace API.Repositories
{
    public class TodoItemsRepository : ITodoItemsRepository
    {
        public Task<IEnumerable<TodoItemDTO>> GetTodoItems()
        {
            throw new NotImplementedException();
        }

        public Task<TodoItemDTO> GetTodoItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItemDTO> CreateTodoItem(TodoItemDTO todoItemDTO)
        {
            throw new NotImplementedException();
        }
    }
}
