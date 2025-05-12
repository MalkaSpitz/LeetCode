public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        List<int> lst = new();
        for(int i=0;i<digits.Length;i++){
            for(int j=0;j<digits.Length;j++){
                for(int k=0;k<digits.Length;k++){
                    if(i!=j&&j!=k&&k!=i&&digits[i]!=0&&digits[k]%2!=1){
                        lst.Add(digits[i]*100+digits[j]*10+digits[k]);
                    }
                }
            }
        }
        return lst.Distinct().OrderBy(x => x).ToArray();
    }
}