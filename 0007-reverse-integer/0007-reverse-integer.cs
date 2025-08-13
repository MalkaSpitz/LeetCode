public class Solution {
    public int Reverse(int x) {
        int b=1;
        if(x<0){
            b=-1;
        }
        int res=0;
        while(x!=0){
            if(res>214748364||res<-214748364) return 0;
            res=res*10+x%10;
            x=x/10;
        }
        return Math.Abs(res)*b;
    }
}