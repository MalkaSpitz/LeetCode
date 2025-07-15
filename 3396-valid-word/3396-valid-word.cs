public class Solution {
    public bool IsValid(string word) {
        word=word.ToLower();
        return word.Length>=3 &&
        word.Count(char.IsLetter)+word.Count(char.IsDigit)==word.Length&&
        (
            word.Contains('a')||
            word.Contains('e')||
            word.Contains('i')||
            word.Contains('o')||
            word.Contains('u')
        ) &&
        (
            word.Contains('b')||
            word.Contains('c')||
            word.Contains('d')||
            word.Contains('f')||
            word.Contains('g')||
            word.Contains('h')||
            word.Contains('m')||
            word.Contains('j')||
            word.Contains('k')||
            word.Contains('l')||
            word.Contains('n')||
            word.Contains('p')||
            word.Contains('q')||
            word.Contains('r')||
            word.Contains('s')||
            word.Contains('t')||
            word.Contains('v')||
            word.Contains('w')||
            word.Contains('x')||
            word.Contains('y')||
            word.Contains('z')
        );
    }
}