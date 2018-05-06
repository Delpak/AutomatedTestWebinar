using Moq;
using NUnit.Framework;

namespace AutomatedTestWebinar.Part1.UnitTests
{
    [TestFixture]
    public class FishingCapacityTest
    {
        [Test]
        public void MaximumAllowedFishesThatCanCatch_FishermanIsAmateur_Return_50()
        {
            //Arrange
            var fisherMan = new FisherMan() { Level = Level.Amateur, Name = "Hamid" };
            var fishingCapacity = new FishingCapacity();
            fishingCapacity.BlakListRepository = new StubBlackListRepository();

            //Act
            var result = fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan);

            //Assert
            Assert.AreEqual(50, result);

        }

        [Test]
        public void MaximumAllowedFishesThatCanCatch_FishermanIsBanned_Return_0()
        {
            //Arrange
            var fisherMan = new FisherMan() { Level = Level.Professional, Name = "Hamid", Banned = true };
            var fishingCapacity = new FishingCapacity();
            fishingCapacity.BlakListRepository = new StubBlackListRepository();

            //Act
            var result = fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MaximumAllowedFishesThatCanCatch_FishermanIsInBlacklist_Return_0()
        {
            //Arrange
            var fisherMan = new FisherMan() { Level = Level.Professional, Name = "Hasan", Banned = true };
            var fishingCapacity = new FishingCapacity();
            fishingCapacity.BlakListRepository = new StubBlackListRepository();

            //Act
            var result = fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MaximumAllowedFishesThatCanCatch_FishermanIsProfessional_Return_100()
        {
            //Arrange
            var fisherMan = new FisherMan() { Level = Level.Professional, Name = "Hamid" };
            var fishingCapacity = new FishingCapacity();
            var blackListRepositoryStub = new Mock<IBlackListRepository>();
            blackListRepositoryStub.Setup(x => x.GetAllNames()).Returns(() => new string[] { "Ahmad" });
            fishingCapacity.BlakListRepository = blackListRepositoryStub.Object;

            //Act
            var result = fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan);

            //Assert
            Assert.AreEqual(100, result);
        }
    }


}
