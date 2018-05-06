using System;
using System.Linq;
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
            Assert.That(result == 50);

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

        [Test]
        public void MaximumAllowedFishesThatCanCatch_FishermanIsBanned_Return_0()
        {
            //Arrange
            var fisherMan = new FisherMan() { Level = Level.Professional, Name = "Hamid" , Banned = true};
            var fishingCapacity = new FishingCapacity();

            //Act
            var result = fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MaximumAllowedFishesThatCanCatch_WhenFishermanIsNull_ThrowsArgumentNullException()
        {
            FisherMan fisherMan = null;
            var fishingCapacity = new FishingCapacity();

            // Require an ArgumentNullException - derived types fail!
            Assert.Throws<ArgumentNullException>(() => fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan));

            // Allow both ArgumentNullException and any derived type
            Assert.Catch<ArgumentNullException>(() => fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan));

            // Allow any kind of exception
            Assert.Catch(() => fishingCapacity.MaximumAllowedFishesThatCanCatch(fisherMan));

        }
    }
}
