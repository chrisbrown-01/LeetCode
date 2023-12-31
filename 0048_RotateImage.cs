﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
    
    You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

    You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. 
    DO NOT allocate another 2D matrix and do the rotation.

    Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
    Output: [[7,4,1],[8,5,2],[9,6,3]]

    Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
    Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
 

    Constraints:

    n == matrix.length == matrix[i].length
    1 <= n <= 20
    -1000 <= matrix[i][j] <= 1000


    */
    internal class _0048_RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            (int left, int right) = (0, matrix.Length - 1);

            while (left < right)
            {
                var limit = right - left;
                for (var i = 0; i < limit; i++)
                {
                    (int top, int bottom) = (left, right);

                    // save the top left position
                    var topLeft = matrix[top][left + i];

                    // put the bottom left value to the top left position
                    matrix[top][left + i] = matrix[bottom - i][left];

                    // put the bottom right value to the bottom left position
                    matrix[bottom - i][left] = matrix[bottom][right - i];

                    // put the top right value to the bottom right position
                    matrix[bottom][right - i] = matrix[top + i][right];

                    // put the saved top left value to the top right position
                    matrix[top + i][right] = topLeft;
                }

                left++;
                right--;
            }

            return;
        }
    }
}
