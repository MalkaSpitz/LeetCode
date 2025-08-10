public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int max=0;
        int[,] dp=new int[matrix.Length+1,matrix[0].Length+1];
        for(int i=1;i<=matrix.Length;i++){
            for(int j=1;j<=matrix[0].Length;j++){
                if(matrix[i-1][j-1]=='1'){
                    dp[i,j]=Math.Min(Math.Min(dp[i-1,j],dp[i,j-1]),dp[i-1,j-1])+1;
                max=Math.Max(max,dp[i,j]);}
            }
        }
        return max*max;
    }
}