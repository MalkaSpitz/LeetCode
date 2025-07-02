public class Solution {
    public bool CheckTwoChessboards(string coordinate1, string coordinate2) {
        return ((int)coordinate2[0]+(int)coordinate2[1])%2==((int)coordinate1[0]+(int)coordinate1[1])%2;
    }
}