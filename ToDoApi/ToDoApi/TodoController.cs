using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        // Simple in-memory list of To-Do items for demonstration
        private static List<string> todos = new List<string>
        {
            "Learn Docker",
            "Build .NET Web API",
            "Deploy to Docker"
        };

        // GET api/todo
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(todos);
        }

        // POST api/todo
        [HttpPost]
        public ActionResult Post([FromBody] string todo)
        {
            todos.Add(todo);
            return CreatedAtAction(nameof(Get), new { id = todos.Count - 1 }, todo);
        }
    }
}
