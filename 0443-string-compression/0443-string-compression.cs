public class Solution {
    public int Compress(char[] chars) {
        int writeIndex=0;
        char c=chars[0];
        int count=0;
        for(int i=0;i<=chars.Length;i++){
            if(i==chars.Length){
                chars[writeIndex++]=c;
                if(count>1){
                    string num=count.ToString();
                    while(num.Length>0){
                        chars[writeIndex++]=num[0];
                        num=num.Substring(1);
                    }
                }
            }
            else if(chars[i]==c){
                count++;
            }
            else{
                chars[writeIndex++]=c;
                if(count>1){
                    string num=count.ToString();
                    while(num.Length>0){
                        chars[writeIndex++]=num[0];
                        num=num.Substring(1);
                    }
                }
                c=chars[i];
                count=1;
            }
        }
        return writeIndex;
    }
}