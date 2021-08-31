using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Models;

namespace API.Services
{
    public class TodoItemsService : ITodoItemsService
    {
        private readonly ITodoItemsRepository todoItemsRepository;

        public TodoItemsService(ITodoItemsRepository todoItemsRepository)
        {
            this.todoItemsRepository = todoItemsRepository;
        }

        public async Task<IEnumerable<TodoItemDTO>> GetAllTodoItems()
        {
            return await todoItemsRepository.GetAllTodoItems();
        }

        public async Task<TodoItemDTO> GetTodoItem(int id)
        {
            return await todoItemsRepository.GetTodoItem(id);
        }

        public async Task<TodoItemDTO> CreateTodoItem(TodoItemDTO todoItemDTO)
        {
            return await todoItemsRepository.CreateTodoItem(todoItemDTO);
        }

        public async Task<TodoItemDTO> UpdateTodoItem(int id, TodoItemDTO todoItemDTO)
        {
            return await todoItemsRepository.UpdateTodoItem(id, todoItemDTO);
        }

        public async Task<bool?> DeleteTodoItem(int id)
        {
            return await todoItemsRepository.DeleteTodoItem(id);
        }
    }
}
