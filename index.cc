// C++ program to find if a number is divisible by
// 3 or not
#include<bits/stdc++.h>
using namespace std;
 
// Function to find that number divisible by 3 or not
int check(string str)
{
    // Compute sum of digits
    int n = str.length();
    int digitSum = 0;
    for (int i=0; i<n; i++)
        digitSum += (str[i]-'0');
 
    // Check if sum of digits is divisible by 3.
    return (digitSum % 3 == 0);
}
 
// Driver code
int main()
{
    string str = "1332";
    check(str)?  cout << "Yes" : cout << "No ";
    return 0;
}