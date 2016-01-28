using AlgorithmsLibrary.InputData;
using AlgorithmsLibrary.ResultData;

namespace AlgorithmsLibrary
{
    public class Revert
    {
        private readonly int _first;
        private readonly int _second;

        public Revert(RevertInputData inputData)
        {
            _first = inputData.First;
            _second = inputData.Second;
        }

        public RevertResultData DoRevert()
        {
            var a = _first;
            var b = _second;
            a = a + b;
            b = a - b;
            a = a - b;
            return new RevertResultData {First = a, Second = b};
        }
    }
}