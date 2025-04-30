public class Solution {
    public int FindNumbers(int[] nums) {
        int even=0;
        foreach(var num in nums){
            if(num<10){
                continue;
            }if(num<100){
                even++;
            }if(num<1000){
                continue;
            }if(num<10000){
                even++;
            }if(num<100000){
                continue;
            }if(num<1000000){
                even++;
            }
        }
        return even;
    }
}