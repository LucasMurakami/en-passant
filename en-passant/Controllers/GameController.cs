using en_passant.Models;
using en_passant.Services.Interface;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class GameController : Controller
{
    private readonly IGameService _gameService;

    public GameController(IGameService gameService)
    {
        _gameService = gameService;
    }

    [HttpPost]
    [Route("add")]
    public IActionResult AddGame(Game game)
    {
        _gameService.Add(game);
        return Ok();
    }

    

}   