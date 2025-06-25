public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> nums=new();

        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                if(board[i][j]!='.'){
                    if(!nums.Add(board[i][j])){
                        return false;
                    }
                }
            }
            nums.Clear();
        }
        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                if(board[j][i]!='.'){
                    if(!nums.Add(board[j][i])){
                        return false;
                    }
                }
            }
            nums.Clear();
        }
        Dictionary<string,HashSet<char>> cube=new();

        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                if(board[i][j]!='.'){
                    string cubNum=$"{i/3},{j/3}";
                    if(cube.ContainsKey(cubNum)){
                        if(cube[cubNum].Contains(board[i][j])){
                            return false;
                        }
                        cube[cubNum].Add(board[i][j]);
                    }
                    else{
                        HashSet<char> h= new();
                        h.Add(board[i][j]);
                        cube.Add(cubNum,h);
                    }
                }
            }
        }
        return true;
    }
}