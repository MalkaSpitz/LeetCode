public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] splitted=s.Split(' ');
        if(pattern.Length!=splitted.Length) return false;

        Dictionary<string,char> map=new();

        for(int i=0;i<pattern.Length;i++){
            if(map.ContainsKey(splitted[i])){
                if(map[splitted[i]]!=pattern[i]) {
                    return false;
                }
            }
            else if(map.ContainsValue(pattern[i])){
                return false;
            }
            else map.Add(splitted[i],pattern[i]);
            Console.WriteLine($"{splitted[i]} - {map[splitted[i]]} - {pattern[i]}");

        }
        return true;
    }
}