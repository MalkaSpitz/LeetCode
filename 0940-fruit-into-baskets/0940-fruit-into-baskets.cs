public class Solution {
    public int TotalFruit(int[] fruits) {
        int t1=-1,t2=-1;
        int max=0;
        int i=0;
        int ind=0;
        int ii=-1;
        for(i=0;i<fruits.Length;i++){
            if(ii!=-1){
                i=ii;
                ii=-1;
            }

            ind=i;
            while(ind<fruits.Length){
                if(fruits[ind]!=t1&&fruits[ind]!=t2){
                    if(t1==-1){
                        t1=fruits[ind];
                        ind++;
                        max=Math.Max(max,ind-i);
                        continue;
                    }
                    if(t2==-1){
                        ii=ind;
                        t2=fruits[ind];
                        ind++;
                        max=Math.Max(max,ind-i);
                        continue;
                    }
                    max=Math.Max(max,ind-i);
                    t1=-1;
                    t2=-1;
                    break;
                }
                ind++;
                max=Math.Max(max,ind-i);
            }
        }
        return max;
    }
}