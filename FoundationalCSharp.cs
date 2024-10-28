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


