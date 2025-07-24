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

    [HttpGet]
    [Route("get")]
    public IActionResult GetAllGames()
    {
        var games = _gameService.GetAll();
        return Ok(games);
    }

    [HttpGet]
    [Route("get/{id}")]
    public IActionResult GetGameById(long id)
    {
        var game = _gameService.GetById(id);
        if (game == null)
        {
            return NotFound();
        }
        return Ok(game);
    }

    [HttpPut]
    [Route("update/{id}")]
    public IActionResult UpdateGame(long id,Game game)
    {
        _gameService.Update(id,game);
        return Ok();
    }

}   