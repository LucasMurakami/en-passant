using Microsoft.AspNetCore.Mvc;

namespace en_passant.Controllers;

public class GameController : Controller
{
    public IActionResult AddJogo()
    {
        return View();
    }
}