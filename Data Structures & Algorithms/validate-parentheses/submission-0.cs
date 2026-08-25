public class Solution {
    public bool IsValid(string s) {
        char op1 = '(';
        char op2 = '[';
        char op3 = '{';
        char cl1 = ')';
        char cl2 = ']';
        char cl3 = '}';
        Stack<char> validator = new Stack<char>();
        bool valid = true;
        for(int i = 0; i < s.Length; i++){
            if(validator.Count == 0){
                validator.Push(s[i]);
            }
            else{
                switch(validator.Peek()){
                    case '(':
                        if(s[i] == op2 || s[i] == op3)
                            validator.Push(s[i]);
                        else if(s[i] == cl2 || s[i] == cl3)
                            return false;
                        else if(s[i] == cl1)
                            validator.Pop();
                        else
                            validator.Push(s[i]);
                        break;

                    case '[':
                        if(s[i] == op1 || s[i] == op3)
                            validator.Push(s[i]);
                        else if(s[i] == cl1 || s[i] == cl3)
                            return false;
                        else if(s[i] == cl2)
                            validator.Pop();
                        else
                            validator.Push(s[i]);
                        break;

                    case '{':
                        if(s[i] == op2 || s[i] == op1)
                            validator.Push(s[i]);
                        else if(s[i] == cl2 || s[i] == cl1)
                            return false;
                        else if(s[i] == cl3)
                            validator.Pop();
                        else
                            validator.Push(s[i]);
                        break;
                    default:
                        return false;
                }
            }
        }
        return validator.Count == 0;
    }
}