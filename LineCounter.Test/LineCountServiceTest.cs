using LineCounter.LineSources;
using Moq;

namespace LineCounter.Test
{
    public class LineCountServiceTest
    {
        [Test]
        public void TestCountLinesWithManualMock()
        {
            // arrange
            var lineSource = new MockLineSource();
            var service = new LineCountService(lineSource);

            // act
            var stats = service.GetStats("er");

            // assert
            Assert.AreEqual(1, stats.MatchingLineCount);
            Assert.AreEqual(3, stats.TotalLineCount);
        }

        [Test]
        public void TestCountLinesWithMoq()
        {
            // arrange
            var mockService = new Mock<ILineSource>();
            //mockService.Setup(ls => ls.GetNextLine()).Returns("Det er en fin dag.");
            mockService.SetupSequence(ls => ls.GetNextLine())
                .Returns("Det er en fin dag.")
                .Returns("Det var en fin dag.")
                .Returns("Det vil bli en fin dag.");
            var service = new LineCountService(mockService.Object);

            // act
            var stats = service.GetStats("er");

            // assert
            Assert.AreEqual(1, stats.MatchingLineCount);
            Assert.AreEqual(3, stats.TotalLineCount);
        }

        [Test]
        public void TestSum()
        {
            // arrange
            var number1 = 2;
            var number2 = 2;

            // act
            var sum = number1 + number2;

            // assert
            Assert.AreEqual(4, sum);
        }
    }
}