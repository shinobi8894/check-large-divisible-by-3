// Javascript program to find if a
// number is divisible by
// 3 or not
 
// Function to find that
// number divisible by 3 or not
function check(str)
{
     
    // Compute sum of digits
    let n = str.length;
    let digitSum = 0;
    for (let i = 0; i < n; i++)
        digitSum += (str[i] - '0');
 
    // Check if sum of digits
    // is divisible by 3.
    return (digitSum % 3 == 0);
}
 
// Driver code
let str = "1332";
let x = check(str) ? "Yes" : "No ";
document.write(x);