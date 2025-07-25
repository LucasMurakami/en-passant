using en_passant.Models;
using en_passant.Services.Interface;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
public class StockController : Controller
{
    private readonly IStockService _stockService;

    public StockController(IStockService stockService)
    {
        _stockService = stockService;
    }

    [HttpPost]
    [Route("add")]
    public IActionResult AddStock(GameStock gameStock)
    {
        _stockService.Add(gameStock);
        return Ok();
    }

    [HttpGet]
    [Route("get")]
    public IActionResult GetAllStocks()
    {
        var stocks = _stockService.GetAll();
        return Ok(stocks);
    }

    [HttpGet]
    [Route("get/{id}")]
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
    [Route("delete/{id}")]
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
    [Route("update/{id}")]
    public IActionResult UpdateStock(long id, int quantity)
    {
        _stockService.Update(id, quantity);
        return Ok();
    }
    [HttpGet]
    [Route("delete/{id}")]
    public IActionResult DeleteGame(long id)
    {
        return View(_stockService.GetById(id));
    }

    /**
    [HttpDelete]
    public IActionResult DeleteGame(long id)
    {
        _stockService.Delete(id);
        return View();
    }
    */

}