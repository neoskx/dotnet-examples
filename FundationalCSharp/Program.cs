// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// if (roll1 == roll2 && roll2 == roll3)
// {
//   total += 6;
// }
// else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
// {
//   total += 2;
// }


// if (total >= 16)
// {
//   Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//   Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//   Console.WriteLine("You win a trip for two!");
// }
// else
// {
//   Console.WriteLine("You win a kitten!");
// }


// Console.WriteLine($"roll1: {roll1}, roll2: {roll2}, roll3: {roll3}, total: {total}");


// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage;

// if (daysUntilExpiration <= 10)
// {
//   if (daysUntilExpiration <= 0)
//   {
//     Console.WriteLine("Your subscription has expired.");
//   }
//   else if (daysUntilExpiration <= 1)
//   {
//     discountPercentage = 20;
//     Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
//   }
//   else if (daysUntilExpiration <= 5)
//   {
//     discountPercentage = 10;
//     Console.WriteLine($"Your subscription expires within {daysUntilExpiration} days!\nRenew now and save {discountPercentage}%!");
//   }
//   else
//   {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
//   }
// }

// Console.WriteLine($"daysUntilExpiration: {daysUntilExpiration}");

// ======== Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
// foreach (string id in fraudulentOrderIDs)
// {
//   Console.WriteLine(id);
// }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//   sum += items;
//   bin++;
//   Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"sum: {sum}");

// string[] fraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
// foreach (string id in fraudulentOrderIDs)
// {
//   if (id.StartsWith('B'))
//   {
//     Console.WriteLine($"The id - {id} starts with 'B'!");
//   }
// }


// ======= Create Readable Code with Conventions, Whitespace, and Comments in C# 
// string originalMessage = "The quick brown fox jumps over the lazy dog.";

// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);

// int letterCount = 0;

// foreach (char letter in message)
// {
//   if (letter == 'o')
//   {
//     letterCount++;
//   }
// }

// string newMessage = new String(message);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

// ======= Develop foreach and if-elseif-else Structures to Process Array Data in C#
// // initialize variables - graded assignments 
// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
// int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
// int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
// int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
// int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// int[][] studentScores = new int[][] { sophiaScores, andrewScores, emmaScores, loganScores, beckyScores, chrisScores, ericScores, gregorScores };
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// Console.WriteLine("Student\t\tGrade\n");
// int index = 0;
// foreach (int[] studentScore in studentScores)
// {
//   int currentAssignments = 0;
//   int studentSum = 0;
//   decimal scoreResult;
//   string currentStudentLetterGrade = "";
//   foreach (int score in studentScore)
//   {
//     // add the exam score to the sum
//     studentSum += score;
//     currentAssignments++;
//   }
//   // Console.WriteLine("currentAssignments: " + currentAssignments);
//   scoreResult = (decimal)studentSum / currentAssignments;

//   if (scoreResult >= 97)
//   {
//     currentStudentLetterGrade = "A+";
//   }
//   else if (scoreResult >= 93)
//   {
//     currentStudentLetterGrade = "A";
//   }
//   else if (scoreResult >= 90)
//   {
//     currentStudentLetterGrade = "A-";
//   }
//   else if (scoreResult >= 87)
//   {
//     currentStudentLetterGrade = "B+";
//   }
//   else if (scoreResult >= 83)
//   {
//     currentStudentLetterGrade = "B";
//   }
//   else if (scoreResult >= 80)
//   {
//     currentStudentLetterGrade = "B-";
//   }
//   else if (scoreResult >= 77)
//   {
//     currentStudentLetterGrade = "C+";
//   }
//   else if (scoreResult >= 73)
//   {
//     currentStudentLetterGrade = "C";
//   }
//   else if (scoreResult >= 70)
//   {
//     currentStudentLetterGrade = "C-";
//   }
//   else if (scoreResult >= 67)
//   {
//     currentStudentLetterGrade = "D+";
//   }
//   else if (scoreResult >= 63)
//   {
//     currentStudentLetterGrade = "D";
//   }
//   else if (scoreResult >= 60)
//   {
//     currentStudentLetterGrade = "D-";
//   }
//   else
//   {
//     currentStudentLetterGrade = "F";
//   }

//   Console.WriteLine($"{studentNames[index++]}:\t\t{scoreResult:F2}\t{currentStudentLetterGrade}");
// }

