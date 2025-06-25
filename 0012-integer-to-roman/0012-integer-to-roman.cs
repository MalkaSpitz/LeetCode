public class Solution {
    public string IntToRoman(int num) {
        string[] romanStr=new string[]{"I","IV","V","IX","X","XL","L","XC","C","CD","D","CM","M"};
        int[] romanNum=new int[]{1,4,5,9,10,40,50,90,100,400,500,900,1000};
        int ind=romanNum.Length-1;
        string res="";
        while(num>0){
            if(num>=romanNum[ind]){
                num-=romanNum[ind];
                res=res+romanStr[ind];
            }
            else{
                ind--;
            }
        }
        return res;
    }
}