using Microsoft.AspNetCore.Mvc;
using en_passant.Models;
using en_passant.Models.Enum;

namespace en_passant.Controllers;

public class GameController : Controller
{
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
            MadeOf = Material.Wood,
            Category = Category.Classic,
            GameType = GameType.Card,
            Description = "Jogo de tabuleiro."
        };

        return View(jogoMock);
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