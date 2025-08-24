public class Solution {
    public int EvalRPN(string[] tokens) {
        //stack int
        //forach "+", "-", "*", or "/" -> 2 lasts, else -> push
        Stack<int> calc=new();
        foreach(var token in tokens){
            if(token=="+"||  token=="-"|| token=="*"|| token=="/"){
                if(token=="+"){
                    calc.Push(calc.Pop()+calc.Pop());
                }
                if(token=="-"){
                    int num1=calc.Pop();
                    int num2=calc.Pop();
                    calc.Push(num2-num1);
                }
                if(token=="*"){
                    calc.Push(calc.Pop()*calc.Pop());
                }
                if(token=="/"){
                    int num1=calc.Pop();
                    int num2=calc.Pop();
                    calc.Push(num2/num1);
                }
            }
            else{
                calc.Push(Int32.Parse(token));
            }
        }
        return calc.Pop();
    }
}