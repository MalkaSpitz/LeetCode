public class Solution {
    public int MinimumArea(int[][] grid) {
        int up=0,down=grid.Length-1,right=grid[0].Length-1,left=0;
        bool flag=true;
        for(int i=0;i<grid.Length&&flag;i++){
            up=i;
            for(int j=0;j<grid[0].Length&&flag;j++){
                if(grid[i][j]==1){
                    flag=false;
                }
            }
        }
        if(flag==true) return 0;
        flag=true;
        for(int i=grid.Length-1;i>=0&&flag&&down>up;i--){
            down=i;
            for(int j=0;j<grid[0].Length&&flag;j++){
                if(grid[i][j]==1){
                    flag=false;
                }
            }
        }
        flag=true;
        for(int i=0;i<grid[0].Length&&flag;i++){
            left=i;
            for(int j=0;j<grid.Length&&flag;j++){
                if(grid[j][i]==1){
                    flag=false;
                }
            }
        }
        flag=true;
        for(int i=grid[0].Length-1;i>=0&&flag;i--){
            right=i;
            for(int j=0;j<grid.Length&&flag;j++){
                if(grid[j][i]==1){
                    flag=false;
                }
            }
        }
        return (down-up+1)*(right-left+1);
    }
}