// See https://aka.ms/new-console-template for more information
int soda = 100;
int chips = 40;
int candy = 60;
int resoda = 40;
int rechips = 20;
int recandy = 40;
int input;

Console.WriteLine("How many sodas have been sold today? " + soda + " in stock");
input = int.Parse(Console.ReadLine());

if (input <= 100)
{
    soda = soda - input;
    Console.WriteLine("There are " + soda + " sodas left.");
} else if (input > 100)
{
    Console.WriteLine("Too high. Stock not adjusted");
}

Console.WriteLine("How many chips have been sold today? " + chips + " in stock");
input = int.Parse(Console.ReadLine());

if (input <= 40)
{
    chips = chips - input;
    Console.WriteLine("There are " + chips + " chips left.");
}
else if (input > 40)
{
    Console.WriteLine("Too high. Stock not adjusted");
}

Console.WriteLine("How many candy have been sold today? " + candy + " in stock");
input = int.Parse(Console.ReadLine());

if (input <= 60)
{
    candy = candy - input;
    Console.WriteLine("There is " + candy + " candies left.");
}
else if (input > 60)
{
    Console.WriteLine("Too high. Stock not adjusted");
}

Console.WriteLine("The following will need to be restocked.");

if (soda <= resoda)
{
    Console.WriteLine("Sodas need to be restocked");
}
if (chips <= rechips)
{
    Console.WriteLine("Chips need to be restocked");
}
if (candy <= recandy)
{
    Console.WriteLine("Candy need to be restocked");
}

Console.WriteLine("Thank you!");