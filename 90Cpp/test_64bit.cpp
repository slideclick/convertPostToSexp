#include <iostream>
using namespace std;
int main()
{
    char * p = 0x0;
    cout<< sizeof(p)<< endl;
    
    long l =1;
    cout << sizeof(l)<< endl;
    
     __int64 i =1;
    cout << sizeof(i)<< endl;
    
    long long m =1;
    cout << sizeof(m)<< endl;
    return 0;
}