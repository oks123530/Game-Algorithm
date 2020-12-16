using System;
using System.Collections.Generic;
public class Solution {
public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[]{};
        List<int> answerL = new List<int>();

        
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i] % divisor == 0){
                 answerL.Add(arr[i]);
            }
        }
        
        if(answerL.Count == 0){
            answerL.Add(-1);
        }
        
        
         answerL.Sort();
        
        answer = answerL.ToArray();
       
        
      
        return answer;
    }
}