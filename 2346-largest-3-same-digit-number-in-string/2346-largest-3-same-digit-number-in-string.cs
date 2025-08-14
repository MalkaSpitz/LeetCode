public class Solution {
    public string LargestGoodInteger(string num) {
        string[] goods={"999","888","777","666","555","444","333","222","111","000"};
        foreach(var g in goods){
            if(num.Contains(g)){
                return g;
            }
        }
        return "";
    }
}