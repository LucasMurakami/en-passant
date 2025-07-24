using en_passant.Models;
using en_passant.Services;
using en_passant.Services.Interface;
using en_passant.Repository;
namespace en_passant.tests
{
    public class StockServiceTest
    {
        private IStockService _service;
        private GameStock _gs;

        [OneTimeSetUp]
        public void Setup()
        {
            _service = new StockService(new StockRepository());
            _gs = new GameStock { Quantity = 10, Game = new Game { Id = 1, Description = "Test Game" } };
        }

        [Order(1)]
        [Test]
        public void InsertGameStock_ShouldIncreaseList()
        {
            _service.Add(_gs);
            Assert.That(_service.GetAll().Count(), Is.GreaterThan(0));
        }

        [Order(2)]
        [Test]
        [TestCase(20)]
        public void UpdateGameStock_ShouldChangeQuantity(int newQuantity)
        {
            _service.Update(_gs.Id,newQuantity);
            Assert.That(_gs.Quantity, Is.EqualTo(newQuantity));
        }

        [Order(3)]
        [Test]
        public void GetAll_ShouldReturnNonEmptyList()
        {
            Assert.That(_service.GetAll().Count(), Is.GreaterThan(0));
        }

        [Order(4)]
        [Test]
        public void GetById_ShouldReturnNotNull()
        {
            Assert.That(_service.GetById(_gs.Id), Is.Not.Null);
        }

        [Order(5)]
        [Test]
        public void DeleteGameStock_ShouldDecreaseQuantity()
        {
            int? quantity = _service.GetById(_gs.Id).Quantity;
            _service.Delete(_gs.Id);
            var gs = _service.GetById(_gs.Id);
            Assert.That(gs.Quantity, Is.EqualTo(quantity - 1));
        }
    }


}