// ======= Develop foreach and if-elseif-else Structures to Process Array Data in C# 
// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
// int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
// int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
// int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
// int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// int[][] studentScores = new int[][] { sophiaScores, andrewScores, emmaScores, loganScores, beckyScores, chrisScores, ericScores, gregorScores };
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");
// int index = 0;
// foreach (int[] studentScore in studentScores)
// {
//   int currentAssignments = 0;
//   int studentSum = 0;
//   decimal scoreResult;
//   string currentStudentLetterGrade = "";
//   foreach (int score in studentScore)
//   {
//     // add the exam score to the sum
//     studentSum += score;
//     currentAssignments++;
//   }
//   // Console.WriteLine("currentAssignments: " + currentAssignments);
//   scoreResult = (decimal)studentSum / currentAssignments;

//   if (scoreResult >= 97)
//   {
//     currentStudentLetterGrade = "A+";
//   }
//   else if (scoreResult >= 93)
//   {
//     currentStudentLetterGrade = "A";
//   }
//   else if (scoreResult >= 90)
//   {
//     currentStudentLetterGrade = "A-";
//   }
//   else if (scoreResult >= 87)
//   {
//     currentStudentLetterGrade = "B+";
//   }
//   else if (scoreResult >= 83)
//   {
//     currentStudentLetterGrade = "B";
//   }
//   else if (scoreResult >= 80)
//   {
//     currentStudentLetterGrade = "B-";
//   }
//   else if (scoreResult >= 77)
//   {
//     currentStudentLetterGrade = "C+";
//   }
//   else if (scoreResult >= 73)
//   {
//     currentStudentLetterGrade = "C";
//   }
//   else if (scoreResult >= 70)
//   {
//     currentStudentLetterGrade = "C-";
//   }
//   else if (scoreResult >= 67)
//   {
//     currentStudentLetterGrade = "D+";
//   }
//   else if (scoreResult >= 63)
//   {
//     currentStudentLetterGrade = "D";
//   }
//   else if (scoreResult >= 60)
//   {
//     currentStudentLetterGrade = "D-";
//   }
//   else
//   {
//     currentStudentLetterGrade = "F";
//   }

//   Console.WriteLine($"{studentNames[index++]}\t\t{0}\t\t{scoreResult:F2}\t{currentStudentLetterGrade}\t{0} ({0} pts)");
// }


// ======= Evaluate Boolean Expressions to Make Decisions in C# 
// Random coin = new Random();
// int value = coin.Next(0, 2);
// string coinValue = value == 0 ? "heads" : "tails";
// // 0: heads, 1: tails
// Console.WriteLine($"{coinValue}");

// string permission = "Manager";
// int level = 55;

// if (permission.Contains("Admin"))
// {
//   Console.WriteLine("Welcome, " + (level > 55 ? "Super " : " ") + "Admin user.");
// }
// else if (permission.Contains("Manager") && level >= 20)
// {
//   Console.WriteLine("Contact an Admin for access.");
// }
// else
// {
//   Console.WriteLine("You do not have sufficient privileges.");
// }


// ======= Control Variable Scope and Logic Using Code Blocks in C#
// int value;

// if (true)
// {
//   value = 10;
//   Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");

// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {

//   total += number;

//   if (number == 42)
//   {
//     found = true;
//   }

// }

// if (found)
// {
//   Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");

//========= Branch the flow of code using the switch-case construct in C#
// Example 1
// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//   case 100:
//     title = "Junior Associate";
//     break;
//   case 200:
//     title = "Senior Associate";
//     break;
//   case 300:
//     title = "Manager";
//     break;
//   case 400:
//     title = "Senior Manager";
//     break;
//   default:
//     title = "Associate";
//     break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// example 2
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";
// switch (product[0])
// {
//   case "01":
//     type = "Sweat shirt";
//     break;
//   case "02":
//     type = "T-Shirt";
//     break;
//   case "03":
//     type = "Sweat pants";
//     break;
//   default:
//     type = "Other";
//     break;
// }

// switch (product[1])
// {
//   case "BL":
//     color = "Black";
//     break;
//   case "MN":
//     color = "Maroon";
//     break;
//   default:
//     color = "White";
//     break;
// }

// switch (product[2])
// {
//   case "S":
//     size = "Small";
//     break;
//   case "M":
//     size = "Medium";
//     break;
//   case "L":
//     size = "Large";
//     break;
//   default:
//     size = "One Size Fits All";
//     break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");


//========= Iterate through a code block using for statement in C#
// for (int i = 1; i <= 100; i++)
// {
//   if (i % 3 == 0 && i % 5 == 0)
//   {
//     Console.WriteLine($"{i} - FizzBuzz");
//   }
//   else if (i % 3 == 0)
//   {
//     Console.WriteLine($"{i} - Fizz");
//   }
//   else if (i % 5 == 0)
//   {
//     Console.WriteLine($"{i} - Buzz");
//   }
//   else
//   {
//     Console.WriteLine($"{i}");
//   }
// }


//========= Add looping logic to your code using the do-while and while statements in C#
// Random random = new Random();
// int current = 0;

