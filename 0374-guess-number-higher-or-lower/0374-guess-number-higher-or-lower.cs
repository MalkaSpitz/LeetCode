/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int from=1;
        int to=n;
        int guessed;
        while(true){
            guessed=from+(to-from+1)/2;
            int pick=guess(guessed);
            if(pick==0){
                return guessed;
            }
            if(pick==-1){
                to=guessed-1;
            }
            else from=guessed+1;
        }
        return 0;
    }
}