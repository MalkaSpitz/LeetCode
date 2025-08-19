public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first=Int32.MaxValue;
        int second=Int32.MaxValue;
        foreach(var num in nums){
            if(num<=first){
                first=num;
            }
            else if(num<=second){
                second=num;
            }
            else return true;
        }
        return false;
    }
}