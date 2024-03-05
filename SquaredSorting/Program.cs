namespace SquaredSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> squares = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == Math.Sqrt(nums[i]) * Math.Sqrt(nums[i]))
                {
                    squares.Add(nums[i]);
                }
            }
            squares.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
