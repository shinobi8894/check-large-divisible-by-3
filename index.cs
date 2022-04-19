// C# program to find if a number is
// divisible by 3 or not
using System;
 
class GFG
{
    // Function to find that number
    // divisible by 3 or not
    static bool check(string str)
    {
        // Compute sum of digits
        int n = str.Length;
        int digitSum = 0;
         
        for (int i = 0; i < n; i++)
            digitSum += (str[i] - '0');
     
        // Check if sum of digits is
        // divisible by 3.
        return (digitSum % 3 == 0);
    }
 
    // main function
    public static void Main ()
    {
        string str = "1332";
         
        if(check(str))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}