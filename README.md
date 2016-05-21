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
