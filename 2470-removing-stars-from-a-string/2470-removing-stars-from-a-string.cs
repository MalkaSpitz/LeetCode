public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stk=new();
        foreach(var c in s){
            if(c=='*') stk.Pop();
            else stk.Push(c);
        }
        s="";
        while(stk.Count>0){
            s=stk.Pop()+s;
        }
        return s;
    }
}