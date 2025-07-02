public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        string[] S=new string[numRows];
        for (int i = 0; i < numRows; i++) {
            S[i] = "";
        }
        int ind=0;
        int whichQ=0;
        int isMinus=-1;
        while(ind<s.Length){
            S[whichQ]+=s[ind++];
            if(whichQ==numRows-1||whichQ==0)
            {
                isMinus=-isMinus;
            }
            whichQ+=isMinus;
        }
        string res="";
        for(int i=0;i<S.Length;i++){
            res=res+S[i];
        }
        return res;
    }
}