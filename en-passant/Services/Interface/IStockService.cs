using en_passant.Models;

namespace en_passant.Services.Interface
{
    public interface IStockService
    {
        public void Add(GameStock game);
        public IList<GameStock> GetAll();
        public GameStock? GetById(long id);
        public bool Delete(long id);
        public void Update(long id, int quantity);
    }

}