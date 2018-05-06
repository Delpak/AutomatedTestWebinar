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

            //Act
            var result = fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan);

            //Assert
            Assert.AreEqual(50, result);

        }

        [Test]
        public void MaximumAllowedFishesThatCanCatch_FishermanIsProfessional_Return_100()
        {
            //Arrange
            var fisherMan = new FisherMan() { Level = Level.Professional, Name = "Hamid" };
            var fishingCapacity = new FishingCapacity();

            //Act
            var result = fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan);

            //Assert
            Assert.AreEqual(100, result);
        }

    }


}
