
using Calculator.Classes;



// Get user input for the two numbers
Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());


Addition add = new Addition();
double sum = add.Perform(num1, num2);
Console.WriteLine("The sum is: " + sum);

Subtraction sub = new Subtraction();
double diff=sub.Perform(num1, num2);

Console.WriteLine("The Diff is : " + diff);

Multiplication prod = new Multiplication();
double product = prod.Perform(num1, num2);

Console.WriteLine("The Diff is : " + prod);



