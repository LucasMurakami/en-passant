using Microsoft.AspNetCore.Mvc;
using en_passant.Models;
using en_passant.Models.Enum;
using en_passant.Services.Interface;

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
        return RedirectToAction("Index", "Home");
    }

    public IActionResult AddJogo()
    {
        return PartialView();
    }
    
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
            Description = "Jogo de tabuleiro."
        };
        return PartialView("EditGame", jogoMock);
    }

    [HttpPost]
    public IActionResult EditGame(Game game)
    {
        _gameService.Update(game.Id, game);
        return RedirectToAction("Index", "Home");
    }
    
    [HttpGet]
    [Route("get")]
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
            Description = "Jogo de tabuleiro."
        };

        return View(jogoMock);
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
