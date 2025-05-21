public class Solution {
    public int MinCostToMoveChips(int[] position) {
        int odd=0,even=0;
        foreach(var p in position){
            if(p%2==0){
                even++;
            }
            else odd++;
        }
        return Math.Min(even,odd);
    }
}