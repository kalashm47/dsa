public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        List<IList<int>> result = new();

        Array.Sort(nums);

        bool[] used = new bool[nums.Length];

        BackTrack(nums, used, new List<int>(), result);

        return result;
    }

    private void BackTrack(
        int[] nums,
        bool[] used,
        List<int> current,
        List<IList<int>> result)
    {
        if (current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i])
                continue;

            if (i > 0 &&
                nums[i] == nums[i - 1] &&
                !used[i - 1])
            {
                continue;
            }

            current.Add(nums[i]);
            used[i] = true;

            BackTrack(nums, used, current, result);

            current.RemoveAt(current.Count - 1);
            used[i] = false;
        }
    }
}