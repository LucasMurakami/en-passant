using en_passant.Models;
using en_passant.Repository;
using en_passant.Repository.Interface;
namespace en_passant.tests
{
    public class GameRepositoryTest
    {
        private IRepository<Game> _repo;
        private Game _g;
        [OneTimeSetUp]
        public void Setup()
        {
            _repo = new GameRepository();
            _g = new Game();
        }

        [Order(1)]
        [Test]
        public void InsereJogo_DeveAumentarALista()
        {

            _repo.Add(_g);
            Assert.That(_repo.GetAll().Count(), !Is.EqualTo(0));
        }


        [Order(2)]
        [Test]
        [TestCase("blabla")]
        public void UpdateJogo_DeveAlterarOJogoSemExcluir(string description)
        {
            string? cp = _g.Description ?? "";
            _g.Description = description;
            _repo.Update(_g);
            Assert.That(_g.Description, !Is.EqualTo(cp));
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
            Assert.That(_repo.GetById(_g.Id), !Is.EqualTo(null));
        }

        [Order(5)]
        [Test]
        public void DeletarJogo_DeveDiminuirALista()
        {
            _repo.Delete(_g.Id);
            Assert.That(_repo.GetAll().Count(), Is.EqualTo(0));
        }
    }
}