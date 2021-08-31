using System.Threading.Tasks;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ITodoItemsService todoItemsService;
        private readonly ILogger<ApiController> _logger;

        public ApiController(ITodoItemsService todoItemsService, ILogger<ApiController> logger)
        {
            this.todoItemsService = todoItemsService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTodoItems()
        {
            var result = await todoItemsService.GetAllTodoItems();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodoItem(int id)
        {
            var result = await todoItemsService.GetTodoItem(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodoItem(TodoItemDTO todoItemDTO)
        {
            var result = await todoItemsService.CreateTodoItem(todoItemDTO);
            return CreatedAtAction(nameof(GetTodoItem), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodoItem(int id, TodoItemDTO todoItemDTO)
        {
            if (id != todoItemDTO.Id)
            {
                return BadRequest();
            }

            var result = await todoItemsService.UpdateTodoItem(id, todoItemDTO);

            if (result = null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
