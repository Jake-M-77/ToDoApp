using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Todo_API.Data;
using Todo_API.Models;

namespace Todo_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoDbContext _context;
        public ToDoController(ToDoDbContext context)
        {
            _context = context;
        }

        //HTTP methods here :)

        //Pull all tasks/Todo's
        [HttpGet]
        public async Task<ActionResult<List<ToDo>>> GetAllTasksAsync()
        {
            var tasks = await _context.ToDoList.ToListAsync();

            return tasks;

        }

        //Simple task get by id
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDo>> GetToDoByIdAsync(int id)
        {
            var task = await _context.ToDoList.FindAsync(id);

            if (task != null)
            {
                return task;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("post")]
        public async Task<ActionResult<ToDo>> CreateToDo(ToDo newToDo)
        {
            if (newToDo != null)
            {
                _context.ToDoList.Add(newToDo);
                await _context.SaveChangesAsync();
                return Ok();

            }
            else
            {
                //This will be returned if there is something missing
                //Or if there is another issue
                return BadRequest();
            }
        }

        [HttpPut("update")]
        public async Task<ActionResult<ToDo>> UpdateToDo(ToDo updatedToDo)
        {
            if (updatedToDo == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Entry(updatedToDo).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
