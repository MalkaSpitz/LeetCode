using System.Text.RegularExpressions;
public class Solution {
    public string SimplifyPath(string path) {
        path= Regex.Replace(path, @"/{2,}", "/");
        Console.WriteLine(path);
        path= Regex.Replace(path,  @"(?<=^|/)\./", "");
        Console.WriteLine(path);
        path= Regex.Replace(path, @"/$", "");
        
        string newPath="";
        Stack<string> stk=new();
        while(path.Length>0){
            string temp="";
            do{
                temp=temp+path[0];
                path=path.Substring(1);
            }while(path.Length>0&&path[0]!='/');
            
            if(temp=="/.."&&(path.Length==0||path[0]!='.')){
                if(stk.Count>0){
                    stk.Pop();
                }
                continue;
            }
            if(temp=="/.") continue;
            stk.Push(temp);
        }
        string res="";
        while(stk.Count>0){
            res=stk.Pop()+res;
        }
        return res==""?"/":res;
    }
}