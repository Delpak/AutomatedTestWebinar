using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomatedTestWebinar.Part1.UnitTests
{
    [TestClass]
    public class FishingCapacityTest
    {
        [TestMethod]
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

        [TestMethod]
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
