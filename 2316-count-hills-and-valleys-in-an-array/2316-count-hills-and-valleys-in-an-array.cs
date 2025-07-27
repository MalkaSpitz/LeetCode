public class Solution {
    public int CountHillValley(int[] nums) {
        int count = 0;

        for (int i = 1; i < nums.Length - 1; i++) {
            // דילוג על רצפים זהים משמאל
            if (nums[i] == nums[i - 1]) continue;

            // חפש את left וה-right האמיתיים
            int left = i - 1;
            while (left >= 0 && nums[left] == nums[i]) left--;
            int right = i + 1;
            while (right < nums.Length && nums[right] == nums[i]) right++;

            if (left >= 0 && right < nums.Length) {
                if ((nums[i] > nums[left] && nums[i] > nums[right]) ||
                    (nums[i] < nums[left] && nums[i] < nums[right])) {
                    count++;
                }
            }
        }

        return count;
    }
}
