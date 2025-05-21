public class Solution {
    public void SetZeroes(int[][] matrix) {
        HashSet<int> row = new();
        HashSet<int> column = new();
        for(int i=0;i<matrix.Length;i++){
            for(int j=0;j<matrix[0].Length;j++){
                if(matrix[i][j]==0){
                    row.Add(i);
                    column.Add(j);
                }
            }
        }

        for(int i=0;i<matrix.Length;i++){
            for(int j=0;j<matrix[0].Length;j++){
                if(row.Contains(i)||column.Contains(j)){
                    matrix[i][j]=0;
                }
            }
        }
    }
}