using System;
public class Solution {
    public string solution(string s) {
        int a = s.Length;
        
        if(a % 2 == 0){
              return s.Substring(a/2-1,2);
        }
        else {
            return s.Substring(a/2,1);
        }
      
    }
}