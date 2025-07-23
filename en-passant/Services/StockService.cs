using en_passant.Models;
using en_passant.Repository.Interface;
using en_passant.Services.Interface;

namespace en_passant.Services
{
    public class StockService : IStockService
    {
        private IRepository<GameStock> _repository;

        public StockService(IRepository<GameStock> r)
        {
            _repository = r;
        }

        public void Add(GameStock game)
        {
            _repository.Add(game);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public IList<GameStock> GetAll()
        {
            return _repository.GetAll();
        }

        public GameStock? GetById(long id)
        {
            return _repository.GetById(id);
        }

        public void Update(long id, int quantity)
        {
            var gs = _repository.GetById(id);
            if (gs == null) return;
            gs.Quantity = quantity;
            _repository.Update(gs);

        }
    }
}