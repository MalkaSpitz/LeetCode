public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);
        int[][] res=new int[nums.Length/3][];
        for(int i=0;i<nums.Length;i+=3){
            res[i/3]=new int[3];
            res[i/3][0]=nums[i];
            res[i/3][1]=nums[i+1];
            res[i/3][2]=nums[i+2];
            if(res[i/3][2]-res[i/3][0]>k) return new int[0][];
        }
        return res;
    }
}