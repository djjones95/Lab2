// See https://aka.ms/new-console-template for more information


//Here I asked user for two numbers to add together
int num1;
int num2;
Console.WriteLine("Hello! I would like to add two numbers together for you! \nPlease enter your first number:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your second number:");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 + " + " + num2 + " = " + Add(num1, num2));

//Method for adding 2 integers together
int Add(int num1, int num2)
{
    int sum;
    sum = num1 + num2;
    return sum;
}

//End Question 1

//Question 2

Console.WriteLine("Enter another number, any will do!:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now enter a number that represents how many times you would like to multiply your previous number:");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multiply(num1, num2));

//Method for multiplication table
string Multiply(int num1, int num2)
{
    int product;
    string output = "";
    for(int i = 1; i <= num2; i++)
    {
        product = num1 * i;
        output += num1 + " * " + i + " = " + product + "\n";
    }
    return output;
}