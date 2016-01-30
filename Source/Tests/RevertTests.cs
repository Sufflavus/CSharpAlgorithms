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

            var result = algorithm.DoRevert();

            Assert.Equal(inputData.First, result.Second);
            Assert.Equal(inputData.Second, result.First);
        }

        [Fact]
        public void DoRevert_TwoTime_CorrectState()
        {
            var inputData = new RevertInputData {First = 5, Second = 88};
            var algorithm = new Revert(inputData);

            var result = algorithm.DoRevert();
            result = algorithm.DoRevert();

            Assert.Equal(inputData.First, result.First);
            Assert.Equal(inputData.Second, result.Second);
        }
    }
}