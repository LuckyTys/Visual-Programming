﻿// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Good Morning, World!");
Console.WriteLine("My name is Tuyishime Lucky");

int result = 5 + 3;
Console.WriteLine("The Result of the arthimetic operation is: " + result);


Console.WriteLine("This is the second line of text");
Console.WriteLine("This is the Third line of the text");

// added a string variable to hold my name and use it in console.WriteLine
string myname = "Lucky";
Console.WriteLine("Hello " + myname);

//Combined Two strings
string myname1 = " Tuyishime";
string myname2 = " Lucky";
Console.WriteLine("My name is" +  myname1 +  myname2);



//Printing number
int number =  1;
Console.WriteLine("My Favourite number is"+ number);

DateTime currentDate= DateTime.Now;
Console.WriteLine("Current Date:" + currentDate.ToShortDateString());
Console.ReadLine();
