using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class TodoItemsRepository : ITodoItemsRepository
    {
        private readonly TodoContext _context;

        public TodoItemsRepository(TodoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoItemDTO>> GetAllTodoItems()
        {
            return await _context.TodoItem
                .Select(x => ItemToDTO(x))
                .ToListAsync();
        }

        public async Task<TodoItemDTO> GetTodoItem(int id)
        {
            var todoItem = await _context.TodoItem.FindAsync(id);
            return ItemToDTO(todoItem);
        }

        public async Task<TodoItemDTO> CreateTodoItem(TodoItemDTO todoItemDTO)
        {
            var todoItem = new TodoItem
            {
                Id = todoItemDTO.Id,
                Name = todoItemDTO.Name,
                IsComplete = todoItemDTO.IsComplete
            };

            _context.TodoItem.Add(todoItem);
            await _context.SaveChangesAsync();

            return ItemToDTO(todoItem);
        }

        private static TodoItemDTO ItemToDTO(TodoItem todoItem)
        {
            return new TodoItemDTO
            {
                Id = todoItem.Id,
                Name = todoItem.Name,
                IsComplete = todoItem.IsComplete,
            };
        }
    }
}
