// ============================================================
// TASK 1. Greet the user
// ============================================================
// Ask the user to enter their name using Console.ReadLine().
// Then print the following message:
// "Hello, <name>!"
//
// Example:
// Input: Alex
// Output: Hello, Alex!
//
// Goal:
// - Console.WriteLine()
// - Console.ReadLine()
// - string variables

Console.Write("Enter your name: "); 
string name = Console.ReadLine(); 
Console.WriteLine("Hello, " + name + "!");

// ============================================================
// TASK 2. Add two numbers
// ============================================================
// Ask the user to enter two integer numbers.
// Convert the input text into int values.
// Print the sum of the two numbers.
//
// Example:
// First number: 10
// Second number: 7
// Result: 17
//
// Goal:
// - int
// - int.Parse() or Convert.ToInt32()
// - arithmetic operations
Console.Write("Enter the first number: "); 
int number1 = int.Parse(Console.ReadLine()); 
Console.Write("Enter the second number: "); 
int number2 = int.Parse(Console.ReadLine()); 
int sum = number1 + number2; Console.WriteLine("Result: " + sum);

// ============================================================
// TASK 3. Simple calculator
// ============================================================
// Ask the user to enter two numbers.
//
// Print:
// - the sum
// - the difference
// - the product
// - the division result
//
// Keep in mind that you may need to use double
// so that division can return decimal numbers.
//
// Example:
// Numbers: 10 and 4
// Sum: 14
// Difference: 6
// Product: 40
// Division: 2.5
//
// Goal:
// - int and double
// - +, -, *, /
// - type conversion

Console.Write("Enter the first number: ");
double number3 = double.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
double number4 = double.Parse(Console.ReadLine());

Console.WriteLine("Sum: " + (number3 + number2));
Console.WriteLine("Difference: " + (number3 - number4));
Console.WriteLine("Product: " + (number3 * number4));
Console.WriteLine("Division: " + (number3 / number4));

// ============================================================
// TASK 4. Even or odd number
// ============================================================
// Ask the user to enter an integer.
//
// Check whether the number is even or odd.
//
// Hint:
// You can use the % operator to get the remainder
// after division.
//
// If the number can be divided by 2 without a remainder,
// it is even.
//
// Example:
// Input: 7
// Output: The number is odd.
//
// Goal:
// - if / else
// - % operator
// - comparison with ==
Console.Write("Enter a number: "); 
int num = int.Parse(Console.ReadLine()); 
if (num % 2 == 0) 
{ 
    Console.WriteLine("The number is even."); 
} 
else 
{ 
    Console.WriteLine("The number is odd."); 
}

// ============================================================
// TASK 5. Age check
// ============================================================
// Ask the user to enter their age.
//
// If the age is less than 18:
// print "Access denied".
//
// If the age is 18 or higher:
// print "Access granted".
//
// Additionally:
// If the user enters a negative age,
// print an error message.
//
// Goal:
// - if
// - else if
// - else
// - < and >= operators

Console.Write("Enter your age: "); 
int age = int.Parse(Console.ReadLine()); 
if (age < 0) 
{ 
    Console.WriteLine("Invalid age."); 
} 
else if (age < 18) 
{ 
    Console.WriteLine("Access denied."); } else { Console.WriteLine("Access granted."); 
}

// ============================================================
// TASK 6. Find the largest number
// ============================================================
// Ask the user to enter three numbers.
//
// Find and print the largest number.
//
// Try to solve the task using if statements.
//
// Example:
// Input:
// 12
// 42
// 7
//
// Output:
// The largest number is: 42
//
// Goal:
// - multiple conditions
// - number comparison
// - variables

Console.Write("Enter the first number: "); 
int number5 = int.Parse(Console.ReadLine()); 
Console.Write("Enter the second number: "); 
int number6 = int.Parse(Console.ReadLine()); 
Console.Write("Enter the third number: "); 
int number7 = int.Parse(Console.ReadLine()); 
int largest = number5; 
if (number6 > largest) { largest = number6; }
if (number7 > largest) { largest = number7; }
Console.WriteLine("The largest number is: " + largest);

