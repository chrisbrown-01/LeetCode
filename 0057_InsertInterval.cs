﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
    
    You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] 
    represent the start and the end of the ith interval and intervals is sorted in ascending order by starti. 
    You are also given an interval newInterval = [start, end] that represents the start and end of another interval.

    Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals 
    still does not have any overlapping intervals (merge overlapping intervals if necessary).

    Return intervals after the insertion.


    Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
    Output: [[1,5],[6,9]]


    Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
    Output: [[1,2],[3,10],[12,16]]
    Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].
 

    Constraints:

    0 <= intervals.length <= 10^4
    intervals[i].length == 2
    0 <= starti <= endi <= 10^5
    intervals is sorted by starti in ascending order.
    newInterval.length == 2
    0 <= start <= end <= 10^5

    */
    internal class _0057_InsertInterval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();

            for (var i = 0; i < intervals.Length; i++)
            {
                // newInterval occurs before existing one without overlap, so prepend
                if (newInterval[1] < intervals[i][0])
                {
                    result.Add(newInterval);
                    result.AddRange(
                        intervals.AsEnumerable().Skip(i).ToArray());

                    return result.ToArray();
                }
                // Append
                else if (newInterval[0] > intervals[i][1])
                {
                    result.Add(intervals[i]);
                }
                else
                {
                    newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
                    newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
                }
            }

            result.Add(newInterval);

            return result.ToArray();
        }
    }
}
