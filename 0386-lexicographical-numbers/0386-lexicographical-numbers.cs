public class Solution {
    public IList<int> LexicalOrder(int n) {
        List<int> res=new();
        res.Add(1);
        LexicalOrder(res,1,n);
        return res;
    }
    public void LexicalOrder(List<int> res,int last,int n) {
        if(last*10<=n){
            res.Add(last*10);
            LexicalOrder(res,last*10,n);
        }
        if(last+1<=n&&last%10!=9){
            res.Add(last+1);
            LexicalOrder(res,last+1,n);
        }

    }
}