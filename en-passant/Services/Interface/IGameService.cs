using en_passant.Models;

namespace en_passant.Services.Interface
{

    public interface IGameService
    {
        public void Add(Game game);
        public IList<Game> GetAll();
        public Game? GetById(long id);
        public bool Delete(long id);
        public void Update(Game game);
        
    }
}