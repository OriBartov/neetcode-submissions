public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int left = 0, right = heights.Length - 1; // Start with the biggest length between the  left most and right most bars
        while (left < right)
        {
            // Check for the smaller between the right and left bars and multiply by the distance between them
            if (heights[left] < heights[right])
            {
                max = Math.Max(max, heights[left] * (right - left));
                left ++;
            }
            else
            {
                max = Math.Max(max, heights[right] * (right - left));
                right --;
            }
        }
        return max;
    }
}
