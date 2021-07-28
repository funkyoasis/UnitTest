using NUnit.Framework;
using CodeToTest;

namespace UnitTests
{
    public class GreetingsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(11)]
        public void GivenATimeBetween5and12Inclusive_Greeting_ReturnsGoodMorning(int time)
        {
            // Arrange
            var expectedGreeting = "Good morning!";
            // Act
            var result = Program.Greeting(time);
            // Assert
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(13)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenATimeBetween12and18Inclusive_Greeting_ReturnsGoodAfternoon(int time)
        {
            var expectedGreeting = "Good afternoon!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(19)]
        [TestCase(24)]
        [TestCase(3)]
        public void GivenATimeBetween18and5Inclusive_Greeting_ReturnsGoodEvening(int time)
        {
            var expectedGreeting = "Good evening!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        
    }
    public class Classification_Test
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(18)]
        [TestCase(19)]
        public void GivenAnAgeOf18OrMore_AvailableClassifications_returns_All_Films_Available(int age)
        {
            var expectedClassification = "All films are available.";
            var result = Program.AvailableClassifications(age);
            Assert.That(result, Is.EqualTo(expectedClassification));
        }
        [TestCase(15)]
        [TestCase(17)]
        public void GivenAnAgeOf17_To15_AvailableClassifications_returns_U_PG_12_12A_15(int age)
        {
            var expectedClassification = "U, PG, 12 & 12A & 15 films are available.";
            var result = Program.AvailableClassifications(age);
            Assert.That(result, Is.EqualTo(expectedClassification));
        }
        [TestCase(14)]
        [TestCase(12)]
        public void GivenAnAgeOf14_To12_AvailableClassifications_returns_U_PG_12_12A(int age)
        {
            var expectedClassification = "U, PG, 12 & 12A films are available.";
            var result = Program.AvailableClassifications(age);
            Assert.That(result, Is.EqualTo(expectedClassification));
        }

        [TestCase(11)]
        [TestCase(9)]
        public void GivenAnAgeOf11_To8_AvailableClassifications_returns_U_PG(int age)
        {
            var expectedClassification = "U, PG films are available.";
            var result = Program.AvailableClassifications(age);
            Assert.That(result, Is.EqualTo(expectedClassification));
        }

        [TestCase(7)]
        [TestCase(1)]
        public void GivenAnAgeOf7OrLess_AvailableClassifications_returns_U(int age)
        {
            var expectedClassification = "U films are available.";
            var result = Program.AvailableClassifications(age);
            Assert.That(result, Is.EqualTo(expectedClassification));
        }
    }
}