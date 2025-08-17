public class Solution {
    public int Maximum69Number (int num) {
        string n=num.ToString();
        bool b=false;
        int res=0;
        foreach(var c in n){
            if(!b&&c=='6'){
                res=res*10+9;
                b=true;
            }
            else{
                res=res*10 + (int)(c-'0');
            }
        }
        return res;
    }
}