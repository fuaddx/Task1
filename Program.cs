namespace Task
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[] nums = { 1, 7, 15, 5, 9 };
            int[] nums2 = new int[nums.Length];
            int lastIndex = nums.Length - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                nums2[lastIndex - i] = nums[i];
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                Console.WriteLine(nums2[i]);
            }
        }
    }
}