public class Solution {
    public int[] CountBits(int n) {
        if(n==0) return new int[]{0};
        int[] bits=new int[n+1];
        bits[0]=0;
        bits[1]=1;
        for(int i=2;i<bits.Length;i++){
            bits[i]=bits[i/2]+i%2;
        }
        return bits;
    }
}