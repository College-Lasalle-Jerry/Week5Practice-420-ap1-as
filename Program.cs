// 1 Print numbers 1 to 10 using a while loop

Console.WriteLine("Print numbers 1 to 10 using a while loop");
int number = 1;

while(number <= 10)
{
    Console.WriteLine(number); // to print the number.
    number++; // increment
}

Console.WriteLine(""); // next line

// 2. Print sum of even numbers from 1 - 50;
Console.WriteLine("Print Sum of even numbers from 1 - 50");
number = 1;
int sum = 0;
while(number <= 50)
{
    if(number %2 == 0)
    {
        sum = sum + number;
    }
    number++; // Increment the number, (If you forget it will run infinetly)
}

Console.WriteLine(""); // Next Line

// 3. To check if the number is palindrome or not
// 121 the reverse is also 121 
// use .reverse (String)
// write the program to find a palindrome of a number.

Console.WriteLine("Enter a positive number to check if it is a Palindrom or Not.");
number = int.Parse(Console.ReadLine());
int copyNumber = number;
int reversedNumber = 0;

while (number > 0)
{
    // extract the digit
    int digit = number % 10; 
    // 1234
    // add that number to reversedNumber
    // 0 + 4 => 4
    reversedNumber = (reversedNumber * 10) + digit; // we add the digit and move the unit in places of tens, hunderds ....
    // (0 * 10) + 4 = 4
    // remove the last digit;
    number = number / 10;
    // 1234 -> 123
}

if(copyNumber == reversedNumber)
{
    Console.WriteLine($"{copyNumber} is Palindrome.");
}
else
{
    Console.WriteLine($"{copyNumber} is not a Palindrome.");
}


// 1st iteration
// 1234 % 10 -> 4
// (0 * 10) + 4
// remove 1234 / 10 -> 123

// 2nd Iteration
// reverse = 4, number 123
// 123 % 10 -> 3
// (4 * 10) + 3 = 43
// remove 123 / 10 -> 12

// 3rd Iteration
// reverse = 43, number 12
// 12 % 10 -> 2
// (43 * 10) + 2 = 432
// remove 12 / 10 -> 1

// 4th Iteration
// reverse = 432, number 1
// 1 % 10 -> 1
// (432 * 10) + 1 = 4321
// remove 1 / 10 -> 0.1 => 0

// 5th iteration - breaks out






// 4. Factorial of a given number using a while loop.

Console.WriteLine("Factorial of a given number using a while loop.");
number = int.Parse(Console.ReadLine()); // this will read the number and convert from string to integer.
int fact = 1;
int i = 1; // counter
while (i<=number) {
    fact = fact * i;
    i++; // Increment
}

Console.WriteLine($"The Factorial is: {fact}\n"); // \n is used to escape to the next line.



// 5. Fibonacci Series using while loop.
// 0 1 1 2 3 5 8 13 21 ...
Console.WriteLine("Fibonacci Series using while loop.");
Console.WriteLine("Enter the limit");
number = int.Parse(Console.ReadLine()); // limit for the fibonacci series.

int a = 0, b = 1;
i = 1;
while (i <= number)
{
    Console.WriteLine($"Term {i} : {a}");
    int next = a + b;
    // swap values of a, b, next;
    a = b;
    b = next;
    i++; // increment
}


// 6. sum of a digits using while loop.
// 1234 -> 1+2+3+4 = 10;
Console.WriteLine("sum of a digits using while loop.");
Console.WriteLine("ENter a No:");
number = int.Parse(Console.ReadLine()); // number from the user
sum = 0;

while (number > 0)
{
    int digit = number % 10; // this gives me the last digit
    // 1234 % 10 -> 4
    sum = sum + digit;
    // 0 + 4 -> 4
    // number -> 1234 , => 123
    number = number / 10; // remove the last digit.
    // 1234 /10 -> 123
}



// sum = 0;
// number 1234

// 1st Iteration
// 1234 % 10 -> 4
// 0 + 4 => 4
// 1234 / 10 -> 123

//2nd iteration
// 123
// 123% 10 => 3
// 4 + 3=>7
// 123/10-> 12

// 3rd iteration
// 12
// 12 % 10 -> 2
// 7 + 2 => 9
// 12 / 10 -> 1

// 4th iteration
// 1
// 1 % 10 -> 1
// 9 + 1 => 10
// 1 / 10 -> 0.1 (Removes the remainder) -> 0


Console.WriteLine($"The Sum of digits of {number} is {sum}");


Console.WriteLine("Sum of digits");
sum = 0;
number = 12345;
while (number >= 10)
{
    sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    number = sum;
}
Console.WriteLine(number);

// 10.  Sum of digits of a given number

Console.WriteLine("Sum of digits of a given number");
number = int.Parse(Console.ReadLine());
sum = 0;
while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;
}

Console.WriteLine($"sum of digits is: {sum}");


// 12345 
// 1 + 2 + 3 + 4 + 5 => 15
// 1+5 => 6

Console.WriteLine("Sum of digits until only one digit is left");
Console.WriteLine("Enter a Number:");
number = int.Parse(Console.ReadLine());
sum = 0;

while (number >= 10) // run twice
{
    while (number > 0) // 4 times (number of digits - 1)
    {
        int digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }
    // line 
    number = sum;
}

Console.WriteLine(number);

Console.WriteLine("Print the largest Digit in a given number");
Console.WriteLine("Enter a Number: ");
number = int.Parse(Console.ReadLine());

int largest = -1;
while (number > 0)
{
    int digit = number % 10; // extract the last digit.
    // if condition to check the largest value with the stored value
    if(digit >= largest)
    {
        largest = digit;
    }
    number = number / 10; // remove the last digit.
}
Console.WriteLine($"The largest Digit is: {largest}");