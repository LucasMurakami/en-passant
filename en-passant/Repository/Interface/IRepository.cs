namespace en_passant.Repository.Interface
{
    public interface IRepository<T>
    {
        public void Add(T t);
        public IList<T> GetAll();
        public T GetById(long id);
        public bool Delete(long id);
        public void Update(T t);
    }
}