using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    /*

        Problem statement: Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        
        Link: https://leetcode.com/problems/two-sum/

        Data type : Array

        Approach: Traverse thru input array and store array item with index in Dictionary. And if difference of target and item found in Dictionary then return current index and index store in Dictionary.

        i.e x = z-y

    */
    public class P1Solution
    {
        public int[] TwoSum(int[] nums, int z)
        {

            //dictionary to store array item and index as value
            var dictionary = new Dictionary<int, int>();

            //traverse thru input array
            for (int i = 0; i < nums.Length; i++)
            {

                // temporary variable
                var y = nums[i];
                var x = z - y;

                // check if difference of target and current item exist which means we already have item in our dictionary which can add up with current item result in target integer.
                if (dictionary.ContainsKey(x))
                {
                    return new int[] { dictionary[x], i };
                }

                // add current item with index in dictionary if does not exist.
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);
                }
            }

            // no item found in array which fulfill problem statement condition then return empty array.
            return new int[] { };
        }
    }
}
