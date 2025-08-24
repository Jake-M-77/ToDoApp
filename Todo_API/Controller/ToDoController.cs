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
    }
}
