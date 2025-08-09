public class Solution {
    public int NumSquares(int n) {
        List<int> squares=new();
        int[] minSquares=new int[n+1];

        Array.Fill(minSquares,n);
        int num=1;
        while(Math.Pow(num,2)<=n){
            squares.Add((int)Math.Pow(num++,2));
        }
        minSquares[0]=0;
        for(int i=1;i<minSquares.Length;i++){
            int ind=0;
            while(ind<squares.Count&&(i-squares[ind])>=0&&(i-squares[ind])<=n){
                minSquares[i]=Math.Min(minSquares[i],1+minSquares[i-squares[ind]]);
                ind++;
            }
        }
        return minSquares[n];
    }
}