public class Solution {
    public int TotalMoney(int n) {
        int count=0;
        int bank=0;
        while(n>=7){
            bank+=(1+2+3+4+5+6+7)+7*count;
            count++;
            n-=7;
        }
        int day=1;
        while(n>0){
            bank+=day+count;
            day++;
            n--;
        }
        return bank;
    }
}