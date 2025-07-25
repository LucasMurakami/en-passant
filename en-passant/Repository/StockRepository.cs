using en_passant.Models;
using en_passant.Repository.Interface;

namespace en_passant.Repository;


public class StockRepository : IRepository<GameStock>
{
    private IList<GameStock> _repo;
    private static int _idCount = 1;

    public StockRepository()
    {
        _repo = new List<GameStock>();
    }
    public void Add(GameStock gameStock)
    {
        gameStock.Id = _idCount++;
        _repo.Add(gameStock);   
    }

    public bool Delete(long id)
    {
        var gameStock = _repo.FirstOrDefault(gs => gs.Id == id);
        if (gameStock == null)
        {
            return false;
        }
        if(gameStock.Quantity <= 0)
        {
            return false; // Cannot delete if quantity is zero or less
        }
        gameStock.Quantity--;
        return true;
    }

    public IList<GameStock> GetAll() => _repo;
    public GameStock? GetById(long id) => _repo.FirstOrDefault(gs => gs.Id == id);
    public void Update(GameStock gameStock)
    {
        var _gameStock = _repo.FirstOrDefault(gs => gs.Id == gameStock.Id);
        if (_gameStock == null)
        {
            return;
        }
        _gameStock.Quantity = gameStock.Quantity;
    }
}