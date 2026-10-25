public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        return Solution2(nums, target);
    }

    public int[] Solution1(int[] nums, int target)
    {
        var results = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    results.Add(i);
                    results.Add(j);
                }
            }
        }

        return results.ToArray();
    }

    public int[] Solution2(int[] nums, int target)
    {
        var dict = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]].Add(i);
            }
            else
            {
                var difference = target - nums[i];
                if (!dict.ContainsKey(difference))
                    dict.Add(difference, new List<int>() { i });
            }
        }

        var results = new List<int>();
        foreach (var kv in dict)
        {
            if (kv.Value.Count > 1)
            {
                results.AddRange(kv.Value);
            }
        }
        return results.ToArray();
    }
}