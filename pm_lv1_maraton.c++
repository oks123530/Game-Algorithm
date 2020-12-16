#include <string>
#include <vector>
#include <algorithm>

using namespace std;

string solution(vector<string> p, vector<string> c) 
{
    sort(p.begin() , p.end());
    sort(c.begin() , c.end());
    
    for(int i; i<c.size(); ++i){
        if(p[i]!= c[i]){
            return p[i];
        }
    }
    
    return p[p.size()-1];
        

        
    
    
    

}