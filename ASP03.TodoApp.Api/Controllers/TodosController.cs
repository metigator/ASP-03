using ASP03.TodoApp.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP03.TodoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var todos = new List<Todo>()
            {
                 new Todo {
                     Id = 1,
                     Description= "Finish coding the login page for the app by end of day.",
                     CreatedAt = new DateTime (2024, 02, 28, 14, 38, 0),
                     Completed = false
                 },
                 new Todo
                 {
                     Id = 2,
                     Description= "Schedule a meeting with the design team to discuss UI improvements",
                     CreatedAt = new DateTime (2024, 01, 18, 18, 41, 0),
                     Completed = true
                 },
                 new Todo
                 {
                     Id = 3,
                     Description= "Review the latest pull requests from the development " +
                     "team and provide feedback",
                     CreatedAt = new DateTime (2024, 03, 06, 09, 12, 0),
                     Completed = false
                 },
                 new Todo
                 {
                     Id = 4,
                     Description= "Prepare presentation slides for tomorrow's project " +
                                     "status meeting with stakeholders",
                     CreatedAt = new DateTime (2024, 02, 04, 14, 57, 0),
                     Completed = false
                 }
            };

            return Ok(todos);
        }
    }
}
