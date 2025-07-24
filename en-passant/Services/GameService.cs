using en_passant.Models;
using en_passant.Repository.Interface;
using en_passant.Services.Interface;

namespace en_passant.Services
{
    public class GameService : IGameService
    {
        private IRepository<Game> _repository;
        public GameService(IRepository<Game> r)
        {
            _repository = r;
        }
        public void Add(Game game)
        {
            _repository.Add(game);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public IList<Game> GetAll()
        {
            return _repository.GetAll();
        }

        public Game? GetById(long id)
        {
            return _repository.GetById(id);
        }

        public void Update(long id,Game game)
        {
            var g = _repository.GetById(id);
            if (g == null) return;
            game.Id = id; // Ensure the ID is set correctly for the update
            _repository.Update(game);
        }
    }
}