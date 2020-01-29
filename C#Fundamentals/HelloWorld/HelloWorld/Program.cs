using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Microsoft.Win32.SafeHandles;

namespace HelloWorld
{
    class Program
    {
        
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        public enum ImageOriatation
        {
            Landscape,
            Prtrait
        }

        static void Main(string[] args)
        {
            

            #region Polymorphism Third Pillar of OOP

            // poly = many, morph = form,  Polymorphism = many forms...

            //var shape = new List<Shape>();

            //shape.Add(new Circle());
            //shape.Add(new Triangle());
            //shape.Add(new Rectangle());

            //var canvas = new Canvas();
            //canvas.DrawShap(shape);

            #endregion


            #region Inheritance - Second Pillar of OOP

            // Inheritance - Second Pillar of OOP - EXercise

            //var stack = new stack();
            //while (true)
            //{
            //    Console.Clear();

            //    Console.WriteLine("\nStack MENU(size -- 10)");
            //    Console.WriteLine("1. Add an element");
            //    Console.WriteLine("2. See the Top element.");
            //    Console.WriteLine("3. Remove top element.");
            //    Console.WriteLine("4. Display stack elements.");
            //    Console.WriteLine("5. Exit");
            //    Console.Write("Select your choice: ");

            //    int choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter an Element : ");
            //            stack.Push(Console.ReadLine());
            //            break;

            //        case 2:
            //            Console.WriteLine("Top item is:  {0}", stack.Peek());
            //            break;

            //        case 3:
            //            Console.WriteLine("Element removed {0}", stack.Pop());
            //            break;

            //        case 4: stack.Display();
            //            break;

            //        case 5: System.Environment.Exit(1);
            //            break;
            //    }
            //    Console.ReadKey();
            //}

            // Upcasting and Downcasting

            //Image image = new Image();
            //Shape shape = image;

            //image.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(image.Width);


            //Constructors and Inheritance Vehicel and Car classes

            //var car = new Car("xyz123");


            //Composition

            //var migrate = new DbMigrator(new Logger());

            //var logger = new Logger();
            //var install = new Installer(logger);

            //migrate.Migrate();

            //install.Install();


            //Class Coupling - Inhertance

            //var text = new Text {Width = 100, Height = 50, FontName = "Arial", FontSize = 10};

            //Console.WriteLine("Text width {0} , Text height {1}", text.Width, text.Height);

            //text.Copy();



            // Ractangle Exercise

            //var rectangle = new Rectangle();

            //rectangle.AccepDetails();
            //rectangle.DisplayArea();

            // Posts Exrecise
            //var newPost = new Post
            //{
            //    Title = "Goto paris",
            //    Description = "We will go to paris on friday at 4:00 pm"

            //};

            //Console.WriteLine(newPost.Title);
            //Console.WriteLine(newPost.Description);
            //Console.WriteLine(newPost.CreationDateTime);

            //newPost.Upvoting();
            //newPost.Downvoting();

            //Console.WriteLine("Number of votes: " + newPost.DisplayVotes());



             // StopWatch Exercise

            //StopWatch sw = new StopWatch();

            //for (int i = 0; i < 2; i++)
            //{
            //    sw.Start();

            //    Thread.Sleep(1000);

            //    sw.Stop();

            //    Console.WriteLine("Duration: " + sw.GetInterval());

            //    Console.WriteLine("Press enter to run stopwatch one more time..");
            //    Console.ReadLine();
            //}
           


            #endregion

            #region CSharpFundamentals

            #region Debug

            //var numbers = new List<int> {1, 2, 3, 4, 5, 6};
            //var smallests = GetSmallests(numbers, 3);

            //foreach (var number in smallests)
            //    Console.WriteLine(number);

            #endregion

            #region Working with Files

            // File (static class), FileInfo (Instanse Class)

            //var path = @"c:\somefile.jpg";

            //File.Copy(@"c:\temp\myfile.pdf", @"d:\temp\myfile.pdf", true);
            //File.Delete(path);

            //if (File.Exists(path))
            //{
            //  //
            //}

            //var content = File.ReadAllText(path);

            //var fileInfo = new FileInfo(path);

            //fileInfo.CopyTo("");
            //fileInfo.Delete();

            //if (fileInfo.Exists)
            //{
            //    //
            //}

            // Directory (static class), DirectoryInfo (Instanse Class)

            //Directory.CreateDirectory(@"E:\temp\folder1");

            //var files = Directory.GetFiles(@"E:\Projects\Learning\C#Fundamentals\HelloWorld", "*.*", SearchOption.AllDirectories);
            //foreach (var file in files)
            //    Console.WriteLine(file);

            //var directories = Directory.GetDirectories(@"E:\Projects\Learning\C#Fundamentals", "*.*",
            //    SearchOption.AllDirectories);
            //foreach (var directory in directories)
            //    Console.WriteLine(directory);

            //var directoryInfo = new DirectoryInfo("..");

            //directoryInfo.GetFiles();
            //directoryInfo.GetDirectories();

            //if (directoryInfo.Exists)
            //{
            //    //
            //}


            //Path

            //var path = @"G:\Books\AboutDocChive.pdf";

            ////var index = path.IndexOf('.');
            ////var ext = path.Substring(index);

            ////Console.WriteLine(ext);

            //Console.WriteLine("File Extention:  "+ Path.GetExtension(path));
            //Console.WriteLine("File Name: " + Path.GetFileName(path));
            //Console.WriteLine("File Name without ext. : " + Path.GetFileNameWithoutExtension(path));
            //Console.WriteLine("File Directory: "+ Path.GetDirectoryName(path));


            // Exercise (1)

            // Write a program that reads a text file and displays the number of words.

            //var path = @"c:\Learning.txt";
            //var contents= File.ReadAllBytes(path);
            //var countWord = 0;

            //foreach (var word in contents)
            //    countWord++;

            //Console.WriteLine(countWord);

            // Execise (2)

            //Write a program that reads a text file and displays the longest word in the file.

            //var path = @"c:\Learning.txt";
            //var contents = File.ReadAllText(path);

            //string[] stringOfWords = contents.Split(' ');

            //Console.WriteLine("Text in file: " + contents);
            //Console.WriteLine("Words in text: " + contents.Split(' ').Length);

            //// This is where I am trying to solve the problem
            //var finalValue = stringOfWords.OrderByDescending(n => n.Length).First();

            //Console.WriteLine("Largest word is: " + finalValue);



            #endregion

            #region Working with Text - Exercises

            // Exercises (1)
            //Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //Work out if the numbers are consecutive. 
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            //Console.Write("Enter a few number (e.g 1-2-3-4-5)");
            //var input = Console.ReadLine();

            //var numbers = new List<int>();

            //foreach (var number in input.Split('-'))
            //    numbers.Add(Convert.ToInt32(number));

            //numbers.Sort();

            //var isConsecutive = true;

            //for (int i = 1; i < numbers.Count; i++)
            //{
            //    if (numbers[i] != numbers[i - 1] + 1)
            //    {
            //        isConsecutive = false;
            //        break;
            //    }
            //}

            //var message = isConsecutive ? "Consecutive" : "Non consecutive";
            //Console.WriteLine(message);


            // Exercise(2)

            //Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //If the user simply presses Enter, without supplying an input, exit immediately; 
            //otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.


            //Console.Write("Enter a few number (e.g 1-2-3-4-5)");
            //var input = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(input))
            //    return;

            //var numbers = new List<int>();
            //foreach (var number in input.Split('-'))
            //    numbers.Add(Convert.ToInt32(number));

            //var uniques = new List<int>();
            //var includesDuplicates = false;
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //    else
            //    {
            //        includesDuplicates = true;
            //        break;
            //    }
            //}

            //if (includesDuplicates)
            //    Console.WriteLine("Duplicate");


            // Exercise (3)
            //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
            //If the user doesn't provide any values, consider it as invalid time. 

            //Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00)");
            //var input = Console.ReadLine();

            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}
            //var component = input.Split(':');
            //if (component.Length != 2)
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}
            //try
            //{
            //    var hour = Convert.ToInt32(component[0]);
            //    var minute =  Convert.ToInt32(component[1]);
            //    if (hour > 0 && hour < 23 && minute > 0 && minute < 59)
            //        Console.WriteLine("Ok");
            //    else
            //        Console.WriteLine("Invalid Time");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid Time");
            //}


