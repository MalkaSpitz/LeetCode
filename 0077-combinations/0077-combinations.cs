public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> lsts=new();
        Combine(new List<int>(),1,n,k,lsts);
        return lsts;
    }
    public void Combine(List<int> lst,int ind,int n,int k,List<IList<int>> lsts){
        if(0==k){
            lsts.Add(new List<int>(lst));
            return;
        }
        for(int i=ind;i<=n;i++){
            lst.Add(i);
            Combine(lst,i+1,n,k-1,lsts);
            lst.RemoveAt(lst.Count-1);
        }
    }
}