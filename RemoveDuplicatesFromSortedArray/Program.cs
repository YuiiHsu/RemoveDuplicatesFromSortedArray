namespace RemoveDuplicatesFromSortedArray
{
    /// <summary>
    /// Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 26. Remove Duplicates from Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            // 如果input參數 nums是空陣列，則回長度 = 0
            if (nums.Length == 0)
            {
                return 0;
            }

            // 因為陣列裡第一個數字[0]前面沒有可以比較的數,所以count跟i直接從1開始
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