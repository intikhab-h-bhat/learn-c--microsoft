// See https://aka.ms/new-console-template for more information
// Random dice= new Random();

// int roll=dice.Next();
// int roll1= dice.Next(1,7);
// int roll2= dice.Next(9);

// Console.WriteLine($"First Roll: {roll}");
// Console.WriteLine($"Second Roll: {roll1}");

// Console.WriteLine($"Third Roll: {roll2}");


// int firstValue = 500;
// int secondValue = 600;
// int largerValue=Math.Max(firstValue,secondValue);

// Console.WriteLine(largerValue);

Random dice= new Random();
int roll1= dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total= roll1 + roll2 + roll3;
Console.WriteLine($"Dice Roll :{roll1} + {roll2} + {roll3} = {total}");

if(total>14){
    Console.WriteLine("You win");
}
else if(total<15)
{
    Console.WriteLine("You Loose");
}


