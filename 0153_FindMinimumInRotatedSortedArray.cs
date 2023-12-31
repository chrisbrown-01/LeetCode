﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*

    Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:

    [4,5,6,7,0,1,2] if it was rotated 4 times.
    [0,1,2,4,5,6,7] if it was rotated 7 times.
    Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].

    Given the sorted rotated array nums of unique elements, return the minimum element of this array.

    You must write an algorithm that runs in O(log n) time.

    Input: nums = [3,4,5,1,2]
    Output: 1
    Explanation: The original array was [1,2,3,4,5] rotated 3 times.

    Input: nums = [4,5,6,7,0,1,2]
    Output: 0
    Explanation: The original array was [0,1,2,4,5,6,7] and it was rotated 4 times.

    Input: nums = [11,13,15,17]
    Output: 11
    Explanation: The original array was [11,13,15,17] and it was rotated 4 times. 
 
    Constraints:
    n == nums.length
    1 <= n <= 5000
    -5000 <= nums[i] <= 5000
    All the integers of nums are unique.
    nums is sorted and rotated between 1 and n times.

    */
    internal class _0153_FindMinimumInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            // Initialize left and right pointers
            int left = 0, right = nums.Length - 1;

            // Binary Search
            while (left < right)
            {
                // Calculate mid-point
                int mid = left + (right - left) / 2;

                // If mid-point element is greater than the last element
                // of the array, then the minimum element must be in the
                // right half of the array, so we update left pointer
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                // Otherwise, the minimum element must be in the left half
                // of the array, so we update right pointer
                else
                {
                    right = mid;
                }
            }

            // At the end of the while loop, left pointer points to the
            // minimum element of the array, which is the answer
            return nums[left];
        }
    }
}
