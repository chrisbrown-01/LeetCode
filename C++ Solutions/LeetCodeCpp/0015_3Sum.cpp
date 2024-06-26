/*

Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation:
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.

Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.

Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.

Constraints:

3 <= nums.length <= 3000
-10^5 <= nums[i] <= 10^5

*/

#include <vector>
#include <algorithm>

class _0015_3Sum {
public:
    std::vector <std::vector <int>> threeSum(std::vector<int>& nums) {
        std::vector <std::vector <int>> result;

        int n = nums.size();
        if (n < 3) {
            return result;
        }

        std::sort(nums.begin(), nums.end());

        for (int i = 0; i < n - 2; i++) {
            if (nums[i] > 0) {
                break;
            }
            if (i > 0 && nums[i - 1] == nums[i]) {
                continue;
            }

            int j = i + 1;
            int k = n - 1;

            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];

                if (sum < 0) {
                    j++;
                }
                else if (sum > 0) {
                    k--;
                }
                else {
                    result.push_back({ nums[i], nums[j], nums[k] });

                    while (j < k && nums[j] == nums[j + 1]) {
                        j++;
                    }
                    j++;

                    while (j < k && nums[k - 1] == nums[k]) {
                        k--;
                    }
                    k--;
                }
            }
        }

        return result;
    }
};