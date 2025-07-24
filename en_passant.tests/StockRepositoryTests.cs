using en_passant.Models;
using en_passant.Repository;
using en_passant.Repository.Interface;
using NUnit.Framework;
 


namespace en_passant.tests
{
    public class StockRepositoryTest
    {
        private IRepository<GameStock> _repo;
        private GameStock _gs;

        [OneTimeSetUp]
        public void Setup()
        {
            _repo = new StockRepository();
            _gs = new GameStock { Quantity = 10, Game = new Game { Id = 1, Description = "Test Game" } };
        }

        [Order(1)]
        [Test]
        public void InsereGameStock_DeveAumentarALista()
        {
            _repo.Add(_gs);
            Assert.That(_repo.GetAll().Count(), !Is.EqualTo(0));
        }

        [Order(2)]
        [Test]
        [TestCase(20)]
        public void UpdateGameStock_DeveAlterarAQuantidade(int newQuantity)
        {
            _gs.Quantity = newQuantity;
            _repo.Update(_gs);
            Assert.That(_gs.Quantity, Is.EqualTo(newQuantity));
        }

        [Order(3)]
        [Test]
        public void GetAll_DeveRetornarListaNaoVazia()
        {
            Assert.That(_repo.GetAll().Count(), !Is.EqualTo(0));
        }

        [Order(4)]
        [Test]
        public void GetById_DeveRetornarNaoNull()
        {
            Assert.That(_repo.GetById(_gs.Id), !Is.EqualTo(null));
        }

        [Order(5)]
        [Test]
        public void DeletarGameStock_NaoDeveDiminuirALista()
        {
            _repo.Delete(_gs.Id);
            Assert.That(_repo.GetAll().Count(), Is.EqualTo(1));
        }

    }
}