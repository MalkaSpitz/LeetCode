public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        int maxD=0;
        int maxE=0;
        foreach(int[] d in dimensions){
            int dia=d[0]*d[0]+d[1]*d[1];
            if(maxD<dia){
                maxE=d[0]*d[1];
                maxD=dia;
            }
            else if(maxD==dia){
                maxE=Math.Max(maxE,d[0]*d[1]);
            }
        }
        return maxE;
    }
}