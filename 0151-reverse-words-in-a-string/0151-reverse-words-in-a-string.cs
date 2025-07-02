using System.Text.RegularExpressions;

public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        s= Regex.Replace(s, @"\s+", " ");
        string[] words=s.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}