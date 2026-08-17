using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
/*
You are given a 2D integer array logs where each logs[i] = [birthi, deathi] indicates the birth and death years of the ith person.
The population of some year x is the number of people alive during that year. 
The ith person is counted in year x's population if x is in the inclusive range [birthi, deathi - 1]. 
Note that the person is not counted in the year that they die.

Return the earliest year with the maximum population.

Example 1:

Input: logs = [[1993,1999],[2000,2010]]
Output: 1993
Explanation: The maximum population is 1, and 1993 is the earliest year with this population.
Example 2:

Input: logs = [[1950,1961],[1960,1971],[1970,1981]]
Output: 1960
Explanation: 
The maximum population is 2, and it had happened in years 1960 and 1970.
The earlier year between them is 1960.

Constraints:

1 <= logs.length <= 100
1950 <= birthi < deathi <= 2050
 
*/
namespace LeetCode.SweepLine
{
    [Prompt(nameof(MaximumPopulationYear))]
    //https://leetcode.com/problems/maximum-population-year/description/?envType=problem-list-v2&envId=mzw3cyy6
    class MaximumPopulationYear
    {
        class Event : IComparable<Event>
        {
            public int year;
            public bool isStart;

            public int CompareTo(Event eventOther)
            {
                return eventOther.year.CompareTo(this.year);
            }
        }

        public static int Solution()
        {
            int[][] logs =
            {
                [1993, 1999],
                [2000, 2010]
            };

            Event[] events = new Event[logs.Length * 2];

            for (int i = 0; i < logs.Length; i++) 
            {
                events[2 * i] = new Event{ year = logs[i][0], isStart = true };
                events[2 * i + 1] = new Event { year = logs[i][1], isStart = false };
            }

            Array.Sort(events);

            return 0;

        }
    }
}
