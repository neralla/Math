# Math
Generate highest prime numbers in 60 seconds and display on screen

This is a program developed using windows forms to display largest prime numbers in 60 seconds

Windows form has a button that needs to be clicked to generate the largest prime number in 60 seconds. Button click does the following
1. Creates a token that can be used to cancel the prime number generation task after 60 seconds 
2. Enables the timer and sets the interval to tick every second(1000 milliseconds) . Added code in tick event(delegate) to display the current value of seconds 
3. Calls the method GetLargestPrime with token to generates the largest prime number using an asynchronous task

Tick event(delegate) does the following

1. Displays the current value of tick i.e. seconds whenever the event is raised every second and increments the second,
2. Displays the value of current highest prime at the moment it ticks.
3. If the number of ticks greater than 60 seconds it will cancel the asynchronous task using the token.

GetLargestPrime has the following logic.
It has a task with  while loop the executes until the task is cancelled.
Task will increments the number and calls the method IsPrime to check whether the incremented number is the  prime.
If it is prime then it will be assigned to largest prime.

IsPrime has the following logic
1.It will divide the input number by 2 and will return false if remainder is zero.
2. If the number is not divisible by 2 then it will loop to divide by 3,5,7....until the square root of number. If it is divisible by any number then it will return false.
 Note: If the number is not divisble by 2 then we need not check for 4,6,8....  because if the number is not divisible by 2 then it will not  be divisible by any even number. 
If the input is not divisible by any number in step 1 and 2 then it is prime because we verified for all numbers and the input is not divisible by any numbers except 1 and itself, henceforth it will return true
