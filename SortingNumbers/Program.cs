namespace SortingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                int swap = nums[i];
                int index = i;
                while (index > 0 && nums[index - 1] >= swap)
                {
                    nums[index] = nums[index - 1];
                    index--;
                }
                nums[index] = swap;
            }
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
