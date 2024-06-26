/*

Given an array of integers temperatures represents the daily temperatures, 
return an array answer such that answer[i] is the number of days you have to 
wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]

Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]

Input: temperatures = [30,60,90]
Output: [1,1,0]

Constraints:

1 <= temperatures.length <= 10^5
30 <= temperatures[i] <= 100

*/

#include <vector>
#include <stack>
#include <string>

using namespace std;


class _0739_DailyTemperatures {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures) {
        int n = temperatures.size();

        // pair: [index, temp]
        stack<pair<int, int>> stk;
        vector<int> result(n);

        for (int i = 0; i < n; i++) {
            int currDay = i;
            int currTemp = temperatures[i];

            while (!stk.empty() && stk.top().second < currTemp) {
                int prevDay = stk.top().first;
                int prevTemp = stk.top().second;
                stk.pop();

                result[prevDay] = currDay - prevDay;
            }

            stk.push({ currDay, currTemp });
        }

        return result;
    }
};