using AlgorithmsLibrary;
using AlgorithmsLibrary.InputData;
using Xunit;

namespace Tests
{
    public class RevertTests
    {
        [Fact]
        public void DoRevert_OneTime_CorrectState()
        {
            var inputData = new RevertInputData {First = 5, Second = 88};
            var algorithm = new Revert(inputData);

            algorithm.DoRevert();

            Assert.Equal(inputData.First, algorithm.Second);
            Assert.Equal(inputData.Second, algorithm.First);
        }

        [Fact]
        public void DoRevert_TwoTime_CorrectState()
        {
            var inputData = new RevertInputData {First = 5, Second = 88};
            var algorithm = new Revert(inputData);

            algorithm.DoRevert();
            algorithm.DoRevert();

            Assert.Equal(inputData.First, algorithm.First);
            Assert.Equal(inputData.Second, algorithm.Second);
        }
    }
}