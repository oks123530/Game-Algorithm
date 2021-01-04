using System;
using System.Collections.Generic;
using System.Linq;


public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        
        List<int> LostList = new List<int>(lost);
        List<int> ReserveList = new List<int>(reserve);
        
        LostList = LostList.Where(p => !reserve.Contains(p)).ToList();
        ReserveList = ReserveList.Where(p => !lost.Contains(p)).ToList();
        
        answer = n - LostList.Count;
        
        for(int i=0; i < LostList.Count; i++){
            
            if(ReserveList.Contains(LostList[i]-1)){
                
                ReserveList.Remove(LostList[i]-1);
                    
                answer++;
            }
              
            else if(ReserveList.Contains(LostList[i]+1)){
                
                ReserveList.Remove(LostList[i]+1);
                    
                answer++;
            }
        }
        
        
        return answer;
    }
}