// do
// {
//   current = random.Next(1, 11);
//   Console.WriteLine(current);
// } while (current != 7);


// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//   readResult = Console.ReadLine();
// } while (readResult == null);


//========== Choose the correct data type in your C# code

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


//=========== Convert data types using casting and conversion techniques in C#
// string[] values = { "12.3", "45", "0.0", "ABC", "11", "DEF" };

// float total = 0;
// string message = "";
// foreach (string value in values)
// {
//   float result = 0;
//   if (float.TryParse(value, out result))
//   {
//     total += result;
//   }
//   else
//   {
//     message += value;
//   }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {(int)(value1 / value2)}");

// // Your code here to set result2
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {value2 / (decimal)value3}");

// // Your code here to set result3
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {(float)value1 / value3}");

//========= Perform operations on arrays using helper methods in C#
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//   Console.WriteLine(item);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] words = pangram.Split(" ");
// for (int i = 0; i < words.Length; i++)
// {
//   char[] wordChars = words[i].ToCharArray();
//   Array.Reverse(wordChars);
//   words[i] = String.Join("", wordChars);
//   // Console.WriteLine(words[i]);
// }

// Console.WriteLine($"{String.Join(" ", words)}");


//--------------------------------
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orders = orderStream.Split(",");
// Array.Sort(orders);
// foreach (string order in orders)
// {
//   string error = order.Length != 4 ? "- Error" : "";
//   Console.WriteLine($"{order}\t{error}");
// }


//========= Format Alphanumeric Data for Presentation in C# 
//--------------------------------
// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);
// Console.WriteLine($"{first} {second}!");

// decimal price = 67.55m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// Console.WriteLine($"Measurement: {measurement:N2} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

//--------------------------------
// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));
// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(10);

// Console.WriteLine(formattedLine);

//========= Modify the content of strings using built-in string data type methods in C#

//--------------------------------
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition + 1, length - 1));


// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//--------------------------------
// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

// string message = "(What if) there are (more than) one (set of parentheses)?";
// // string message = "(What if there are (more than) one) (set of parentheses)?";
// while (true)
// {
//   int openingPosition = message.IndexOf('(');
//   if (openingPosition == -1) break;

//   openingPosition += 1;
//   int closingPosition = message.IndexOf(')');
//   int length = closingPosition - openingPosition;
//   Console.WriteLine(message.Substring(openingPosition, length));

//   // Note the overload of the Substring to return only the remaining 
//   // unprocessed message:
//   message = message.Substring(closingPosition + 1);
// }

//--------------------------------
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);


//========= Write your first C# method
//--------------------------------
// SayHello();

// void SayHello()
// {
//   Console.WriteLine("Hello World!");
// }

//--------------------------------
// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers()
// {
//   Random random = new Random();

//   for (int i = 0; i < 5; i++)
//   {
//     Console.Write($"{random.Next(1, 100)} ");
//   }

//   Console.WriteLine();
// }

//========= Create C# methods with parameters
//--------------------------------
// SayHello("Before"); // works

// // Return type is `void`
// void SayHello(string msg)
// {
//   Console.WriteLine($"Hello World! - {msg}");
// }

// SayHello("After"); // works

//--------------------------------
// int[] array = { 1, 2, 3, 4, 5 };

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array)
// {
//   foreach (int a in array)
//   {
//     Console.Write($"{a} ");
//   }
//   Console.WriteLine();
// }

// void Clear(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = 0;
//   }
// }

//=========
//--------------------------------

/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

// string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

// string messageText = "";

// foreach (string name in names)
// {
//   if (name == "Sophia")
//     messageText = SophiaMessage();
//   else if (name == "Andrew")
//     messageText = AndrewMessage();
//   else if (name == "AllGreetings")
//     messageText = SophiaMessage();
//   messageText = messageText + "\n\r" + AndrewMessage();

//   Console.WriteLine(messageText + "\n\r");
// }

// bool pauseCode = true;
// while (pauseCode == true) ;

// static string SophiaMessage()
// {
//   return "Hello, my name is Sophia.";
// }

// static string AndrewMessage()
// {
//   return "Hi, my name is Andrew. Good to meet you.";
// }

//--------------------------------
//=========
//--------------------------------

checked
{
  try
  {
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;
    int result = num1 + num2;
    Console.WriteLine("Result: " + result);
  }
  catch (OverflowException ex)
  {
    Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
  }
}

try
{
  string? str = null;
  int length = str.Length;
  Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
  Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
  int[] numbers = new int[5];
  numbers[5] = 10;
  Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
  Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
  int num3 = 10;
  int num4 = 0;
  int result2 = num3 / num4;
  Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
  Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");
//--------------------------------