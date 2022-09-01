// See https://aka.ms/new-console-template for more information


//Here I added two numbers together
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
