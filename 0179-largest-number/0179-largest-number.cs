public class Solution {
    public string LargestNumber(int[] nums) {
        string[] words=new string[nums.Length];
        for(int i=0;i<nums.Length;i++){
            words[i]=nums[i].ToString();
        }
        Array.Sort(words, (a, b) => (b + a).CompareTo(a + b));
        if(words[0]=="0") return  "0";
        return string.Join("", words);
    }
}