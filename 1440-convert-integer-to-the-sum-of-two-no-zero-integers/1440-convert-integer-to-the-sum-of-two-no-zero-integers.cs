public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int num=1;
        while(Zero(num)||Zero(n-num)){
            num++;
        }
        return new int[]{num,n-num};
    }
    private bool Zero(int num){
        //Console.WriteLine(num.ToString());
        return num.ToString().Contains('0');
    }
}