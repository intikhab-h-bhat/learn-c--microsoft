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



using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

//string[] fradullentOrders= new string[3];

//fradullentOrders[0]= "A123";
//fradullentOrders[1]="B123";
//fradullentOrders[2]="C123";
//fradullentOrders[3] = "D123"; // Index  was outside the bonds 
// Console.WriteLine(fradullentOrders[0]);
// Console.WriteLine(fradullentOrders[1]);
// Console.WriteLine(fradullentOrders[2]);

// string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//************foreach loop to itterate through array elements
// string[] names={"Hello","How","Are","You"};

// foreach(string name in names){
//     Console.WriteLine(name);
// }
// int[] inventory=new int[] { 200, 450,700,175,250};

// int sum=0;
// int bin=0;
// foreach(int items in inventory){

//     sum=sum+items;
//     bin++;
//     Console.WriteLine($"Bin {bin}={items} items (Running Total {sum})");
// }
//  Console.WriteLine(sum);


//*************** code chalange***************

// string[] fradulentIds=["B123","c234","A345","C15","B177","G3003","C235","B179"];

// foreach(string fid in fradulentIds){
//     if(fid.StartsWith("B")){
//     Console.WriteLine(fid);
//     }
// }

//***************Code comments****
// Random random = new Random();
// string[] orderIDs = new string[5];
// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into a char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;
// }
// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }
/*
converts the string to array and 
count the ocuurance of character o and then 
convert back  to string and then prints the output
*/
// string str = "The quick brown fox jumps over the lazy dog.";
// // convert the message into a char array
// char[] charMessage = str.ToCharArray();
// Array.Reverse(charMessage);

// int x = 0;
// // count the o's
// foreach (char i in charMessage)
//  { 
//     if (i == 'o')
//      {
//          x++;
//      } 
//  }
// // convert it back to a string
// string new_message = new String(charMessage);
// // print it out
// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appears {x} times.");
int currentAssignment=5;

string[] studentNames=new string[]{"Mohammad","Basil","Huda","Zeenat"};

int[] mohammadScores=[90,80,95,75,65];
int[] basilScores=[95,80,85,65,65];
int[] hudaScores=[65,70,85,95,60];
int[] zeenatScores=[90,80,85,65,95];


int basilSum=0;
int hudaSum=0;
int zeenatSum=0;


decimal basilFinalScore;
decimal hudaFinalScore;
decimal zeenatFinalScore;

foreach(string studentName in studentNames){

    if(studentName.Equals("Mohammad"))
    {
        int mohamadSum=0;
        decimal mohamadFinalScore;

        foreach(int score in mohammadScores)
        {
            mohamadSum += score;
        }   

        mohamadFinalScore=(decimal)mohamadSum/currentAssignment;
        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine($"{studentName}\t\t{mohamadFinalScore}\tA");
    }
}



