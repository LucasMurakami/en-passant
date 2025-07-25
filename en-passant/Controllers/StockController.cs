using en_passant.Models;
using en_passant.Services.Interface;
using Microsoft.AspNetCore.Mvc;

public class StockController : Controller
{
    private readonly IStockService _stockService;
    private readonly IGameService _gameService;

    public StockController(IStockService stockService, IGameService gameService)
    {
        _stockService = stockService;
        _gameService = gameService;
    }

    [HttpPost]
    public IActionResult AddStock(GameStock gameStock)
    {
        _stockService.Add(gameStock);
        _gameService.Add(gameStock.Game);
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult GetAllStocks()
    {
        var stocks = _stockService.GetAll();
        var games = _gameService.GetAll();
        return Ok(stocks);
    }

    [HttpGet]
    public IActionResult GetStockById(long id)
    {
        var stock = _stockService.GetById(id);
        if (stock == null)
        {
            return NotFound();
        }
        return Ok(stock);
    }

    [HttpDelete]
    public IActionResult DeleteStock(long id)
    {
        var result = _stockService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateStock(long id, int quantity)
    {
        _stockService.Update(id, quantity);
        return Ok();
    }
}