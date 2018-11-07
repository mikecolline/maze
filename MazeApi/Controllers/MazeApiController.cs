using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MazeApi.Controllers
{
    [Route("[controller]/[action]")]
    public class MazeApiController : Controller
    {
        public MazeApiController()
        {
        }

        [HttpPost]
        public JsonResult solveMaze([FromBody] string maze)
        {
            var service = new BL.MazeService();
            var mazeModel = service.SolveMaze(maze);

            return Json(mazeModel);
        }

    }
}
