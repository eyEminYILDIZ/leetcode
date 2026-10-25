namespace _001_two_sum;

public class SolutionTests
{
    public static TheoryData<int[], int, int[]> TestCases =>
        new()
        {
            { [2, 7, 11, 15], 9, [0, 1] },
            { [3, 2, 4], 6, [1, 2] },
            { [3, 3], 6, [0, 1] },
            { [-3, 4, 3, 90], 0, [0, 2] },
        };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void All_solutions_return_the_expected_indices(
        int[] nums,
        int target,
        int[] expectedIndices)
    {
        var solution = new Solution();
        var implementations = new Func<int[], int, int[]>[]
        {
            solution.TwoSum,
            solution.Solution1,
            solution.Solution2
        };

        foreach (var implementation in implementations)
        {
            Assert.Equal(expectedIndices, implementation(nums, target));
        }
    }
}
