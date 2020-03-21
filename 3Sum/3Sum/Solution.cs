using System;
using System.Collections.Generic;

namespace _3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum4(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            if (nums.Length < 3) { return result; }
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) { continue; }
                else if (nums[i] > 0) { break; }
                else
                {
                    for (int j = i + 1; j < nums.Length - 1; j++)
                    {
                        if (j > i + 1 && nums[j] == nums[j - 1]) { continue; }
                        else if (nums[i] + nums[j] > 0) { break; }
                        else
                        {
                            for (int k = j + 1; k < nums.Length; k++)
                            {
                                if (k > j + 1 && nums[k] == nums[k - 1]) { continue; }
                                else
                                {
                                    if (nums[i] + nums[j] + nums[k] == 0)
                                    {
                                        var x = new List<int>() { nums[i], nums[j], nums[k] };
                                        result.Add(x);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        public IList<IList<int>> ThreeSum3(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            if (nums.Length < 3) { return result; }
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) { continue; }
                else if (nums[i] > 0) { break; }
                else
                {
                    for (int j = i + 1; j < nums.Length - 1; j++)
                    {
                        if (j > i + 1 && nums[j] == nums[j - 1]) { continue; }
                        else if (nums[i] + nums[j] > 0) { break; }
                        else
                        {
                            for (int k = j + 1; k < nums.Length; k++)
                            {
                                if (k > j + 1 && nums[k] == nums[k - 1]) { continue; }
                                else
                                {
                                    if (nums[i] + nums[j] + nums[k] == 0)
                                    {
                                        var x = new List<int>() { nums[i], nums[j], nums[k] };
                                        result.Add(x);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        public IList<IList<int>> ThreeSum2(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            if (nums.Length < 3) { return result; }

            for (int i = 0; nums[i] < 0; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                else
                {
                    for (int j = nums.Length - 1; nums[j] >= 0; j--)
                    {
                        if (j < nums.Length - 1 && nums[j] == nums[j + 1])
                        {
                            continue;
                        }
                        else
                        {
                            for (int k = i + 1; k < j; k++)
                            {
                                if (k > i + 1 && nums[k] == nums[k - 1])
                                {
                                    continue;
                                }
                                else
                                {
                                    if (nums[i] + nums[j] + nums[k] == 0)
                                    {
                                        var x = new List<int>() { nums[i], nums[k], nums[j] };
                                        result.Add(x);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public IList<IList<int>> ThreeSum1(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        for (int k = i + 1; k < nums.Length; k++)
                        {
                            if (nums[i] + nums[j] + nums[k] == 0)
                            {
                                result.Add(new List<int>() { nums[j], nums[i], nums[k] });
                            }
                        }
                    }
                }
            }

            return result;
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<Tuple<int, int, int>> result = new List<Tuple<int, int, int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var x = new Tuple<int, int, int>(nums[i], nums[j], nums[k]);
                            if (!result.Contains(x))
                                result.Add(x);
                        }
                    }
                }
            }
            var re = new List<IList<int>>();
            foreach (var i in result)
            {
                re.Add(new int[] { i.Item1, i.Item2, i.Item3 });
            }
            return re;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i; result[1] = j;
                        break;
                    }
                }
            }
            return result;
        }

    }
}
