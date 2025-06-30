public class Solution {
    private int counter =0;
    public int NumIslands(char[][] grid) {
        HashSet<string> visited=new();
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(!visited.Contains($"{i}-{j}")){
                    if(grid[i][j].Equals('1')){
                        counter++;
                        DFS(grid,i,j,visited);
                    }
                }
            }
        }
        return counter;
    }
    private void DFS(char[][] grid,int i,int j,HashSet<string> visited){
        if(visited.Contains($"{i}-{j}"))return;
        visited.Add($"{i}-{j}");
        if(i>0&&grid[i-1][j].Equals('1')){     
            DFS(grid,i-1,j,visited);
        }
        if(i<grid.Length-1&&grid[i+1][j].Equals('1')){
            DFS(grid,i+1,j,visited);
        }
        if(j>0&&grid[i][j-1].Equals('1')){
            DFS(grid,i,j-1,visited);
        }
        if(j<grid[0].Length-1&&grid[i][j+1].Equals('1')){
            DFS(grid,i,j+1,visited);
        }
    }
}