using Microsoft.AspNetCore.Mvc;
using en_passant.Models;
using en_passant.Models.Enum;
using en_passant.Services.Interface;

namespace en_passant.Controllers;

public class GameController : Controller
{
    private IGameService _gameService;
    
    public GameController(IGameService gameService)
    {
        _gameService = gameService;
    }

    [HttpGet]
    public IActionResult AddJogo()
    {
        return View();
    }

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

        return View(jogoMock);
    }

    [HttpPut]
    public IActionResult EditGame(Game game)
    {
        _gameService.Update(game);
        return RedirectToAction("Index", "Home");
    }
    
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
    
}