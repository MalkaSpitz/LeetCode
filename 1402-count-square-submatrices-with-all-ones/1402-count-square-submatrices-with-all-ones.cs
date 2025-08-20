public class Solution {
    public int CountSquares(int[][] matrix) {
        int max=Math.Min(matrix.Length,matrix[0].Length);
        int count=0;
        for(int i=1;i<=max;i++){
            for(int j=0;j<=matrix.Length-i;j++){
                for(int k=0;k<=matrix[0].Length-i;k++){
                    bool flag=true;
                    for(int l=j;l<j+i;l++){
                        for(int m=k;m<k+i&&flag;m++){
                            if(matrix[l][m]==0){
                                flag=false;
                            }
                        }
                    }
                    if(flag) count++;
                }
            }
        }
        return count;
    }
}