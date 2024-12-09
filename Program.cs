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


// ***************Dice Game Start******************
// Random dice= new Random();
// int roll1= dice.Next(1,7);
// int roll2 = dice.Next(1,7);
// int roll3 = dice.Next(1,7);

// int total= roll1 + roll2 + roll3;
// Console.WriteLine($"Dice Roll :{roll1} + {roll2} + {roll3} = {total}");

// if((roll1==roll2)||(roll2==roll3)||(roll1==roll3))
// {
//     if((roll1==roll2)&&(roll1==roll3))
//     {
//     Console.WriteLine("Yo get +6 bonus");
//     total+=6;
//     }
//     else
//     {
//     Console.WriteLine("You have bonus +2");
//     total+=2;
//     }
// }
// if(total>=15){
//     Console.WriteLine("You win");
// }
// else 
// {
//     Console.WriteLine("You Loose");
// }
//***************Dice game end**************



string[] fradullentOrders= new string[3];

fradullentOrders[0]= "A123";
fradullentOrders[1]="B123";
fradullentOrders[2]="C123";
//fradullentOrders[3] = "D123"; // Index  was outside the bonds 
Console.WriteLine(fradullentOrders[0]);
Console.WriteLine(fradullentOrders[1]);
Console.WriteLine(fradullentOrders[2]);