            // Exercise (4)

            // Write a program and ask the user to enter a few words separated by a space. 
            //Use the words to create a variable name with PascalCase. 
            //For example, if the user types: "number of students", display "NumberOfStudents". 
            //Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            //Console.Write("Enter a few words: ");
            //var input = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}


            //var variableName = "";

            //foreach (var word in input.Split(' '))
            //{
            //    var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            //    variableName += wordWithPascalCase;
            //}
            //Console.WriteLine(variableName);


            // Exercise (5)

            //Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
            //So, if the user enters "inadequate", the program should display 6 on the console.

            //Console.Write("Enter a word: ");
            //// Note the ToLower() here. This is used to count for both A and a. 
            //var input = Console.ReadLine().ToLower();

            //var vowels = new List<char>(new char[] {'a', 'e', 'o', 'u', 'i'});
            //var vowelsCount = 0;

            //foreach (var charchter in input)
            //{
            //    if (vowels.Contains(charchter))
            //        vowelsCount++;
            //}

            //Console.WriteLine(vowelsCount);

            //var countvowels = CountVowels(input);
            //Console.WriteLine(countvowels);


            #endregion

            #region Procedural Programming


            // Example 1

            // Write a program and ask the user to enter their name. 
            // Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

            //Console.Write("What is your name?");
            //var name = Console.ReadLine();
            //var reverse = ReversedName(name);
            //Console.WriteLine(reverse);




