public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] pre=new int[nums.Length+2];
        int[] suf=new int[nums.Length+2];

        pre[0]=suf[0]=pre[pre.Length-1]=suf[suf.Length-1]=1;
        for(int i=1;i<pre.Length-1;i++){
            pre[i]=pre[i-1]*nums[i-1];
        }
        for(int i=suf.Length-2;i>=1;i--){
            suf[i]=suf[i+1]*nums[i-1];
        }
        int[] answer=new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            answer[i]=pre[i]*suf[i+2];
        }
        return answer;
    }
}