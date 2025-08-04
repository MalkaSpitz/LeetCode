public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<IList<int>> tr= Generate(rowIndex+1);
        return tr[rowIndex];
    }
    public IList<IList<int>> Generate(int numRows) {
        int[][] res = new int[numRows][];
        for(int i=0;i<numRows;res[i] = new int[i+1],res[i][0]=res[i][i++]=1);
        int l=2;
        for(int i=1;i<l;i++){
            for(int j=1; j<i;j++){
                res[i][j]=res[i-1][j]+res[i-1][j-1];
            }
            if(l<numRows)
            l++;
        }
        return res;
    }
}