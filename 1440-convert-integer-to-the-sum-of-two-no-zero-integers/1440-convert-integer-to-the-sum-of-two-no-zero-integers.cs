public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int num=1;
        while(num.ToString().Contains('0')||(n-num).ToString().Contains('0')){
            num++;
        }
        return new int[]{num,n-num};
    }
}