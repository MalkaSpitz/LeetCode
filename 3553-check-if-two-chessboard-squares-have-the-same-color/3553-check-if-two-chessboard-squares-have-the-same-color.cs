public class Solution {
    public bool CheckTwoChessboards(string coordinate1, string coordinate2) {
        return (coordinate2[0]+coordinate2[1])%2==(coordinate1[0]+coordinate1[1])%2;
    }
}