public class Solution {
    public int MaxProfit(int[] prices) {
        int maxPro=0,min=prices.Max();
        for(int i=0;i<prices.Length;i++){
            min=Math.Min(min,prices[i]);
            if((prices[i]-min)>maxPro){
                maxPro=prices[i]-min;
            }
        }
        return maxPro>0?maxPro:0;
            
    }
}