public class Solution {
    public int Tribonacci(int n) {
        int[] tri=new int[n+3];
        tri[0]=0;
        tri[1]=tri[2]=1;
        for(int i=3;i<tri.Length;i++){
            tri[i]=tri[i-1]+tri[i-2]+tri[i-3];
        }
        return tri[n];
    }
}