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
        _repo.Remove(gameStock);
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
        _repo.Remove(_gameStock);
        _gameStock.Quantity = gameStock.Quantity;
        _repo.Add(_gameStock);

    }
}