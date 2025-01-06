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
            var service = new LineCountService(new MockLineSourceFactory(), new TextMatchService());

            // act
            var stats = service.GetStats("er");

            Assert.Multiple(() =>
            {
                // assert
                Assert.That(stats.MatchingLineCount, Is.EqualTo(1));
                Assert.That(stats.TotalLineCount, Is.EqualTo(3));
            });
        }

        [Test]
        public void TestCountLinesWithMoq()
        {
            var mockService = new Mock<ILineSource>();
            mockService.SetupSequence(ls => ls.GetNextLine())
                .Returns("Det er en fin dag.")
                .Returns("Det var en fin dag.")
                .Returns("Det vil bli en fin dag.");
            var lineSourceFactory = new Mock<ILineSourceFactory>();
            lineSourceFactory.Setup(x => 
                    x.CreateWebLineSource(It.IsAny<string>()))
                .Returns(mockService.Object);
            
            var service = new LineCountService(lineSourceFactory.Object, new TextMatchService());
            
            // act
            var stats = service.GetStats("er");
            Assert.Multiple(() =>
            {
                // assert
                Assert.That(stats.MatchingLineCount, Is.EqualTo(1));
                Assert.That(stats.TotalLineCount, Is.EqualTo(3));
            });

        }
    }
}