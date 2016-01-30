using AlgorithmsLibrary;
using Xunit;

namespace Tests
{
    public class QuickUnionWeightedTests
    {
        [Fact]
        public void IsConnected_NotConnectedByDefault()
        {
            var algorithm = new QuickUnionWeighted(2);

            Assert.Equal(0, algorithm.Result[0]);
            Assert.Equal(1, algorithm.Result[1]);
            Assert.False(algorithm.IsConnected(0, 1));
        }

        [Fact]
        public void IsConnected_TrueForConnected()
        {
            var algorithm = new QuickUnionWeighted(10);

            algorithm.Union(1, 8);
            algorithm.Union(3, 5);
            algorithm.Union(0, 2);
            algorithm.Union(8, 9);
            algorithm.Union(6, 1);

            Assert.True(algorithm.IsConnected(8, 1));
        }

        [Fact]
        public void IsConnected_FalseForNotConnected()
        {
            var algorithm = new QuickUnionWeighted(10);

            algorithm.Union(1, 8);
            algorithm.Union(3, 5);
            algorithm.Union(0, 2);
            algorithm.Union(8, 9);
            algorithm.Union(6, 1);

            Assert.False(algorithm.IsConnected(0, 3));
        }
    }
}