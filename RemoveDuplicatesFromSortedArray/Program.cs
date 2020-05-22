namespace RemoveDuplicatesFromSortedArray
{
    internal class Program
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    count++;
                    nums[count - 1] = nums[i];
                }
            }

            return count;
        }
    }
}