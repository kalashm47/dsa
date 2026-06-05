public class Solution {
    public int[][] Merge(int[][] intervals) {
        int arr = intervals.Length;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result  = new List<int[]>();

        for(int i = 0; i < arr; i++){
            int start = intervals[i][0];
            int end = intervals[i][1];

            if(result.Count > 0 && result[result.Count -1][1] >= end)
                continue;

            for(int j = i + 1; j < arr; j++){
                if(intervals[j][0] <=end)
                    end = Math.Max(end, intervals[j][1]);
            }
            result.Add(new int[] {start, end});
        }
        return result.ToArray();

    }
}