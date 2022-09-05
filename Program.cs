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
//Asking for 2 numbers from user
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

//Question 3
//sbyte
Console.WriteLine("sbyte has a size in memory of " + sizeof(sbyte) + " byte and can have a min of " + sbyte.MinValue + " and a max of " + sbyte.MaxValue);
//byte
Console.WriteLine("byte has a size in memory of " + sizeof(byte) + " byte and can have a min of " + byte.MinValue + " and a max of " + byte.MaxValue);
//short
Console.WriteLine("short has a size in memory of " + sizeof(short) + " bytes and can have a min of " + short.MinValue + " and a max of " + short.MaxValue);
//ushort
Console.WriteLine("ushort has a size in memory of " + sizeof(ushort) + " bytes and can have a min of " + ushort.MinValue + " and a max of " + ushort.MaxValue);
//int
Console.WriteLine("int has a size in memory of " + sizeof(int) + " bytes and can have a min of " + int.MinValue + " and a max of " + int.MaxValue);
//uint
Console.WriteLine("uint has a size in memory of " + sizeof(uint) + " bytes and can have a min of " + uint.MinValue + " and a max of " + uint.MaxValue);
//long
Console.WriteLine("long has a size in memory of " + sizeof(long) + " bytes and can have a min of " + long.MinValue + " and a max of " + long.MaxValue);
//ulong
Console.WriteLine("ulong has a size in memory of " + sizeof(ulong) + " bytes and can have a min of " + ulong.MinValue + " and a max of " + ulong.MaxValue);
//float
Console.WriteLine("float has a size in memory of " + sizeof(float) + " bytes and can have a min of " + float.MinValue + " and a max of " + float.MaxValue);
//double
Console.WriteLine("double has a size in memory of " + sizeof(double) + " bytes and can have a min of " + double.MinValue + " and a max of " + double.MaxValue);
//decimal
Console.WriteLine("decimal has a size in memory of " + sizeof(decimal) + " bytes and can have a min of " + decimal.MinValue + " and a max of " + decimal.MaxValue);

//Question 4 Calculator
bool calc = true;
string safeword = "esc";
while(calc == true)
{
    Console.WriteLine("Enter a number to continue calculations, or type esc to exit: ");

    var number1 = Console.ReadLine();

    if(number1.ToString().Equals(safeword))
    {
        calc = false;
    }
    else
    {
        Console.WriteLine("Please choose one +,-,/,*,%");
        string choice = Console.ReadLine();
        //add
        if(choice.Equals("+"))
        {
            Console.WriteLine("What would you like to add to " + number1);
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + " + " + number2 + " = " + Add(Convert.ToInt32(number1), number2));
        }
        else if(choice.Equals("-"))
        {
            Console.WriteLine("What would you like to subtract from " + number1);
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + " - " + number2 + " = " + Subtract(Convert.ToInt32(number1), number2));
        }
        else if(choice.Equals("/"))
        {
            Console.WriteLine("What would you like to divide " + number1 + " by");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + " / " + number2 + " = " + Divide(Convert.ToInt32(number1), number2));
        }
        else if(choice.Equals("%"))
        {
            Console.WriteLine("What number do you choose to perform the modulus operation with on " + number1);
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + " % " + number2 + " = " + Modulus(Convert.ToInt32(number1), number2));
        }
        else if(choice.Equals("*"))
        {
            Console.WriteLine("What would you like to multiply " + number1 + " by");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + " * " + number2 + " = " + Multiplication(Convert.ToInt32(number1), number2));
        }
        else
        {
            Console.WriteLine("Invalid entry, will exit now!");
            calc = false;
        }

    }

  
}

//Subtract method
int Subtract(int num1, int num2)
{
    int diff;
    diff = num1 - num2;
    return diff;
}

//Divide method
double Divide(int num1, int num2)
{
    double div;
    div = num1 / num2;
    return div;
}

//Modulus method
double Modulus(int num1, int num2)
{
    double mod;
    mod = num1 % num2;
    return mod;
}

//Multiplication method
int Multiplication(int num1, int num2)
{
    int prod;
    prod = num1 * num2;
    return prod;
}