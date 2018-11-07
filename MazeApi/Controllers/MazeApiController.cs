using Microsoft.AspNetCore.Mvc;
using System;

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
        public ActionResult solveMaze([FromBody] string maze)
        {

            if (maze == null)
            {
                ModelState.AddModelError("Error", "Puzzle to solve is null");
                return BadRequest(ModelState);

            }

            if (!(maze.Contains("A") && maze.Contains("B")))
            {
                ModelState.AddModelError("Error", "Need both a start and end to solve puzzle");
                return BadRequest(ModelState);
            }

            try
            {
                var service = new BL.MazeService();
                var mazeModel = service.SolveMaze(maze);
                return Json(mazeModel);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return BadRequest(ModelState);
            }

        }
         


    }
}