// ============================================================
// TASK 7. Grade calculator
// ============================================================
// Ask the user to enter a score from 0 to 100.
//
// Print the corresponding result:
//
// 90-100 -> "Excellent"
// 75-89  -> "Good"
// 60-74  -> "Satisfactory"
// 0-59   -> "Failed"
//
// If the number is below 0 or above 100,
// print "Invalid score".
//
// Goal:
// - logical conditions
// - && operator
// - else if
// - checking number ranges
Console.Write("Enter your day: "); 
int score = int.Parse(Console.ReadLine()); 
if (score < 0 || score > 100) 
{ 
    Console.WriteLine("Invalid score."); 
} 
else if (score >= 90) 
{ 
    Console.WriteLine("Excellent"); 
} 
else if (score >= 75) 
{ 
    Console.WriteLine("Good"); 
} 
else if (score >= 60) 
{ 
    Console.WriteLine("Satisfactory"); 
} 
else 
{ 
    Console.WriteLine("Failed"); 
}

// ============================================================
// TASK 8. Day of the week
// ============================================================
// Ask the user to enter a number from 1 to 7.
//
// Print the corresponding day:
//
// 1 -> Monday
// 2 -> Tuesday
// 3 -> Wednesday
// 4 -> Thursday
// 5 -> Friday
// 6 -> Saturday
// 7 -> Sunday
//
// Use a switch statement.
//
// If the user enters another number,
// print "Invalid day".
//
// Goal:
// - switch
// - case
// - default

Console.Write("Enter a number from 1 to 7: "); 
int day = int.Parse(Console.ReadLine()); 
switch (day) 
{
case 1: 
    Console.WriteLine("Monday"); 
    break; 
case 2: 
    Console.WriteLine("Tuesday"); 
    break; 
case 3: 
    Console.WriteLine("Wednesday"); 
    break; 
case 4: 
    Console.WriteLine("Thursday"); 
    break; 
case 5: 
    Console.WriteLine("Friday"); 
    break; 
case 6: 
    Console.WriteLine("Saturday"); 
    break; 
case 7: 
    Console.WriteLine("Sunday"); 
    break; 
default: 
    Console.WriteLine("Invalid day."); 
    break; 
}

// ============================================================
// TASK 9. Print numbers from 1 to N
// ============================================================
// Ask the user to enter a number N.
//
// Use a for loop to print all numbers
// from 1 to N, including N.
//
// Example:
// Input: 5
//
// Output:
// 1
// 2
// 3
// 4
// 5
//
// Goal:
// - for loop
// - counter variable
// - loop condition

Console.Write("Enter N: "); 
int n = int.Parse(Console.ReadLine()); 
for (int i = 1; i <= n; i++) 
{ 
    Console.WriteLine(i); 
}

// ============================================================
// TASK 10. Sum numbers from 1 to N
// ============================================================
// Ask the user to enter a number N.
//
// Calculate the sum of all integer numbers
// from 1 to N.
//
// Do not use a mathematical formula.
// Use a loop.
//
// Example:
// Input: 5
//
// 1 + 2 + 3 + 4 + 5 = 15
//
// Output:
// Sum: 15
//
// Goal:
// - for loop
// - storing and updating a result variable

Console.Write("Enter N: "); 
int m = int.Parse(Console.ReadLine()); 
int summ = 0; 
for (int k = 1; k <= m; k++) { summ = summ + k; }
Console.WriteLine("Sum: " + summ);

