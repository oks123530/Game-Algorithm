using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
  
        List<int> Lanswer = new List<int>();
        
        List<int> question_one = new List<int>(){1,2,3,4,5};
        List<int> question_two = new List<int>(){2,1,2,3,2,4,2,5};
        List<int> question_thr = new List<int>(){3,3,1,1,2,2,4,4,5,5};
        
        int[] AC = new int[3];
        
        int max = 0;
        
  
        
     
        for(int j=0; j<answers.Length; j++)
        {
            if(question_one[j % 5] == answers[j])
            {
                AC[0]++;
            }
            if(question_two[j % 8] == answers[j])
            {
                AC[1]++;
            }
            if(question_thr[j % 10] == answers[j])
            {
                AC[2]++;
            }
            
        }
        
        for(int i=0; i<3; i++){
            
            if(AC[i] > max){
                max = AC[i];
            }
        }
        
        for(int i=0; i<3; i++){
            if(AC[i] == max){
                Lanswer.Add(i+1);
            }
        }
       
        return Lanswer.ToArray();
    }
}