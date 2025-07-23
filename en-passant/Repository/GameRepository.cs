using en_passant.Models;
using en_passant.Repository.Interface;

namespace en_passant.Repository;
public class GameRepository : IRepository<Game>
{
    private IList<Game> _repo;
    private static int _idCount = 1;
    public GameRepository()
    {
        _repo = new List<Game>();
    }
    public void Add(Game game)
    {
        game.Id = _idCount++;
        _repo.Add(game);
    }

    public bool Delete(long id)
    {
        var game = _repo.FirstOrDefault(g => g.Id == id);
        if (game == null)
            return false;
        _repo.Remove(game);
        return true;
    }

    public IList<Game> GetAll() => _repo;

    public Game? GetById(long id)
    {
        var game = _repo.FirstOrDefault(g => g.Id == id);
        return game;
    }

    public void Update(Game t)
    {
        var g = _repo.FirstOrDefault(game => game.Id == t.Id);
        if (g == null)
        {
            return;
        }

        _repo.Remove(g);
        g = t;
        _repo.Add(g);
    }
}