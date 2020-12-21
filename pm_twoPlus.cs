using System;
using System.Collections.Generic;
using System.Linq;


public class Solution {
    public int[] solution(int[] numbers) {
        int Number = 0;

        Dictionary<int , int> result = new Dictionary<int , int>();

        for(int i=0; i < numbers.Length; i++){

            for(int j=i+1; j<numbers.Length; ++j){

                 Number = numbers[i] + numbers[j];

                 if(result.ContainsKey(Number) == false)
                 {
                     result.Add(Number,Number);
                 }
            }

        }
        int [] answer = new int[result.Count];
        answer = result.Values.ToArray();
        Array.Sort(answer);

        return answer;
    }
}