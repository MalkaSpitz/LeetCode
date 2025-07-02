public class Solution {
    public int PossibleStringCount(string word) {
        char last=' ';
        int count=1;
        foreach(char letter in word){
            if(letter==last){
                count++;
            }
            last=letter;
        }
        return count;
    }
}