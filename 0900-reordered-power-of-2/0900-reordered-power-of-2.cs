public class Solution {
    public bool ReorderedPowerOf2(int n) {
        List<int> options=DigitPermutations(n);
        foreach(var o in options){
            if(IsPowerOfTwo(o)) return true;
        }
        return false;
    }
    static List<int> DigitPermutations(int num)
    {
        var digits = num.ToString().ToCharArray();
        var results = new HashSet<int>();
        Permute(digits, 0, results);
        var list = new List<int>(results);
        list.Sort();
        return list;
    }

    static void Permute(char[] arr, int start, HashSet<int> results)
    {
        if (start == arr.Length)
        {
            if(arr.Length==0||arr[0]=='0') return;
            results.Add(int.Parse(new string(arr)));
            return;
        }

        for (int i = start; i < arr.Length; i++)
        {
            Swap(arr, start, i);
            Permute(arr, start + 1, results);
            Swap(arr, start, i);
        }
    }

    static void Swap(char[] arr, int i, int j)
    {
        char tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }

    public bool IsPowerOfTwo(int n) {
        if(n==1||n==2) return true;
        if(n%2==1||n<=0) return false;
        return IsPowerOfTwo(n/2);
    }
}