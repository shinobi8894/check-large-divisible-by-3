# Python program to find if a number is
# divisible by 3 or not
 
# Function to find that number
# divisible by 3 or not
def check(num) :
     
    # Compute sum of digits
    digitSum = 0
    while num > 0 :
        rem = num % 10
        digitSum = digitSum + rem
        num = num / 10
         
    # Check if sum of digits is
    # divisible by 3.
    return (digitSum % 3 == 0)
     
# main function
num = 1332
if(check(num)) :
    print ("Yes")
else :
    print ("No")