using en_passant.Models;
using en_passant.Models.Enum;
using en_passant.Services.Interface;
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;

=======
namespace en_passant.Controllers;
>>>>>>> 28a743585d4eaf77d14b0ecd629a19530d424fd4
public class GameController : Controller
{
    private readonly IGameService _gameService;

    public GameController(IGameService gameService)
    {
        _gameService = gameService;
    }

    [HttpPost]
    public IActionResult AddGame(Game game)
    {
        _gameService.Add(game);
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult AddGame()
    {
        return PartialView();
    }
<<<<<<< HEAD

    [HttpGet]
    public IActionResult EditGame()
    {
        var jogoMock = new Game
        {
            Id = 1,
            Name = "Me da um tiro",
            Fornecedor = "aaaaaa",
            Year = new DateTime(2022, 1, 1),
            MadeOf = Material.Plastic,
            Category = Category.Classic,
            GameType = GameType.Card,
            Description = "Jogo de tabuleiro.",
        };
        return View(jogoMock);
=======
    
    [HttpGet("Game/EditGame/{id}")]
    public IActionResult EditGame(long id)
    {
        var game = _gameService.GetById(id);
        return PartialView("EditGame", game);
>>>>>>> 28a743585d4eaf77d14b0ecd629a19530d424fd4
    }

    [HttpPost]
    public IActionResult EditGame(Game game)
    {
        _gameService.Update(game.Id, game);
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult GetAllGames()
    {
        var games = _gameService.GetAll();
        return Ok(games);
    }

    [HttpGet]
    public IActionResult ViewGame()
    {
        var jogoMock = new Game
        {
            Id = 1,
            Name = "Me da um tiro",
            Fornecedor = "aaaaaa",
            Year = new DateTime(2022, 1, 1),
            MadeOf = Material.Wood,
            Category = Category.Classic,
            GameType = GameType.Card,
            Description = "Jogo de tabuleiro.",
        };

        return View(jogoMock);
    }

    [HttpGet]
    public IActionResult GetGameById(long id)
    {
        var game = _gameService.GetById(id);
        if (game == null)
        {
            return NotFound();
        }
        return Ok(game);
    }

<<<<<<< HEAD
    [HttpPut]
    [Route("update/{id}")]
    public IActionResult UpdateGame(long id, Game game)
=======
    [HttpPut] 
    public IActionResult UpdateGame(long id,Game game)
>>>>>>> 28a743585d4eaf77d14b0ecd629a19530d424fd4
    {
        _gameService.Update(id, game);
        return Ok();
    }

    [HttpGet]
    [Route("Game/Delete")]
    public IActionResult DeleteGame()
    {
        return View();
    }

    [HttpDelete]
    public IActionResult DeleteGame(long id)
    {
        _gameService.Delete(id);
        return View();
    }
}
