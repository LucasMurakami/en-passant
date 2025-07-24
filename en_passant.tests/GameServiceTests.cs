using en_passant.Models;
using en_passant.Repository;
using en_passant.Repository.Interface;
using en_passant.Services;
using en_passant.Services.Interface;
using NUnit.Framework;

namespace en_passant.tests
{
    public class GameServiceTest
    {
        private IGameService _service;
        private Game _g;

        [OneTimeSetUp]
        public void Setup()
        {
            _service = new GameService(new GameRepository());
            _g = new Game { Description = "Test Game" };
        }

        [Order(1)]
        [Test]
        public void AddGame_ShouldAddGame()
        {
            _service.Add(_g);
            Assert.That(_service.GetAll().Count, Is.GreaterThan(0));
        }

        [Order(2)]
        [Test]
        [TestCase("Updated Game Description")]
        public void UpdateGame_ShouldUpdateGame(string newDescription)
        {
            string originalDescription = _g.Description;
            _g.Description = newDescription;
            _service.Update(_g);
            Assert.That(_g.Description, Is.EqualTo(newDescription));
            Assert.That(_service.GetById(_g.Id)?.Description, Is.EqualTo(newDescription));
        }

        [Order(3)]
        [Test]
        public void GetAllGames_ShouldReturnAllGames()
        {
            var games = _service.GetAll();
            Assert.That(games, Is.Not.Null);
            Assert.That(games.Count, Is.GreaterThan(0));
        }

        [Order(4)]
        [Test]
        public void GetGameById_ShouldReturnGame()
        {
            var game = _service.GetById(_g.Id);
            Assert.That(game, Is.Not.Null);
            Assert.That(game?.Description, Is.EqualTo(_g.Description));
        }


        [Order(5)]
        [Test]
        public void DeleteGame_ShouldRemoveGame()
        {
            bool result = _service.Delete(_g.Id);
            Assert.That(result, Is.True);
            Assert.That(_service.GetById(_g.Id), Is.Null);
        }
    }
}