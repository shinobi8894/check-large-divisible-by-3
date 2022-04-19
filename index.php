<?php
// PHP program to find if a
// number is divisible by
// 3 or not
 
// Function to find that
// number divisible by 3 or not
function check($str)
{
     
    // Compute sum of digits
    $n = strlen($str);
    $digitSum = 0;
    for ($i = 0; $i < $n; $i++)
        $digitSum += ($str[$i] - '0');
 
    // Check if sum of digits
    // is divisible by 3.
    return ($digitSum % 3 == 0);
}
 
// Driver code
$str = "1332";
$x = check($str) ? "Yes" : "No ";
echo($x);
 
?>