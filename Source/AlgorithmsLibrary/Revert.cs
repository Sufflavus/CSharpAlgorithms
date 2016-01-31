using AlgorithmsLibrary.InputData;

namespace AlgorithmsLibrary
{
    public class Revert
    {
        public Revert(RevertInputData inputData)
        {
            First = inputData.First;
            Second = inputData.Second;
        }

        public int First { get; private set; }
        public int Second { get; private set; }

        public void DoRevert()
        {
            var a = First;
            var b = Second;
            a = a + b;
            b = a - b;
            a = a - b;
            First = a;
            Second = b;
        }
    }
}