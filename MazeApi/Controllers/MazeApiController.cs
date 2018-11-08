using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MazeApi.Controllers
{
    public class MazeApiController : Controller
    {
        public MazeApiController()
        {
        }

        [HttpPost]
        public ActionResult solveMaze([FromBody] string maze)
        {

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