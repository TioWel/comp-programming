using csharp.problemlibrary.LeetCode.Easy;

namespace csharp.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine() ?? throw new ArgumentException("Argumentos do console inválidos!!");
            //var input2 = Console.ReadLine() ?? throw new ArgumentException("Argumentos do console inválidos!!");
            // var inputList = new List<string>() { "()", "()[]{}" };
            int[] input = [2, 7, 11, 15];
            var input2 = 9;

            var response = TwoSum.TwoSumResolution(input, input2);

            Console.WriteLine(response);

        }
    }
}