// ============================================================
// TASK 11. Multiplication table
// ============================================================
// Ask the user to enter a number.
//
// Print the multiplication table
// for this number from 1 to 10.
//
// Example for number 5:
//
// 5 * 1 = 5
// 5 * 2 = 10
// 5 * 3 = 15
// ...
// 5 * 10 = 50
//
// Goal:
// - for loop
// - arithmetic
// - formatted output

Console.Write("Enter a number: "); 
int number8 = int.Parse(Console.ReadLine()); 
for (int q = 1; q <= 10; q++) 
{ 
    Console.WriteLine(number8 + " * " + q + " = " + (number8 * q)); 
}

// ============================================================
// TASK 12. Working with an array
// ============================================================
// Create an array containing several integer numbers.
//
// Example:
// int[] numbers = { 5, 12, 3, 42, 8 };
//
// Using a loop:
// 1. Print every element of the array.
// 2. Calculate the sum of all elements.
// 3. Find the largest number.
//
// Do not use LINQ.
//
// Goal:
// - arrays
// - Length
// - loops
// - accessing elements by index

int[] numbers = { 5, 12, 3, 42, 8 }; 
int summm = 0; 
int largestt = numbers[0]; 
for (int i = 0; i < numbers.Length; i++) 
{ 
    Console.WriteLine(numbers[i]); 
    summm = summm + numbers[i]; 
    if (numbers[i] > largestt) 
    { 
        largestt = numbers[i]; 
    } 
}
Console.WriteLine("Sum: " + summm); Console.WriteLine("Largest number: " + largestt);

// ============================================================
// TASK 13. Count vowels
// ============================================================
// Ask the user to enter a text string.
//
// Count how many vowels are inside the string.
//
// For simplicity, count only:
// a, e, i, o, u
//
// Try to support uppercase letters as well:
// A, E, I, O, U
//
// Example:
// Input: Hello
// Output: Number of vowels: 2
//
// Goal:
// - string
// - char
// - foreach loop
// - logical conditions
// - ToLower()
Console.Write("Enter text: "); 
string text = Console.ReadLine().ToLower(); 
int vowelCount = 0; 
foreach (char letter in text) { 
    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') 
    { 
        vowelCount++; 
    } 
}
Console.WriteLine("Number of vowels: " + vowelCount);

// ============================================================
// TASK 14. Create your own method
// ============================================================
// Create the following method:
//
// static int Square(int number)
//
// The method should receive an integer
// and return the square of that number.
//
// In Main:
// 1. Ask the user to enter a number.
// 2. Pass the number to the Square method.
// 3. Print the result.
//
// Example:
// Input: 7
// Output: 49
//
// Goal:
// - methods
// - parameters
// - return
// - calling methods

static int Square(int numberr) 
{ 
    return numberr * numberr; 
}
Console.Write("Enter a number: "); 
int numberrr = int.Parse(Console.ReadLine()); 
int result = Square(numberrr); 
Console.WriteLine("Result: " + result);

// ============================================================
// TASK 15. Guess the number game
// ============================================================
// The computer should generate a random number
// between 1 and 100.
//
// The user repeatedly enters numbers
// trying to guess the correct number.
//
// After every attempt:
//
// If the user's number is too small:
// print "The secret number is higher."
//
// If the user's number is too large:
// print "The secret number is lower."
//
// If the user guesses correctly:
// print "Correct!"
//
// The game should continue until
// the user guesses the number.
//
// Additionally:
// Count how many attempts the user needed
// and print the number of attempts after they win.
//
// Use Random to generate the secret number.
//
// Goal:
// - Random
// - while loop
// - if / else
// - attempt counter
// - combining several basic C# concepts

Random random = new Random();

int secretNumber = random.Next(1, 101);
int guess = 0;
int attempts = 0;

while (guess != secretNumber)
{
    Console.WriteLine("Enter your guess");
    guess = int.Parse(Console.ReadLine());
    if (guess < secretNumber)
    {
        Console.WriteLine("Number is higher.");
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Number is lower.");
    }
}
Console.WriteLine("Correct!");