public class Solution {
    public void GameOfLife(int[][] board) {
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[0].Length;j++){
                int around=CountAround(board,i,j);
                if(board[i][j]%2==0&&around==3){
                    board[i][j]=2;
                }
                else if(board[i][j]%2==1&&(around>3||around<2)){
                    board[i][j]=3;
                }
            }
        }
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[0].Length;j++){
                if(board[i][j]==2){
                    board[i][j]=1;
                }
                else if(board[i][j]==3){
                    board[i][j]=0;
                }
            }
        }
    }
    private int CountAround(int[][] board,int i,int j){
        int count=0;
        try{
            count+=board[i-1][j-1]%2;
        }
        catch(Exception e){

        }
        try{
            count+=board[i-1][j]%2;
        }
        catch(Exception e){
            
        }
        try{
            count+=board[i-1][j+1]%2;
        }
        catch(Exception e){
            
        }
        try{
            count+=board[i][j-1]%2;
        }
        catch(Exception e){
            
        }
        try{
            count+=board[i][j+1]%2;
        }
        catch(Exception e){
            
        }
        try{
            count+=board[i+1][j-1]%2;
        }
        catch(Exception e){
            
        }
        try{
            count+=board[i+1][j]%2;
        }
        catch(Exception e){
            
        }
        try{
            count+=board[i+1][j+1]%2;
        }
        catch(Exception e){
            
        }
        return count;
    }
}