            // Example 2

            //Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //The list of numbers may include duplicates. 
            //Display the unique numbers that the user has entered.

            //var numbers = new List<int>();
            //while (true)
            //{
            //    Console.Write("Enter a number (or 'Quit' to exit): ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "quit")
            //        break;

            //    numbers.Add(Convert.ToInt32(input));
            //}
            ////var unique = GetUniqueNumber(numbers);
            //Console.WriteLine("uniques numbers");
            //foreach (var n in GetUniqueNumber(numbers))
            //    Console.WriteLine(n);

            #endregion

            #region StringBuilder

            //var builder = new StringBuilder();

            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 10);

            //builder.Replace('-', '+');

            //builder.Remove(0, 10);

            //builder.Insert(0, new string('-', 10));


            //builder
            //    .Append('-', 10)
            //    .AppendLine()
            //    .Append("Header")
            //    .AppendLine()
            //    .Append('-', 10)
            //    .Replace('-', '+')
            //    .Remove(0, 10)
            //    .Insert(0, new string('-', 10));

            //Console.WriteLine(builder);
            //Console.WriteLine("First Char: "+ builder[0]);

            #endregion

            #region TextSummary

            //var sentense = "this is will be a really really really really really a along text.";

            //Console.WriteLine(StringUtility.summarizeText(sentense, 25));


            #endregion

            #region WorkingWithtext

            //var fullName = "Mohamed Amer  ";
            //Console.WriteLine("Trim: '{0}' ", fullName.Trim());
            //Console.WriteLine("Upper: '{0}' ", fullName.Trim().ToUpper());

            //var index = fullName.IndexOf(' ');
            //var firstName = fullName.Substring(0, index);
            //var lastName = fullName.Substring(index + 1);

            //Console.WriteLine("FirstName: {0}" + " " + "LastName: {1}", firstName, lastName);

            //var names = fullName.Split(' ');

            //Console.WriteLine("FirstName: " + names[0]);
            //Console.WriteLine("LastName: " + names[1]);


            //Console.WriteLine(fullName.Replace("Mohamed", "Esmaiel"));

            //if (string.IsNullOrWhiteSpace(" "))
            //    Console.WriteLine("Invalid");

            //if (string.IsNullOrEmpty(" ".Trim()))
            //    Console.WriteLine("Invalid");

            //var str = "25";
            //var age = Convert.ToByte(str);
            //Console.WriteLine(age);

            //float price = 29.95f;
            //Console.WriteLine(price.ToString("c"));
            //Console.WriteLine(price.ToString("c0")); 

            #endregion

            #region DateTime, TimeSpan

            // DateTime, TimeSpan

            //var timeSpan = new TimeSpan(1, 2, 3);

            //Console.WriteLine("Minutes: " + timeSpan.Minutes);
            //Console.WriteLine("TotalMinutes: " + timeSpan.TotalMinutes);


            //Console.WriteLine("Add: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            //Console.WriteLine("Substratct: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));


            //// To String
            //Console.WriteLine("To String: " + timeSpan.ToString());

            //// Parse
            //Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); 

            #endregion

            #region Exercise of Arays & List

            // Exercise (1)

            // When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //    If no one likes your post, it doesn't display anything.
            //    If only one person likes your post, it displays: [Friend's Name] likes your post.
            //    If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            //    If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            //    Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
            //    Depending on the number of names provided, display a message based on the above pattern

            //var hlikePost = new List<string>();

            //while (true)
            //{
            //    Console.Write("enter your name (or hit enter  to exit)... ");
            //    var hlike = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(hlike))
            //        break;
            //    hlikePost.Add(hlike);

            //}

            //if (hlikePost.Count > 2)
            //    Console.WriteLine("{0}, {1} and {2} like your post", hlikePost[0], hlikePost[1], hlikePost.Count - 2);
            //else if (hlikePost.Count == 2)
            //    Console.WriteLine("{0} and {1} like your post", hlikePost[0], hlikePost[1]);
            //else if (hlikePost.Count == 1)
            //    Console.WriteLine("{0} like your post", hlikePost[0]);
            //else
            //    Console.WriteLine();


            // Exercise (2)

            // Write a program and ask the user to enter their name. 
            // Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

            //Console.Write("What is your name?");
            //var input = Console.ReadLine();

            //var names = new Char[input.Length];

            //for (int i = names.Length; i > 0; i--)
            //    names[input.Length - i] = input[i - 1];

            //var reverse = new string(names);
            //Console.WriteLine(reverse);


            // Exercise (3)

            // Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
            // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            //var numbers = new List<int>();

            // while (numbers.Count < 5)
            // {
            //     Console.Write("Enter a number...");
            //     var number = Convert.ToInt32(Console.ReadLine());

            //     if (numbers.Contains(number))
            //     {
            //         Console.WriteLine("You've previously entered " + number);
            //         continue;
            //     }
            //     numbers.Add(number);

            // }

            // numbers.Sort();

            // foreach (var n in numbers)
            //     Console.WriteLine(n);



            // Exercise (4)

            //Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //The list of numbers may include duplicates. 
            //Display the unique numbers that the user has entered.

            //var numbers = new List<int>();

            //while (true)
            //{
            //    Console.Write("Enter a number (or 'Quit' to exit): ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "quit")
            //        break;

            //    numbers.Add(Convert.ToInt32(input));

            //}

            // var uniques = new List<int>();

            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //}

            //Console.WriteLine("uniques numbers");

            //foreach (var n in uniques)
            //    Console.WriteLine(n);

            // Exercise (5)

            //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            //If the list is empty or includes less than 5 numbers, 
            //display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

            //string[] elements;
            //while (true)
            //{
            //    Console.Write("Enter a list of comma-separated numbers: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        elements = input.Split(',');
            //        if (elements.Length >= 5)
            //            break;
            //    }

            //    Console.WriteLine("Invalid List");
            //}

            //var numbers = new List<int>();
            //foreach (var number in elements)
            //    numbers.Add(Convert.ToInt32(number));

            //var smallests = new List<int>();
            //while (smallests.Count < 3)
            //{
            //    // Assume the first number is the smallest
            //    var min = numbers[0];
            //    foreach (var number in numbers)
            //    {
            //        if (number < min)
            //            min = number;
            //    }
            //    smallests.Add(min);

            //    numbers.Remove(min);
            //}

            //Console.WriteLine("The 3 smallest numbers are: ");
            //foreach (var number in smallests)
            //    Console.WriteLine(number);


            #endregion

            #region Lists

            //var numbers = new List<int>() { 1, 2, 3, 4 };

            //numbers.Add(1);

            //numbers.AddRange(new int[3] { 6, 7, 8 });

            //foreach (var n in numbers)
            //     Console.WriteLine(n);   

            //// Indexof()
            //Console.WriteLine("Effects of Indexof()");

            //Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));
            //Console.WriteLine("Count:" + numbers.Count);

            //// Remove()
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == 1)
            //        numbers.Remove(numbers[i]);
            //}

            //foreach (var n in numbers)
            //    Console.WriteLine(n); 

            //// Clear()
            //numbers.Clear();
            //Console.WriteLine("Count :"+ numbers.Count);

            // LastIndexof list  
            //var lastIndex = numbers[numbers.Count - 1];
            //Console.WriteLine(lastIndex);

            #endregion

            #region Arrays

            ////Length 
            //var number = new[] { 12, 3, 45, 7, 8, 9 };

            //Console.WriteLine("Length : " + number.Length);

            ////Index OF()
            //var index = Array.IndexOf(number, 9);

            //Console.WriteLine("Index of 9: " + index);

            ////Clear()

            //Array.Clear(number, 0, 3);

            //Console.WriteLine("Efect of clear()");

            //foreach (var n in number)
            //    Console.WriteLine(n);

            //// Copy()

            //int[] another = new int[3];
            //Array.Copy(number, another, 3);

            //Console.WriteLine("Efect of Copy()");

            //foreach (var n in another)
            //    Console.WriteLine(n);

            //// Sort()

            //Array.Sort(number);

            //Console.WriteLine("Efect of Sort()");

            //foreach (var n in number)
            //    Console.WriteLine(n);

            ////Reverse

            //Array.Reverse(number);

            //Console.WriteLine("Efect of Reverse()");

            //foreach (var n in number)
            //    Console.WriteLine(n); 

            #endregion

            #region Loops-Solutions

            // <summary>
            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            // Display the result on the console.
            // </summary>

            //Exercise(1)

            //var count = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //        count++;

            //}
            //Console.WriteLine("There are {0} number divisible by 3 between 1 to 100.", count);


            // <summary>
            // Write a program and continuously ask the user to enter a number. The loop terminates when the user 
            // enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
            // </summary>

            //Exercise(2)
            //var sum = 0;
            //while (true)
            //{
            //    Console.Write("please enter the number or (enter 'Ok' to exit): ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //        break;

            //    sum += Convert.ToInt32(input);

            //}
            //Console.WriteLine("sum of all the number: "+ sum);


            // <summary>
            // Write a program which takes a single argument from the console, computes the factorial and prints the 
            // value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            // and display it as 5! = 120.
            // </summary>

            //Exercise(3)

            //Console.Write("Enter the number: ");
            //var number  = Convert.ToInt32(Console.ReadLine());

            //var factorial = 1;
            //for (int i = 1; i <= number; i++)
            //    factorial *= i;

            //Console.WriteLine("{0}! = {1}" , number, factorial );


            // <summary>
            // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            // If the user guesses the number, display “You won". Otherwise, display “You lost".
            // </summary>
            //Exercise(4)

            //var number = new Random().Next(1, 10);

            //Console.Write("Secret number is: "+ number);
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.Write("Guess the secret number: ");
            //    var guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess == number)
            //    {
            //        Console.WriteLine("You Won!");
            //        return;
            //    }

            //}
            //Console.WriteLine("You Lost!");


            // <summary>
            // Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            // numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            // display 8 on the console.
            // </summary>
            //Exercise(5)

            //Console.Write("Enter a series of numbers separated by comma: ");
            //var input = Console.ReadLine();

            //var numbers = input.Split(',');
            //var max = Convert.ToInt32(numbers[0]);

            //foreach (var str in numbers)
            //{
            //    var number = Convert.ToInt32(str);
            //    if (number > max)
            //        max = number;
            //}

            //Console.WriteLine("Max is " + max);

            #endregion

            #region Conditionals

            // Exrecise (1)

            //    Console.Write("Please enter number between 1 to 10: ");
            //    var input = Convert.ToInt32(Console.ReadLine());

            //    if (input > 0 && input <= 10)
            //          Console.WriteLine("Valid");
            //    else
            //          Console.WriteLine("Not Valid");

            // Exrecise (2) 

            //Console.Write("please enter the first number... ");
            //var number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("please enter the scound number...");
            //var number2 = Convert.ToInt32(Console.ReadLine());

            //var max = number1 > number2 ? number1 : number2;

            //Console.WriteLine(max);

            // Exrecise (3)

            //Console.Write("please enter the image width... ");
            //var imgWidth = Convert.ToInt32(Console.ReadLine());

            //Console.Write("please enter the image height...");
            //var imgHeight = Convert.ToInt32(Console.ReadLine());


            //var oriatation = imgWidth > imgHeight ? ImageOriatation.Landscape : ImageOriatation.Prtrait;
            //Console.WriteLine("Image Oraintion is "+ oriatation );

            // Exrecise (4)

            //Console.Write("Please enter Speed Limit: ");
            //var speedlimit = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter Speed of the car: ");
            //var carSpeed = Convert.ToInt32(Console.ReadLine());

            //if(carSpeed < speedlimit)
            //    Console.WriteLine("Ok");
            //else
            //{
            //    const int kmPerDemeritPoint = 5;
            //    var demeritPoints = (carSpeed - speedlimit) / kmPerDemeritPoint;
            //    if(demeritPoints > 12)
            //        Console.WriteLine("License Suspended");
            //    else
            //        Console.WriteLine("Demerit points: " + demeritPoints);

            //}


            #endregion

            #region MyDemoWork


            //var random = new Random();

            //for (int i = 0; i < 10; i++)
            //     Console.Write((char)random.Next(97, 122));
            //  Console.WriteLine();

            //var random = new Random();

            //const int passwordLength = 10;

            //var buffer = new char[passwordLength];

            //for (int i = 0; i < passwordLength; i++)
            //     buffer[i] = (char) ('a' + random.Next(0, 26));

            //var password = new string(buffer);

            //Console.WriteLine(password);


            //while (true)
            //{
            //    Console.Write("Type your name:  ");
            //    var input = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(input))
            //    break;

            //    Console.WriteLine("@Echo: " + input);
            //}

            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue;
            //    }
            //    break;
            //}



            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //for (int j = 0; j <= 10; j++)
            //{
            //    if (j % 2 == 0)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

            //string name = "mohamed amer";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var charachter in name)
            //{
            //    Console.WriteLine(charachter);
            //}

            //var numbers = new int[] {1, 2, 3, 4};

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number); 
            //}


            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //var season = Season.Autumn;

            //switch (season)
            //{
            //    case Season.Autumn:
            //    case Season.Winter:
            //        Console.WriteLine("we've got pormotion");
            //        break;

            //    case Season.Summer:
            //        Console.WriteLine("It's a good time to goto beach");
            //        break;

            //    default:
            //        Console.WriteLine("I don't understand this season");
            //        break;


            //}

            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //    Console.WriteLine("It is morning");
            //else if (hour >= 12 && hour < 18)
            //    Console.WriteLine("It is afternoon");
            //else
            //    Console.WriteLine("It is evening");

            //bool isGoldCustomer = true;

            //float price = (isGoldCustomer) ? 19.85f : 29.95f;

            //Console.WriteLine(price);


            //var number = 1;
            //Increment(number);
            //Console.WriteLine(number);

            //var person = new Person() {Age = 20};

            //MakeOld(person);

            //Console.WriteLine(person.Age);



            //var a = 10;
            //var b = a;
            //b++;

            //Console.WriteLine(string.Format("a: {0} b: {1}", a, b));

            //var array1 = new int [3] {1, 2, 3};

            //var array2 = array1;

            //array2[0] = 0;

            //Console.WriteLine(string.Format("array1[0] {0} array2[0] {1}", array1[0], array2[0]));

            //var method = ShippingMethod.Express;

            //Console.WriteLine((int)method);

            //var methodId = 3;

            //Console.WriteLine((ShippingMethod) methodId);

            //Console.WriteLine(method);

            //var methodName = "Express";

            //var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            //Console.WriteLine(shippingMethod);

            //var mohamed = new Person();
            //mohamed.FirstName = "Mohamed";
            //mohamed.LastName = "Aamer";

            //mohamed.Introduce();

            //Calculator calc = new Calculator();

            //var result = calc.Add(5, 6);
            //Console.WriteLine(result);

            //var numbers = new int[3];

            //numbers[0] = 1;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flage = new bool[3];
            //flage[0] = true;

            //Console.WriteLine(flage[0]);
            //Console.WriteLine(flage[1]);
            //Console.WriteLine(flage[2]);

            //            var firstname = "Mohamed";
            //            var lastname = "Ahmed";

            //            var fullName = firstname + " " + lastname;
            //            var formattedName = string.Format("My name is {0} {1}", firstname, lastname);

            //            var names = new string[3] {"mohamed","amer","ali"};
            //            var joinName = string.Join(",", names);

            //            var text = @"Hi Join
            //Please look to this pahtes
            //c:\folder1\folder2
            //c:\folder3\folder4";

            //            Console.WriteLine(text);

            #endregion


            #endregion

            #region Intermediate-Classes-Interfaces & OOP

            #region Indexer

            //var cookie = new HttpCookie();
            //cookie["Name"] = "Mohamed";

            //Console.WriteLine(cookie["Name"]);

            #endregion

            #region Properiies

            //var person = new Person();
            //person.Birthdate = new DateTime(1983, 6, 8);
            //Console.WriteLine(person.Age);


            // with set private
            //var person = new Person(new DateTime(1983, 6, 8));
            //Console.WriteLine(person.Age);


            #endregion

            #region AccessModifiers

            // encapsulation - information hiding ---- private 
            //var person = new Person();

            //person.SetBirthdate(new DateTime(1983, 1, 1));

            //Console.WriteLine(person.GetBirthdate());



            #endregion

            #region Methods

            // Use Params

            //Use Points

            // use out

            //try
            //{
            //    var num = int.Parse("abc");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Conversion failed");
            //}


            //int number;
            //var result = int.TryParse("abc", out number);
            //if(result)
            //    Console.WriteLine(number);
            //else
            //    Console.WriteLine("Conversion failed");


            #endregion

            #region Classes

            //with create object
            //var person = new Person();
            //person.FirstName = "Mohamed";
            //person.Introduce("Ali");

            // with instanse class - static member
            //var person = Person.Parse("Mohamed");
            //person.Introduce("Ali");


            #endregion

            #region Constructors

            //var customer = new Customer(1,"Mohamed amer");
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            //var order = new Order();
            //customer.Orders.Add(order);

            // object initializer, not need to create constructor
            //var person = new Person
            //{
            //    FirstName = "Mohamed",
            //    LastName = "Amer"
            //};
            //Console.WriteLine(person.FirstName);

            #endregion

            #endregion

        }

        static void UseParams()
        {
            var calculate = new Calculator();
            Console.WriteLine(calculate.Add(1, 2));
            Console.WriteLine(calculate.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calculate.Add(1, 2, 5, 6, 7, 8));
            Console.WriteLine(calculate.Add(new int[] { 1, 2, 3, 4, 5 }));

        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);

                point.Move(null);
                Console.WriteLine("Point is at : {0}, {1} ", point.X, point.Y);

                point.Move(300, 400);
                Console.WriteLine("Point is at : {0}, {1} ", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");

            }
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if(list == null)
                throw new  ArgumentNullException("list");

            if(count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 0 and the number of elements in list.");
            var buffer = new List<int>(list);

            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }

        public static string ReversedName(string name)
        {
            var array = new Char[name.Length];

            for (int i = array.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
        }

        public static List<int> GetUniqueNumber(List<int> numbers)
        {
            var uniques = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques;
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            // person.Age += 10;
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        public static bool IsConsecutiveList(List<int> list)
        {
            // Note that I've copied the list to a new array because I didn't want callign Sort()
            // impact the argument of this method. Caller of this method only expects a true/false answer 
            // as a result of this call. So, this method should not have a side-effect.
            var numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        public static bool ContainsDuplicates(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        public static bool IsValidTime(string time)
        {
            if (String.IsNullOrWhiteSpace(time))
                return false;

            var components = time.Split(':');
            if (components.Length != 2)
                return false;

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                return (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59);
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>
        public static string GetVariableName(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return "";

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            return variableName;
        }


        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>
        public static int CountVowels(string word)
        {
            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;

            // Note the ToLower() here. This is used to count for both A and a. 
            foreach (var character in word.ToLower())
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            return vowelsCount;
        }
    }
}