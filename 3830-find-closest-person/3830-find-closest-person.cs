public class Solution {
    public int FindClosest(int x, int y, int z) {
        int xAbs=Math.Abs(z-x);
        int yAbs=Math.Abs(z-y);
        if(yAbs==xAbs) return 0;
        if(yAbs<xAbs) return 2;
        return 1;
    }
}