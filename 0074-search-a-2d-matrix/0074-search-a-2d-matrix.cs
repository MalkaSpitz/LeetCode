public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for(int i=0;i<matrix.Length;i++){
            if(target>=matrix[i][0]&&target<=matrix[i][matrix[0].Length-1]){
                for(int j=0;j<matrix[0].Length;j++){
                    if(matrix[i][j]==target){
                        return true;
                    }
                }
            }
        }
        return false;
    }
}